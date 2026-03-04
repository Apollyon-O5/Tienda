namespace Tienda
{
    partial class SobreNosotros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SobreNosotros));
            label1 = new Label();
            label2 = new Label();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.Font = new Font("Comic Sans MS", 20F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(197, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(264, 56);
            label1.TabIndex = 0;
            label1.Text = "equipo de trabajo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 255, 192);
            label2.Location = new Point(133, 95);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(442, 165);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(255, 255, 128);
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Comic Sans MS", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(296, 292);
            btnVolver.Margin = new Padding(2, 2, 2, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(78, 23);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // SobreNosotros
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(695, 358);
            Controls.Add(btnVolver);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "SobreNosotros";
            Text = "SobreNosotros";
            Load += SobreNosotros_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnVolver;
    }
}