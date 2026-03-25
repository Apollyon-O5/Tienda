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
        private int saldo = 200; //Si no se ingresa saldo este sera 200 por defecto
        private int totalGastado = 0;
        private string conexion = "Server=ROBERTO\\ROBERTOABREGO;Database=TiendaPokemon;User Id=sa;Password=sa123456;TrustServerCertificate=True;";
        private int transaccionActual;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            txtSaldo.Text = saldo.ToString();
            btnSiguiente.Click += btnSiguiente_Click;
            btnAnterior.Click += btnAnterior_Click;
            btnEliminar.Click += btnEliminar_Click;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            txtSaldo.Text = saldo.ToString();
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
            card.Width = 170;
            card.Height = 250;
            card.Margin = new Padding(10);
            card.Padding = new Padding(5);

            string tipoPokemon = pokemon.types[0].type.name;

            // 🎨 Color por tipo
            card.BackColor = ObtenerColorTipo(tipoPokemon);

            // 🔥 Bordes redondeados
            GraphicsPath path = new GraphicsPath();
            int radio = 20;

            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(card.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(card.Width - radio, card.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, card.Height - radio, radio, radio, 90, 90);
            path.CloseAllFigures();

            card.Region = new Region(path);

            // 🖼 Imagen centrada
            PictureBox pic = new PictureBox();
            pic.Width = 120;
            pic.Height = 100;
            pic.Top = 20;
            pic.Left = (card.Width - pic.Width) / 2;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.BackColor = Color.Transparent;
            pic.Load(pokemon.sprites.front_default);

            // 🏷 Nombre estilizado
            Label lblNombre = new Label();
            lblNombre.Text = pokemon.name.ToUpper();
            lblNombre.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Width = card.Width;
            lblNombre.Top = 125;
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;

            // 🔹 Tipo estilizado
            Label lblTipo = new Label();
            lblTipo.Text = tipoPokemon.ToUpper();
            lblTipo.Font = new Font("Segoe UI", 8, FontStyle.Italic);
            lblTipo.Width = card.Width;
            lblTipo.Top = 150;
            lblTipo.TextAlign = ContentAlignment.MiddleCenter;

            // 💰 Precio destacado
            int precio = id * 2;

            Label lblPrecio = new Label();
            lblPrecio.Text = precio + " PB";
            lblPrecio.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblPrecio.ForeColor = Color.DarkGreen;
            lblPrecio.Width = card.Width;
            lblPrecio.Top = 170;
            lblPrecio.TextAlign = ContentAlignment.MiddleCenter;

            // 🟢 Botón moderno
            Button btnComprar = new Button();
            btnComprar.Text = "Agregar";
            btnComprar.Width = 110;
            btnComprar.Height = 30;
            btnComprar.Top = 200;
            btnComprar.Left = (card.Width - btnComprar.Width) / 2;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.BackColor = Color.Black;
            btnComprar.ForeColor = Color.White;
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.Cursor = Cursors.Hand;

            // Hover efecto
            btnComprar.MouseEnter += (s, e) =>
                btnComprar.BackColor = Color.DarkRed;

            btnComprar.MouseLeave += (s, e) =>
                btnComprar.BackColor = Color.Black;

            btnComprar.Click += async (s, e) =>
            {
                if (saldo >= precio)
                {
                    saldo -= precio;
                    totalGastado += precio;

                    txtSaldo.Text = saldo.ToString();
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

        private Color ObtenerColorTipo(string tipo)
        {
            switch (tipo)
            {
                case "grass": return Color.FromArgb(120, 200, 80);
                case "fire": return Color.FromArgb(240, 128, 48);
                case "water": return Color.FromArgb(104, 144, 240);
                case "electric": return Color.FromArgb(248, 208, 48);
                case "psychic": return Color.FromArgb(248, 88, 136);
                case "ice": return Color.FromArgb(152, 216, 216);
                case "dragon": return Color.FromArgb(112, 56, 248);
                case "dark": return Color.FromArgb(112, 88, 72);
                default: return Color.LightGray;
            }
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

                if (item.Tag is int precio)
                {
                    // Restar del total
                    totalGastado -= precio;
                    lblTotal.Text = "Total: " + totalGastado + " PB";

                    // Devolver saldo
                    saldo += precio;
                    txtSaldo.Text = saldo.ToString();

                    // Eliminar imagen del ImageList
                    imageListPokemon.Images.RemoveByKey(item.ImageKey);

                    // Eliminar item
                    lstComprados.Items.Remove(item);

                    MessageBox.Show($"Se ha eliminado a {item.Text}");

                }
                else
                {
                    MessageBox.Show("El precio no es válido.");
                }


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

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }
        private void txtSaldo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSaldo.Text))
            {
                MessageBox.Show("El saldo no puede estar vacío.");
                txtSaldo.Text = saldo.ToString();
                return;
            }

            if (int.TryParse(txtSaldo.Text, out int nuevoSaldo))
            {
                if (nuevoSaldo >= 0)
                {
                    saldo = nuevoSaldo; // Actualiza variable global
                }
                else
                {
                    MessageBox.Show("El saldo no puede ser negativo.");
                    txtSaldo.Text = saldo.ToString();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
                txtSaldo.Text = saldo.ToString();
            }
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