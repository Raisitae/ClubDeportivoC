namespace ClubDeportivoWinForms
{
    partial class AdminView
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
            button2 = new Button();
            label_welcome = new Label();
            panel1 = new Panel();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.MediumAquamarine;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(618, 381);
            button2.Name = "button2";
            button2.Size = new Size(170, 55);
            button2.TabIndex = 9;
            button2.Text = "Cerrar Sesion";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.Font = new Font("Lucida Sans Unicode", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label_welcome.ForeColor = SystemColors.Control;
            label_welcome.Location = new Point(29, 37);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(413, 42);
            label_welcome.TabIndex = 1;
            label_welcome.Text = "Panel de administracion";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumAquamarine;
            panel1.Controls.Add(label_welcome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 8;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.BackColor = Color.MediumAquamarine;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(12, 150);
            button3.Name = "button3";
            button3.Size = new Size(346, 55);
            button3.TabIndex = 11;
            button3.Text = "Traer lista de socios";
            button3.UseVisualStyleBackColor = false;
            button3.Click += listPrueba_click;
            // 
            // AdminView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Name = "AdminView";
            Text = "AdminView";
            Activated += AdminView_Activated;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Label label_welcome;
        private Panel panel1;
        private Button button3;
    }
}