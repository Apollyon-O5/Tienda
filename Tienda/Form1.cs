using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda
{
    public partial class Form1 : Form
    {
        private HttpClient client = new HttpClient();
        private int paginaActual = 1;
        private int porPagina = 12;
        private int saldo = 200;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            lblSaldo.Text = "Saldo: " + saldo + " Pokébolas";
            await CargarPagina();
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
            btnComprar.Text = "Comprar";
            btnComprar.Top = 175;
            btnComprar.Left = 25;
            btnComprar.Width = 100;

            btnComprar.Click += (s, e) =>
            {
                if (saldo >= precio)
                {
                    saldo -= precio;
                    lblSaldo.Text = "Saldo: " + saldo + " Pokébolas";
                    MessageBox.Show($"Compraste a {pokemon.name}");
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