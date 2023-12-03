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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label_welcome = new Label();
            label2 = new Label();
            textBox_usuario = new TextBox();
            textBox_pass = new TextBox();
            panel2 = new Panel();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 13, 13);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label_welcome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 753);
            panel1.TabIndex = 0;
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
            pictureBox1.TabIndex = 2;
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
            label1.TabIndex = 1;
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
            label_welcome.TabIndex = 0;
            label_welcome.Text = "BIENVENIDO AL ACCESO";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(717, 243);
            label2.Name = "label2";
            label2.Size = new Size(262, 40);
            label2.TabIndex = 2;
            label2.Text = "INICIAR SESIÓN";
            // 
            // textBox_usuario
            // 
            textBox_usuario.Anchor = AnchorStyles.None;
            textBox_usuario.BackColor = Color.FromArgb(224, 224, 224);
            textBox_usuario.BorderStyle = BorderStyle.None;
            textBox_usuario.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_usuario.ForeColor = SystemColors.ControlDarkDark;
            textBox_usuario.Location = new Point(641, 17);
            textBox_usuario.Name = "textBox_usuario";
            textBox_usuario.PlaceholderText = "USUARIO";
            textBox_usuario.Size = new Size(307, 31);
            textBox_usuario.TabIndex = 3;
            // 
            // textBox_pass
            // 
            textBox_pass.Anchor = AnchorStyles.None;
            textBox_pass.BackColor = Color.FromArgb(224, 224, 224);
            textBox_pass.BorderStyle = BorderStyle.None;
            textBox_pass.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_pass.ForeColor = SystemColors.ControlDarkDark;
            textBox_pass.Location = new Point(641, 61);
            textBox_pass.Name = "textBox_pass";
            textBox_pass.PlaceholderText = "CONTRASEÑA";
            textBox_pass.Size = new Size(307, 31);
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
            panel2.Location = new Point(3, 309);
            panel2.Name = "panel2";
            panel2.Size = new Size(1179, 121);
            panel2.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(654, 597);
            label3.Name = "label3";
            label3.Size = new Size(374, 31);
            label3.TabIndex = 8;
            label3.Text = "¿NO TENES CUENTA CREADA?";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.MediumSlateBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(749, 511);
            button1.Name = "button1";
            button1.Size = new Size(202, 55);
            button1.TabIndex = 6;
            button1.Text = "INGRESAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumSlateBlue;
            label4.Location = new Point(645, 629);
            label4.Name = "label4";
            label4.Size = new Size(395, 31);
            label4.TabIndex = 9;
            label4.Text = "HACE CLICK ACÁ Y REGISTRATE";
            label4.Click += label4_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1182, 753);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(panel2);
            ForeColor = SystemColors.Desktop;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Supernova";
            FormClosing += LoginView_FormClosing;
            Load += LoginView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Label label3;
        private Button button1;
        private Label label4;
        private PictureBox pictureBox1;
    }
}