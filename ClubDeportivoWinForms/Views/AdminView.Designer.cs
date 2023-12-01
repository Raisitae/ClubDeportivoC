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
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            lbl_usuario = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            buttonVenc = new Button();
            buttonCerrar = new Button();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(13, 13, 13);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lbl_usuario);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1180, 209);
            panel2.TabIndex = 18;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.verification;
            pictureBox2.Location = new Point(938, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 209);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // lbl_usuario
            // 
            lbl_usuario.Anchor = AnchorStyles.None;
            lbl_usuario.AutoSize = true;
            lbl_usuario.BackColor = Color.Transparent;
            lbl_usuario.Cursor = Cursors.Hand;
            lbl_usuario.Font = new Font("Century Gothic", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_usuario.ForeColor = Color.MediumSlateBlue;
            lbl_usuario.Location = new Point(315, 109);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(358, 51);
            lbl_usuario.TabIndex = 10;
            lbl_usuario.Text = "ADMINISTRADOR";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.woman;
            pictureBox1.Location = new Point(1389, 37);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(36, 109);
            label1.Name = "label1";
            label1.Size = new Size(273, 51);
            label1.TabIndex = 0;
            label1.Text = "BIENVENIDO";
            // 
            // buttonVenc
            // 
            buttonVenc.Anchor = AnchorStyles.None;
            buttonVenc.BackColor = Color.MediumSlateBlue;
            buttonVenc.Cursor = Cursors.Hand;
            buttonVenc.FlatStyle = FlatStyle.Flat;
            buttonVenc.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVenc.ForeColor = SystemColors.Control;
            buttonVenc.Location = new Point(38, 676);
            buttonVenc.Name = "buttonVenc";
            buttonVenc.Size = new Size(421, 55);
            buttonVenc.TabIndex = 22;
            buttonVenc.Text = "TRAER VENCIMIENOS DIARIOS";
            buttonVenc.UseVisualStyleBackColor = false;
            buttonVenc.Click += buttonVenc_Click;
            // 
            // buttonCerrar
            // 
            buttonCerrar.Anchor = AnchorStyles.None;
            buttonCerrar.BackColor = Color.MediumSlateBlue;
            buttonCerrar.Cursor = Cursors.Hand;
            buttonCerrar.FlatStyle = FlatStyle.Flat;
            buttonCerrar.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCerrar.ForeColor = SystemColors.Control;
            buttonCerrar.Location = new Point(479, 676);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(277, 55);
            buttonCerrar.TabIndex = 19;
            buttonCerrar.Text = "CERRAR SESION";
            buttonCerrar.UseVisualStyleBackColor = false;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 244);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1104, 410);
            dataGridView1.TabIndex = 23;
            // 
            // AdminView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(buttonVenc);
            Controls.Add(buttonCerrar);
            Name = "AdminView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminView";
            Activated += AdminView_Activated;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Panel panel2;
        private Label lbl_usuario;
        private PictureBox pictureBox1;
        private Label label1;
        private Button buttonVenc;
        private Button buttonCerrar;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
    }
}