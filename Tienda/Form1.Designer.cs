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
            flowPokemon.SuspendLayout();
            SuspendLayout();
            // 
            // flowPokemon
            // 
            flowPokemon.AutoScroll = true;
            flowPokemon.Controls.Add(btnAnterior);
            flowPokemon.Controls.Add(btnSiguiente);
            flowPokemon.Controls.Add(lblSaldo);
            flowPokemon.Dock = DockStyle.Fill;
            flowPokemon.Location = new Point(0, 0);
            flowPokemon.Name = "flowPokemon";
            flowPokemon.Size = new Size(800, 450);
            flowPokemon.TabIndex = 0;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(3, 3);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(79, 24);
            btnAnterior.TabIndex = 0;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(88, 3);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(79, 24);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(173, 0);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(0, 17);
            lblSaldo.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowPokemon);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            flowPokemon.ResumeLayout(false);
            flowPokemon.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowPokemon;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Label lblSaldo;
    }
}
