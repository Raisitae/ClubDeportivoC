using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivoWinForms.Views
{
    public partial class GradientBackgroundCustom : Form
    {
        public GradientBackgroundCustom()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(1200, 800); // Set your desired size
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GradientBackgroundForm";
            this.Text = "GradientBackgroundForm";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Color color1 = Color.FromArgb(62, 8, 76);
            Color color2 = Color.FromArgb(2, 93, 147);

            using (LinearGradientBrush brush = new LinearGradientBrush(
                ClientRectangle,
                color1,
                color2,
                LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }
        }
    }
}