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
            label1 = new Label();
            label_welcome = new Label();
            panel1 = new Panel();
            textBox_Nombre = new TextBox();
            textBox_DNI = new TextBox();
            registrar = new Button();
            label2 = new Label();
            panel2 = new Panel();
            textBox_Telefono = new TextBox();
            SocioRadial = new RadioButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.MediumAquamarine;
            label1.Font = new Font("Lucida Sans Unicode", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(23, 211);
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
            label_welcome.Location = new Point(23, 165);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(359, 42);
            label_welcome.TabIndex = 0;
            label_welcome.Text = "Bienvenido al acceso";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumAquamarine;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label_welcome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 450);
            panel1.TabIndex = 7;
            // 
            // textBox_Nombre
            // 
            textBox_Nombre.Anchor = AnchorStyles.None;
            textBox_Nombre.BackColor = Color.FromArgb(224, 224, 224);
            textBox_Nombre.BorderStyle = BorderStyle.None;
            textBox_Nombre.Font = new Font("Lucida Sans Unicode", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Nombre.ForeColor = SystemColors.ControlDarkDark;
            textBox_Nombre.Location = new Point(424, 22);
            textBox_Nombre.Name = "textBox_Nombre";
            textBox_Nombre.PlaceholderText = "Nombre";
            textBox_Nombre.Size = new Size(361, 36);
            textBox_Nombre.TabIndex = 3;
            // 
            // textBox_DNI
            // 
            textBox_DNI.Anchor = AnchorStyles.None;
            textBox_DNI.BackColor = Color.FromArgb(224, 224, 224);
            textBox_DNI.BorderStyle = BorderStyle.None;
            textBox_DNI.Font = new Font("Lucida Sans Unicode", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_DNI.ForeColor = SystemColors.ControlDarkDark;
            textBox_DNI.Location = new Point(424, 64);
            textBox_DNI.Name = "textBox_DNI";
            textBox_DNI.PlaceholderText = "DNI";
            textBox_DNI.Size = new Size(361, 36);
            textBox_DNI.TabIndex = 4;
            // 
            // registrar
            // 
            registrar.Anchor = AnchorStyles.None;
            registrar.BackColor = Color.MediumAquamarine;
            registrar.FlatStyle = FlatStyle.Flat;
            registrar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            registrar.ForeColor = SystemColors.ButtonHighlight;
            registrar.Location = new Point(526, 364);
            registrar.Name = "registrar";
            registrar.Size = new Size(170, 55);
            registrar.TabIndex = 10;
            registrar.Text = "Registrar";
            registrar.UseVisualStyleBackColor = false;
            registrar.Click += registrar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(526, 91);
            label2.Name = "label2";
            label2.Size = new Size(156, 34);
            label2.TabIndex = 8;
            label2.Text = "Registrate!";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(SocioRadial);
            panel2.Controls.Add(textBox_Telefono);
            panel2.Controls.Add(textBox_Nombre);
            panel2.Controls.Add(textBox_DNI);
            panel2.Location = new Point(3, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(797, 202);
            panel2.TabIndex = 9;
            // 
            // textBox_Telefono
            // 
            textBox_Telefono.Anchor = AnchorStyles.None;
            textBox_Telefono.BackColor = Color.FromArgb(224, 224, 224);
            textBox_Telefono.BorderStyle = BorderStyle.None;
            textBox_Telefono.Font = new Font("Lucida Sans Unicode", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Telefono.ForeColor = SystemColors.ControlDarkDark;
            textBox_Telefono.Location = new Point(424, 106);
            textBox_Telefono.Name = "textBox_Telefono";
            textBox_Telefono.PlaceholderText = "Teléfono";
            textBox_Telefono.Size = new Size(361, 36);
            textBox_Telefono.TabIndex = 5;
            // 
            // SocioRadial
            // 
            SocioRadial.AutoSize = true;
            SocioRadial.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SocioRadial.ForeColor = SystemColors.ControlDarkDark;
            SocioRadial.Location = new Point(424, 148);
            SocioRadial.Name = "SocioRadial";
            SocioRadial.Size = new Size(187, 27);
            SocioRadial.TabIndex = 11;
            SocioRadial.TabStop = true;
            SocioRadial.Text = "Quiero ser socio";
            SocioRadial.UseVisualStyleBackColor = true;
            // 
            // RegisterView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(registrar);
            Controls.Add(label2);
            Controls.Add(panel2);
            Name = "RegisterView";
            Text = "RegisterView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_welcome;
        private Panel panel1;
        private TextBox textBox_Nombre;
        private TextBox textBox_DNI;
        private Button registrar;
        private Label label2;
        private Panel panel2;
        private TextBox textBox_Telefono;
        private RadioButton SocioRadial;
    }
}