namespace Tienda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flowPokemon = new FlowLayoutPanel();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            lblTotalGastado = new Label();
            lstComprados = new ListView();
            imageListPokemon = new ImageList(components);
            lblTotal = new Label();
            btnEliminar = new Button();
            btnSobreNosotros = new Button();
            btnComprarFinal = new Button();
            txtSaldo = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowPokemon
            // 
            flowPokemon.AutoScroll = true;
            flowPokemon.BackColor = Color.White;
            flowPokemon.Location = new Point(46, 35);
            flowPokemon.Name = "flowPokemon";
            flowPokemon.Size = new Size(624, 376);
            flowPokemon.TabIndex = 0;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.FromArgb(255, 255, 128);
            btnAnterior.FlatAppearance.BorderSize = 0;
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Font = new Font("Comic Sans MS", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAnterior.Location = new Point(288, 444);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(79, 24);
            btnAnterior.TabIndex = 3;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.FromArgb(255, 255, 128);
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Comic Sans MS", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSiguiente.Location = new Point(373, 444);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(79, 24);
            btnSiguiente.TabIndex = 4;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // lblTotalGastado
            // 
            lblTotalGastado.AutoSize = true;
            lblTotalGastado.Location = new Point(236, 15);
            lblTotalGastado.Name = "lblTotalGastado";
            lblTotalGastado.Size = new Size(0, 17);
            lblTotalGastado.TabIndex = 7;
            // 
            // lstComprados
            // 
            lstComprados.BackColor = Color.FromArgb(224, 224, 224);
            lstComprados.LargeImageList = imageListPokemon;
            lstComprados.Location = new Point(741, 62);
            lstComprados.Name = "lstComprados";
            lstComprados.Size = new Size(146, 252);
            lstComprados.TabIndex = 8;
            lstComprados.UseCompatibleStateImageBehavior = false;
            // 
            // imageListPokemon
            // 
            imageListPokemon.ColorDepth = ColorDepth.Depth32Bit;
            imageListPokemon.ImageSize = new Size(16, 16);
            imageListPokemon.TransparentColor = Color.Transparent;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(727, 444);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 17);
            lblTotal.TabIndex = 5;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 255, 128);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Comic Sans MS", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(812, 345);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(79, 24);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnSobreNosotros
            // 
            btnSobreNosotros.BackColor = Color.FromArgb(255, 255, 128);
            btnSobreNosotros.FlatStyle = FlatStyle.Flat;
            btnSobreNosotros.Font = new Font("Comic Sans MS", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSobreNosotros.Location = new Point(29, 444);
            btnSobreNosotros.Margin = new Padding(2);
            btnSobreNosotros.Name = "btnSobreNosotros";
            btnSobreNosotros.Size = new Size(120, 31);
            btnSobreNosotros.TabIndex = 9;
            btnSobreNosotros.Text = "Sobre nosotros";
            btnSobreNosotros.UseVisualStyleBackColor = false;
            btnSobreNosotros.Click += btnSobreNosotros_Click;
            // 
            // btnComprarFinal
            // 
            btnComprarFinal.BackColor = Color.FromArgb(255, 255, 128);
            btnComprarFinal.FlatAppearance.BorderSize = 0;
            btnComprarFinal.FlatStyle = FlatStyle.Flat;
            btnComprarFinal.Font = new Font("Comic Sans MS", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnComprarFinal.Location = new Point(727, 345);
            btnComprarFinal.Name = "btnComprarFinal";
            btnComprarFinal.Size = new Size(79, 24);
            btnComprarFinal.TabIndex = 4;
            btnComprarFinal.Text = "Comprar";
            btnComprarFinal.UseVisualStyleBackColor = false;
            btnComprarFinal.Click += btnComprar_Click;
            // 
            // txtSaldo
            // 
            txtSaldo.BackColor = SystemColors.InactiveCaption;
            txtSaldo.Location = new Point(503, 444);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(105, 25);
            txtSaldo.TabIndex = 10;
            txtSaldo.KeyPress += txtSaldo_KeyPress;
            txtSaldo.Leave += txtSaldo_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(614, 436);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(899, 507);
            Controls.Add(pictureBox1);
            Controls.Add(txtSaldo);
            Controls.Add(btnSobreNosotros);
            Controls.Add(lstComprados);
            Controls.Add(lblTotalGastado);
            Controls.Add(btnAnterior);
            Controls.Add(btnEliminar);
            Controls.Add(btnComprarFinal);
            Controls.Add(btnSiguiente);
            Controls.Add(lblTotal);
            Controls.Add(flowPokemon);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowPokemon;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Label lblTotalGastado;
        private ListView lstComprados;
        private ImageList imageListPokemon;
        private Label lblTotal;
        private Button btnEliminar;
        private Button btnSobreNosotros;
        private Button btnComprarFinal;
        private TextBox txtSaldo;
        private PictureBox pictureBox1;
    }
}
