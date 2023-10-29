namespace ClubDeportivoWinForms
{
    partial class LoginView
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
            panel1 = new Panel();
            label1 = new Label();
            label_welcome = new Label();
            label2 = new Label();
            textBox_usuario = new TextBox();
            textBox_pass = new TextBox();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumAquamarine;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label_welcome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 451);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.MediumAquamarine;
            label1.Font = new Font("Lucida Sans Unicode", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(32, 220);
            label1.Name = "label1";
            label1.Size = new Size(317, 42);
            label1.TabIndex = 1;
            label1.Text = "del club deportivo";
            // 
            // label_welcome
            // 
            label_welcome.Anchor = AnchorStyles.None;
            label_welcome.AutoSize = true;
            label_welcome.Font = new Font("Lucida Sans Unicode", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label_welcome.ForeColor = SystemColors.Control;
            label_welcome.Location = new Point(32, 172);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(359, 42);
            label_welcome.TabIndex = 0;
            label_welcome.Text = "Bienvenido al acceso";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(526, 91);
            label2.Name = "label2";
            label2.Size = new Size(179, 34);
            label2.TabIndex = 2;
            label2.Text = "Inicie sesion";
            // 
            // textBox_usuario
            // 
            textBox_usuario.Anchor = AnchorStyles.None;
            textBox_usuario.BackColor = Color.FromArgb(224, 224, 224);
            textBox_usuario.BorderStyle = BorderStyle.None;
            textBox_usuario.Font = new Font("Lucida Sans Unicode", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_usuario.ForeColor = SystemColors.ControlDarkDark;
            textBox_usuario.Location = new Point(450, 17);
            textBox_usuario.Name = "textBox_usuario";
            textBox_usuario.PlaceholderText = "Usuario";
            textBox_usuario.Size = new Size(307, 36);
            textBox_usuario.TabIndex = 3;
            // 
            // textBox_pass
            // 
            textBox_pass.Anchor = AnchorStyles.None;
            textBox_pass.BackColor = Color.FromArgb(224, 224, 224);
            textBox_pass.BorderStyle = BorderStyle.None;
            textBox_pass.Font = new Font("Lucida Sans Unicode", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_pass.ForeColor = SystemColors.ControlDarkDark;
            textBox_pass.Location = new Point(450, 61);
            textBox_pass.Name = "textBox_pass";
            textBox_pass.PlaceholderText = "Contraseña";
            textBox_pass.Size = new Size(307, 36);
            textBox_pass.TabIndex = 4;
            textBox_pass.Click += textBox_pass_Click;
            textBox_pass.Enter += textBox_pass_Enter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(textBox_usuario);
            panel2.Controls.Add(textBox_pass);
            panel2.Location = new Point(3, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(797, 121);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.MediumAquamarine;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(105, 305);
            button1.Name = "button1";
            button1.Size = new Size(170, 55);
            button1.TabIndex = 6;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(421, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(379, 451);
            panel3.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(67, 375);
            label3.Name = "label3";
            label3.Size = new Size(241, 23);
            label3.TabIndex = 8;
            label3.Text = "No tenes cuenta creada?";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumAquamarine;
            label4.Location = new Point(54, 398);
            label4.Name = "label4";
            label4.Size = new Size(285, 23);
            label4.TabIndex = 9;
            label4.Text = "Hace click acá y registrate";
            label4.Click += label4_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 451);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "LoginView";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Label label_welcome;
        private Label label1;
        private Label label2;
        private TextBox textBox_usuario;
        private TextBox textBox_pass;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Label label4;
        private Label label3;
    }
}