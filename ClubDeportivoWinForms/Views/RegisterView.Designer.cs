namespace ClubDeportivoWinForms
{
    partial class RegisterView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterView));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label_welcome = new Label();
            textBox_Nombre = new TextBox();
            textBox_DNI = new TextBox();
            registrar = new Button();
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            textBox_Telefono = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 15, 15);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label_welcome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 753);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.team;
            pictureBox1.Location = new Point(111, 199);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 227);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(40, 479);
            label1.Name = "label1";
            label1.Size = new Size(337, 37);
            label1.TabIndex = 4;
            label1.Text = "DEL CLUB SUPERNOVA";
            // 
            // label_welcome
            // 
            label_welcome.Anchor = AnchorStyles.None;
            label_welcome.AutoSize = true;
            label_welcome.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_welcome.ForeColor = SystemColors.Control;
            label_welcome.Location = new Point(27, 440);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(372, 37);
            label_welcome.TabIndex = 3;
            label_welcome.Text = "BIENVENIDO AL ACCESO";
            // 
            // textBox_Nombre
            // 
            textBox_Nombre.Anchor = AnchorStyles.None;
            textBox_Nombre.BackColor = Color.FromArgb(224, 224, 224);
            textBox_Nombre.BorderStyle = BorderStyle.None;
            textBox_Nombre.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Nombre.ForeColor = SystemColors.ControlDarkDark;
            textBox_Nombre.Location = new Point(615, 34);
            textBox_Nombre.Name = "textBox_Nombre";
            textBox_Nombre.PlaceholderText = "NOMBRE";
            textBox_Nombre.Size = new Size(361, 31);
            textBox_Nombre.TabIndex = 3;
            // 
            // textBox_DNI
            // 
            textBox_DNI.Anchor = AnchorStyles.None;
            textBox_DNI.BackColor = Color.FromArgb(224, 224, 224);
            textBox_DNI.BorderStyle = BorderStyle.None;
            textBox_DNI.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_DNI.ForeColor = SystemColors.ControlDarkDark;
            textBox_DNI.Location = new Point(615, 76);
            textBox_DNI.Name = "textBox_DNI";
            textBox_DNI.PlaceholderText = "DNI";
            textBox_DNI.Size = new Size(361, 31);
            textBox_DNI.TabIndex = 4;
            // 
            // registrar
            // 
            registrar.Anchor = AnchorStyles.None;
            registrar.BackColor = Color.MediumSlateBlue;
            registrar.Cursor = Cursors.Hand;
            registrar.FlatStyle = FlatStyle.Flat;
            registrar.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            registrar.ForeColor = SystemColors.ButtonHighlight;
            registrar.Location = new Point(708, 558);
            registrar.Name = "registrar";
            registrar.Size = new Size(202, 55);
            registrar.TabIndex = 10;
            registrar.Text = "Registrar";
            registrar.UseVisualStyleBackColor = false;
            registrar.Click += registrar_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(textBox_Telefono);
            panel2.Controls.Add(textBox_Nombre);
            panel2.Controls.Add(textBox_DNI);
            panel2.Location = new Point(3, 304);
            panel2.Name = "panel2";
            panel2.Size = new Size(1179, 211);
            panel2.TabIndex = 9;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.ControlDarkDark;
            checkBox1.Location = new Point(615, 157);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(266, 35);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "QUIERO SER SOCIO";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox_Telefono
            // 
            textBox_Telefono.Anchor = AnchorStyles.None;
            textBox_Telefono.BackColor = Color.FromArgb(224, 224, 224);
            textBox_Telefono.BorderStyle = BorderStyle.None;
            textBox_Telefono.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Telefono.ForeColor = SystemColors.ControlDarkDark;
            textBox_Telefono.Location = new Point(615, 118);
            textBox_Telefono.Name = "textBox_Telefono";
            textBox_Telefono.PlaceholderText = "TELÉFONO";
            textBox_Telefono.Size = new Size(361, 31);
            textBox_Telefono.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(689, 227);
            label3.Name = "label3";
            label3.Size = new Size(224, 40);
            label3.TabIndex = 11;
            label3.Text = "REGISTRARSE";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumSlateBlue;
            label4.Location = new Point(611, 671);
            label4.Name = "label4";
            label4.Size = new Size(420, 31);
            label4.TabIndex = 13;
            label4.Text = "HACE CLICK ACÁ E INICIA SESIÓN";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(613, 640);
            label2.Name = "label2";
            label2.Size = new Size(429, 31);
            label2.TabIndex = 12;
            label2.Text = "¿YA TENES UNA CUENTA CREADA?";
            // 
            // RegisterView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(registrar);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Supernova";
            FormClosing += RegisterView_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private TextBox textBox_Nombre;
        private TextBox textBox_DNI;
        private Button registrar;
        private Panel panel2;
        private TextBox textBox_Telefono;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label_welcome;
        private Label label3;
        private Label label4;
        private Label label2;
        private CheckBox checkBox1;
    }
}