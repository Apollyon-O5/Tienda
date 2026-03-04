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
            flowPokemon = new FlowLayoutPanel();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            lblSaldo = new Label();
            lblTotalGastado = new Label();
            btnComprarFinal = new Button();
            lstComprados = new ListView();
            imageListPokemon = new ImageList(components);
            lblTotal = new Label();
            btnEliminar = new Button();
            btnSobreNosotros = new Button();
            SuspendLayout();
            // 
            // flowPokemon
            // 
            flowPokemon.AutoScroll = true;
            flowPokemon.BackColor = Color.White;
            flowPokemon.Location = new Point(1, 62);
            flowPokemon.Margin = new Padding(4);
            flowPokemon.Name = "flowPokemon";
            flowPokemon.Size = new Size(1029, 553);
            flowPokemon.TabIndex = 0;
            flowPokemon.Paint += flowPokemon_Paint;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.FromArgb(255, 255, 128);
            btnAnterior.FlatAppearance.BorderSize = 0;
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Font = new Font("Comic Sans MS", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAnterior.Location = new Point(411, 653);
            btnAnterior.Margin = new Padding(4);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(113, 35);
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
            btnSiguiente.Location = new Point(533, 653);
            btnSiguiente.Margin = new Padding(4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(113, 35);
            btnSiguiente.TabIndex = 4;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(654, 649);
            lblSaldo.Margin = new Padding(4, 0, 4, 0);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(0, 25);
            lblSaldo.TabIndex = 5;
            // 
            // lblTotalGastado
            // 
            lblTotalGastado.AutoSize = true;
            lblTotalGastado.Location = new Point(337, 22);
            lblTotalGastado.Margin = new Padding(4, 0, 4, 0);
            lblTotalGastado.Name = "lblTotalGastado";
            lblTotalGastado.Size = new Size(0, 25);
            lblTotalGastado.TabIndex = 7;
            // 
            // btnComprarFinal
            // 
            btnComprarFinal.BackColor = Color.FromArgb(255, 255, 128);
            btnComprarFinal.FlatAppearance.BorderSize = 0;
            btnComprarFinal.FlatStyle = FlatStyle.Flat;
            btnComprarFinal.Font = new Font("Comic Sans MS", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnComprarFinal.Location = new Point(1039, 507);
            btnComprarFinal.Margin = new Padding(4);
            btnComprarFinal.Name = "btnComprarFinal";
            btnComprarFinal.Size = new Size(113, 35);
            btnComprarFinal.TabIndex = 4;
            btnComprarFinal.Text = "Comprar";
            btnComprarFinal.UseVisualStyleBackColor = false;
            btnComprarFinal.Click += btnComprar_Click;
            // 
            // lstComprados
            // 
            lstComprados.BackColor = Color.FromArgb(224, 224, 224);
            lstComprados.LargeImageList = imageListPokemon;
            lstComprados.Location = new Point(1059, 91);
            lstComprados.Margin = new Padding(4);
            lstComprados.Name = "lstComprados";
            lstComprados.Size = new Size(207, 369);
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
            lblTotal.Location = new Point(1081, 629);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 25);
            lblTotal.TabIndex = 5;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 255, 128);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Comic Sans MS", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(1160, 507);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(113, 35);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnComprar_Click;
            // 
            // btnSobreNosotros
            // 
            btnSobreNosotros.BackColor = Color.FromArgb(255, 255, 128);
            btnSobreNosotros.FlatStyle = FlatStyle.Flat;
            btnSobreNosotros.Font = new Font("Comic Sans MS", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSobreNosotros.Location = new Point(42, 667);
            btnSobreNosotros.Name = "btnSobreNosotros";
            btnSobreNosotros.Size = new Size(167, 36);
            btnSobreNosotros.TabIndex = 9;
            btnSobreNosotros.Text = "Sobre nosotros";
            btnSobreNosotros.UseVisualStyleBackColor = false;
            btnSobreNosotros.Click += btnSobreNosotros_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1284, 746);
            Controls.Add(btnSobreNosotros);
            Controls.Add(lstComprados);
            Controls.Add(lblTotalGastado);
            Controls.Add(btnAnterior);
            Controls.Add(btnEliminar);
            Controls.Add(btnComprarFinal);
            Controls.Add(btnSiguiente);
            Controls.Add(lblTotal);
            Controls.Add(lblSaldo);
            Controls.Add(flowPokemon);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowPokemon;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Label lblSaldo;
        private Label lblTotalGastado;
        private Button btnComprarFinal;
        private ListView lstComprados;
        private ImageList imageListPokemon;
        private Label lblTotal;
        private Button btnEliminar;
        private Button btnSobreNosotros;
    }
}
