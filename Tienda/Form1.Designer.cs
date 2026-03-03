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
            flowPokemon = new FlowLayoutPanel();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            lblSaldo = new Label();
            lstComprados = new ListBox();
            lblTotalGastado = new Label();
            btnComprar = new Button();
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
            // lstComprados
            // 
            lstComprados.FormattingEnabled = true;
            lstComprados.Location = new Point(727, 98);
            lstComprados.Name = "lstComprados";
            lstComprados.Size = new Size(168, 225);
            lstComprados.TabIndex = 6;
            lstComprados.SelectedIndexChanged += lstComprados_SelectedIndexChanged;
            // 
            // lblTotalGastado
            // 
            lblTotalGastado.AutoSize = true;
            lblTotalGastado.Location = new Point(236, 15);
            lblTotalGastado.Name = "lblTotalGastado";
            lblTotalGastado.Size = new Size(0, 17);
            lblTotalGastado.TabIndex = 7;
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(771, 347);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(79, 24);
            btnComprar.TabIndex = 4;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 507);
            Controls.Add(lblTotalGastado);
            Controls.Add(lstComprados);
            Controls.Add(btnAnterior);
            Controls.Add(btnComprar);
            Controls.Add(btnSiguiente);
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
        private ListBox lstComprados;
        private Label lblTotalGastado;
        private Button btnComprar;
    }
}
