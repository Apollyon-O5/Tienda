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
            SuspendLayout();
            // 
            // flowPokemon
            // 
            flowPokemon.AutoScroll = true;
            flowPokemon.Location = new Point(1, 42);
            flowPokemon.Name = "flowPokemon";
            flowPokemon.Size = new Size(720, 376);
            flowPokemon.TabIndex = 0;
            flowPokemon.Paint += flowPokemon_Paint;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(288, 444);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(79, 24);
            btnAnterior.TabIndex = 3;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(373, 444);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(79, 24);
            btnSiguiente.TabIndex = 4;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(458, 441);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(0, 17);
            lblSaldo.TabIndex = 5;
            // 
            // lblTotalGastado
            // 
            lblTotalGastado.AutoSize = true;
            lblTotalGastado.Location = new Point(236, 15);
            lblTotalGastado.Name = "lblTotalGastado";
            lblTotalGastado.Size = new Size(0, 17);
            lblTotalGastado.TabIndex = 7;
            // 
            // btnComprarFinal
            // 
            btnComprarFinal.Location = new Point(727, 345);
            btnComprarFinal.Name = "btnComprarFinal";
            btnComprarFinal.Size = new Size(79, 24);
            btnComprarFinal.TabIndex = 4;
            btnComprarFinal.Text = "Comprar";
            btnComprarFinal.UseVisualStyleBackColor = true;
            btnComprarFinal.Click += btnComprar_Click;
            // 
            // lstComprados
            // 
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
            lblTotal.Location = new Point(757, 428);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 17);
            lblTotal.TabIndex = 5;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(812, 345);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(79, 24);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnComprar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 507);
            Controls.Add(lstComprados);
            Controls.Add(lblTotalGastado);
            Controls.Add(btnAnterior);
            Controls.Add(btnEliminar);
            Controls.Add(btnComprarFinal);
            Controls.Add(btnSiguiente);
            Controls.Add(lblTotal);
            Controls.Add(lblSaldo);
            Controls.Add(flowPokemon);
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
    }
}
