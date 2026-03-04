using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace Tienda
{
    public partial class Form1 : Form
    {
        private HttpClient client = new HttpClient();
        private int paginaActual = 1;
        private int porPagina = 12;
        private int saldo = 200;
        private List<string> pokemonComprados = new List<string>();
        private int totalGastado = 0;
        private string conexion = "Server=ROBERTO\\ROBERTOABREGO;Database=TiendaPokemon;User Id=sa;Password=sa123456;TrustServerCertificate=True;";
        private int transaccionActual;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            btnSiguiente.Click += btnSiguiente_Click;
            btnAnterior.Click += btnAnterior_Click;
            btnEliminar.Click += btnEliminar_Click;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            lblSaldo.Text = "Saldo: " + saldo + " Pokébolas";
            await CargarPagina();
            //entre mayores son los numeros mas redondo son los botones
            // no poner mas de 45 ya que la forma que adquieren es parecia a los dulces con dos triangulos apuntando al ovalo
            RedondearBoton(btnAnterior, 40);
            RedondearBoton(btnSiguiente, 40);
            RedondearBoton(btnComprarFinal, 40);
            RedondearBoton(btnEliminar, 40);
            RedondearBoton(btnSobreNosotros, 40);


        }
        private void RedondearBoton(Button boton, int radio)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(boton.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(boton.Width - radio, boton.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, boton.Height - radio, radio, radio, 90, 90);
            path.CloseAllFigures();

            boton.Region = new Region(path);
        }



        private async Task CargarPagina()
        {
            flowPokemon.Controls.Clear();

            int inicio = (paginaActual - 1) * porPagina + 1;
            int fin = inicio + porPagina;

            for (int i = inicio; i < fin; i++)
            {
                await CrearTarjetaPokemon(i);
            }
        }

        private async Task CrearTarjetaPokemon(int id)
        {
            var response = await client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}");
            var json = await response.Content.ReadAsStringAsync();
            var pokemon = JsonSerializer.Deserialize<Pokemon>(json);

            Panel card = new Panel();
            card.Width = 150;
            card.Height = 220;
            card.BorderStyle = BorderStyle.FixedSingle;

            PictureBox pic = new PictureBox();
            pic.Width = 120;
            pic.Height = 100;
            pic.Top = 10;
            pic.Left = 15;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Load(pokemon.sprites.front_default);

            Label lblNombre = new Label();
            lblNombre.Text = pokemon.name.ToUpper();
            lblNombre.Top = 115;
            lblNombre.Left = 10;
            lblNombre.Width = 130;

            Label lblTipo = new Label();
            lblTipo.Text = "Tipo: " + pokemon.types[0].type.name;
            lblTipo.Top = 135;
            lblTipo.Left = 10;
            lblTipo.Width = 130;

            int precio = id * 2;

            Label lblPrecio = new Label();
            lblPrecio.Text = "Precio: " + precio;
            lblPrecio.Top = 155;
            lblPrecio.Left = 10;
            lblPrecio.Width = 130;

            Button btnComprar = new Button();
            btnComprar.Text = "Agregar";
            btnComprar.Top = 175;
            btnComprar.Left = 25;
            btnComprar.Width = 100;

            btnComprar.Click += async (s, e) =>
            {
                if (saldo >= precio)
                {
                    saldo -= precio;
                    totalGastado += precio;

                    lblSaldo.Text = "Saldo: " + saldo + " Pokébolas";
                    lblTotal.Text = "Total: " + totalGastado + " PB";

                    // Descargar imagen como Bitmap
                    var stream = await client.GetStreamAsync(pokemon.sprites.front_default);
                    var img = System.Drawing.Image.FromStream(stream);

                    imageListPokemon.Images.Add(pokemon.name, img);

                    ListViewItem item = new ListViewItem(
                        pokemon.name.ToUpper() + " - " + precio + " PB"
                    );

                    // Guardamos el precio en Tag
                    item.Tag = precio;

                    item.ImageKey = pokemon.name;

                    lstComprados.Items.Add(item);


                    MessageBox.Show($"{pokemon.name} agregado correctamente");
                }
                else
                {
                    MessageBox.Show("No tienes suficientes Pokébolas");
                }
            };

            card.Controls.Add(pic);
            card.Controls.Add(lblNombre);
            card.Controls.Add(lblTipo);
            card.Controls.Add(lblPrecio);
            card.Controls.Add(btnComprar);

            flowPokemon.Controls.Add(card);
        }

        private async void btnSiguiente_Click(object sender, EventArgs e)
        {
            paginaActual++;
            await CargarPagina();
        }

        private async void btnAnterior_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
                await CargarPagina();
            }
        }

        private void flowPokemon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstComprados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (lstComprados.Items.Count == 0)
            {
                MessageBox.Show("No hay Pokémon en la lista.");
                return;
            }

            // 🔥 1. Crear nueva transacción JUSTO al comprar
            CrearNuevaTransaccion();

            using (SqlConnection con = new SqlConnection(conexion))
            {
                con.Open();

                foreach (ListViewItem item in lstComprados.Items)
                {
                    int precio = (int)item.Tag;
                    string nombre = item.Text.Split('-')[0].Trim();

                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO PokemonComprado (TransaccionId, Nombre, Precio) VALUES (@t, @n, @p)",
                        con);

                    cmd.Parameters.AddWithValue("@t", transaccionActual);
                    cmd.Parameters.AddWithValue("@n", nombre);
                    cmd.Parameters.AddWithValue("@p", precio);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Compra realizada correctamente.");

            // 🔥 LIMPIAR TODO
            lstComprados.Items.Clear();
            imageListPokemon.Images.Clear();
            totalGastado = 0;
            lblTotal.Text = "Total: 0 PB";
        }
        private void CrearNuevaTransaccion()
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Transaccion (SaldoInicial) OUTPUT INSERTED.Id VALUES (@saldo)",
                    con);

                cmd.Parameters.AddWithValue("@saldo", saldo);

                transaccionActual = (int)cmd.ExecuteScalar();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstComprados.SelectedItems.Count > 0)
            {
                ListViewItem item = lstComprados.SelectedItems[0];

                int precio = (int)item.Tag;

                // Restar del total
                totalGastado -= precio;
                lblTotal.Text = "Total: " + totalGastado + " PB";

                // Devolver saldo
                saldo += precio;
                lblSaldo.Text = "Saldo: " + saldo + " Pokébolas";

                // Eliminar imagen del ImageList
                imageListPokemon.Images.RemoveByKey(item.ImageKey);

                // Eliminar item
                lstComprados.Items.Remove(item);
            }
            else
            {
                MessageBox.Show("Selecciona un Pokémon para eliminar.");
            }
        }

        private void btnSobreNosotros_Click(object sender, EventArgs e)
        {
            SobreNosotros ventana = new SobreNosotros();
            ventana.ShowDialog();
        }
    }

    public class Pokemon
    {
        public string name { get; set; }
        public List<TypeInfo> types { get; set; }
        public Sprites sprites { get; set; }
    }

    public class TypeInfo
    {
        public TypeDetail type { get; set; }
    }

    public class TypeDetail
    {
        public string name { get; set; }
    }

    public class Sprites
    {
        public string front_default { get; set; }
    }


    }