namespace ClubDeportivoWinForms
{
    partial class UserView
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
            panel1 = new Panel();
            lbl_usuario = new Label();
            pictureBox1 = new PictureBox();
            label_welcome = new Label();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbl_pago = new Label();
            btn_pago = new Button();
            lbl_nombre = new Label();
            lbl_dni = new Label();
            lbl_socio = new Label();
            lbl_ultimopago = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            panel2 = new Panel();
            radioButton_Act = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(13, 13, 13);
            panel1.Controls.Add(lbl_usuario);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label_welcome);
            panel1.Location = new Point(-2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1186, 209);
            panel1.TabIndex = 8;
            // 
            // lbl_usuario
            // 
            lbl_usuario.Anchor = AnchorStyles.None;
            lbl_usuario.AutoSize = true;
            lbl_usuario.BackColor = Color.Transparent;
            lbl_usuario.Cursor = Cursors.Hand;
            lbl_usuario.Font = new Font("Century Gothic", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_usuario.ForeColor = Color.MediumSlateBlue;
            lbl_usuario.Location = new Point(314, 75);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(201, 51);
            lbl_usuario.TabIndex = 10;
            lbl_usuario.Text = "USUARIO";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.woman;
            pictureBox1.Location = new Point(913, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label_welcome
            // 
            label_welcome.Anchor = AnchorStyles.None;
            label_welcome.AutoSize = true;
            label_welcome.Font = new Font("Century Gothic", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label_welcome.ForeColor = SystemColors.Control;
            label_welcome.Location = new Point(59, 75);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(273, 51);
            label_welcome.TabIndex = 0;
            label_welcome.Text = "BIENVENIDO";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.MediumSlateBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(879, 663);
            button1.Name = "button1";
            button1.Size = new Size(277, 55);
            button1.TabIndex = 9;
            button1.Text = "CERRAR SESION";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(62, 248);
            label1.Name = "label1";
            label1.Size = new Size(210, 51);
            label1.TabIndex = 11;
            label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(62, 317);
            label2.Name = "label2";
            label2.Size = new Size(106, 51);
            label2.TabIndex = 12;
            label2.Text = "DNI:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(62, 388);
            label3.Name = "label3";
            label3.Size = new Size(263, 51);
            label3.TabIndex = 13;
            label3.Text = "MEMBRESÍA:";
            // 
            // lbl_pago
            // 
            lbl_pago.Anchor = AnchorStyles.None;
            lbl_pago.AutoSize = true;
            lbl_pago.BackColor = Color.Transparent;
            lbl_pago.Font = new Font("Century Gothic", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_pago.ForeColor = SystemColors.Control;
            lbl_pago.Location = new Point(62, 459);
            lbl_pago.Name = "lbl_pago";
            lbl_pago.Size = new Size(323, 51);
            lbl_pago.TabIndex = 14;
            lbl_pago.Text = "ÚLTIMO PAGO:";
            // 
            // btn_pago
            // 
            btn_pago.Anchor = AnchorStyles.None;
            btn_pago.BackColor = Color.MediumSlateBlue;
            btn_pago.Cursor = Cursors.Hand;
            btn_pago.FlatStyle = FlatStyle.Flat;
            btn_pago.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_pago.ForeColor = SystemColors.Control;
            btn_pago.Location = new Point(58, 663);
            btn_pago.Name = "btn_pago";
            btn_pago.Size = new Size(277, 55);
            btn_pago.TabIndex = 15;
            btn_pago.Text = "PAGAR";
            btn_pago.UseVisualStyleBackColor = false;
            btn_pago.Click += btn_pago_Click;
            // 
            // lbl_nombre
            // 
            lbl_nombre.Anchor = AnchorStyles.None;
            lbl_nombre.AutoSize = true;
            lbl_nombre.BackColor = Color.Transparent;
            lbl_nombre.Font = new Font("Century Gothic", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nombre.ForeColor = SystemColors.Control;
            lbl_nombre.Location = new Point(278, 248);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(199, 51);
            lbl_nombre.TabIndex = 16;
            lbl_nombre.Text = "NOMBRE";
            // 
            // lbl_dni
            // 
            lbl_dni.Anchor = AnchorStyles.None;
            lbl_dni.AutoSize = true;
            lbl_dni.BackColor = Color.Transparent;
            lbl_dni.Font = new Font("Century Gothic", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_dni.ForeColor = SystemColors.Control;
            lbl_dni.Location = new Point(174, 317);
            lbl_dni.Name = "lbl_dni";
            lbl_dni.Size = new Size(95, 51);
            lbl_dni.TabIndex = 17;
            lbl_dni.Text = "DNI";
            // 
            // lbl_socio
            // 
            lbl_socio.Anchor = AnchorStyles.None;
            lbl_socio.AutoSize = true;
            lbl_socio.BackColor = Color.Transparent;
            lbl_socio.Font = new Font("Century Gothic", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_socio.ForeColor = SystemColors.Control;
            lbl_socio.Location = new Point(331, 388);
            lbl_socio.Name = "lbl_socio";
            lbl_socio.Size = new Size(400, 51);
            lbl_socio.TabIndex = 18;
            lbl_socio.Text = "SOCIO/NO SOCIO";
            // 
            // lbl_ultimopago
            // 
            lbl_ultimopago.Anchor = AnchorStyles.None;
            lbl_ultimopago.AutoSize = true;
            lbl_ultimopago.BackColor = Color.Transparent;
            lbl_ultimopago.Font = new Font("Century Gothic", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ultimopago.ForeColor = SystemColors.Control;
            lbl_ultimopago.Location = new Point(391, 459);
            lbl_ultimopago.Name = "lbl_ultimopago";
            lbl_ultimopago.Size = new Size(297, 51);
            lbl_ultimopago.TabIndex = 19;
            lbl_ultimopago.Text = "FECHA PAGO";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = SystemColors.ControlLightLight;
            radioButton1.Location = new Point(3, 16);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(132, 44);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "1 MES";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.ForeColor = SystemColors.ControlLightLight;
            radioButton2.Location = new Point(3, 57);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(167, 44);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "3 MESES";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.ForeColor = SystemColors.ControlLightLight;
            radioButton3.Location = new Point(3, 97);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(167, 44);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "6 MESES";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(radioButton_Act);
            panel2.Controls.Add(radioButton3);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(radioButton2);
            panel2.Location = new Point(58, 515);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 141);
            panel2.TabIndex = 21;
            // 
            // radioButton_Act
            // 
            radioButton_Act.AutoSize = true;
            radioButton_Act.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton_Act.ForeColor = SystemColors.ControlLightLight;
            radioButton_Act.Location = new Point(5, 99);
            radioButton_Act.Name = "radioButton_Act";
            radioButton_Act.Size = new Size(292, 44);
            radioButton_Act.TabIndex = 3;
            radioButton_Act.TabStop = true;
            radioButton_Act.Text = "UNA ACTIVIDAD";
            radioButton_Act.UseVisualStyleBackColor = true;
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel2);
            Controls.Add(lbl_ultimopago);
            Controls.Add(lbl_socio);
            Controls.Add(lbl_dni);
            Controls.Add(lbl_nombre);
            Controls.Add(btn_pago);
            Controls.Add(lbl_pago);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "UserView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Supernova";
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
        private PictureBox pictureBox1;
        private Label label_welcome;
        private Label lbl_usuario;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbl_pago;
        private Button btn_pago;
        private Label lbl_nombre;
        private Label lbl_dni;
        private Label lbl_socio;
        private Label lbl_ultimopago;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Panel panel2;
        private RadioButton radioButton_Act;
    }
}