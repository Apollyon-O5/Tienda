using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Tienda
{
    public partial class SobreNosotros : Form
    {
        public SobreNosotros()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
        private void SobreNosotros_Load(object sender, EventArgs e)
        {
            RedondearBoton(btnVolver, 40);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
