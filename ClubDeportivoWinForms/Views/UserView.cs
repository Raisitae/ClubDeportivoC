using ClubDeportivoWinForms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivoWinForms
{
    public partial class UserView : GradientBackgroundCustom
    {
        public UserView(int idPersona, int rol)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            button1.FlatAppearance.BorderSize = 0;
            btn_pago.FlatAppearance.BorderSize = 0;
            
            IdPersona = idPersona; // Set the received IdPersona value
            Rol = rol;
            fetchCarnet();
            renderPayment();

            if (rol == 121)
            {
                radioButton_Act.Visible = false;
            }
            else if (rol == 122)
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
            }

        }

        // Private field to store the idPersona value
        private int _idPersona;

        // Public property to access _idPersona
        public int IdPersona
        {
            get { return _idPersona; }
            set { _idPersona = value; }
        }

        private int _rol;
        public int Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }


        private int intervalo;
        public int Intervalo { get => intervalo; set => intervalo = value; }

        private DateTime fecha_vencimiento;
        public DateTime Fecha_vencimiento { get => fecha_vencimiento; set => fecha_vencimiento = value; }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void renderPayment()
        {

            DateTime currentDateTime = DateTime.Now;

            if (Fecha_vencimiento > currentDateTime)
            {
                btn_pago.Visible = false;
                panel2.Visible = false;
            }
            else
            {
                btn_pago.Visible = true;
                panel2.Visible = true;

            }
        }
        private void fetchCarnet()
        {
            DateTime currentDateTime = DateTime.Now;
            DataTable fetchUser = new DataTable();
            Data.Personas dato = new Data.Personas();


            fetchUser = dato.bringCarnet(_idPersona);

            lbl_usuario.Text = fetchUser.Rows[0][0].ToString()?.ToUpper();
            lbl_nombre.Text = fetchUser.Rows[0][0].ToString()?.ToUpper();
            lbl_dni.Text = fetchUser.Rows[0][2].ToString()?.ToUpper();

            // Update the class-level Fecha_vencimiento directly without re-declaration
            if (!String.IsNullOrEmpty(fetchUser.Rows[0][4].ToString()))
            {
                Fecha_vencimiento = DateTime.Parse(fetchUser.Rows[0][4].ToString());
            }
            else
            {
                Fecha_vencimiento = DateTime.MinValue;
            }

            DataTable fechaUtimoPago = new DataTable();
            Data.Cuotas dato1 = new Data.Cuotas();
            fechaUtimoPago = dato1.FetchUltimoPago(_idPersona);

            DateTime parseFechaUltimoPago;


            if (fechaUtimoPago.Rows.Count > 0)
            {
                if (DateTime.TryParse(fechaUtimoPago.Rows[0][0].ToString(), out parseFechaUltimoPago))
                {
                    DateTime.Parse(fechaUtimoPago.Rows[0][0].ToString());
                }
                else
                {

                    parseFechaUltimoPago = DateTime.MinValue;
                }
            }
            else
            {
                parseFechaUltimoPago = DateTime.MinValue;
            }

            bool socio = (bool)fetchUser.Rows[0][3];


            switch (socio)
            {
                case true:

                    if (Fecha_vencimiento.Date < currentDateTime.Date)
                    {
                        lbl_socio.Text = "SOCIO. PAGO VENCIDO";
                    }
                    else
                    {
                        lbl_socio.Text = "SOCIO";
                    }
                    break;

                case false:
                    if (Fecha_vencimiento.Date < currentDateTime.Date)
                    {
                        lbl_socio.Text = "NO SOCIO. NO HAY ACTIVIDAD PAGADA";
                    }
                    else
                    {
                        lbl_socio.Text = "NO SOCIO";
                    }
                    break;
            }

            if (!string.IsNullOrEmpty(fetchUser.Rows[0][4].ToString()))
            {
                //this could be in cuota

                lbl_ultimopago.Text = parseFechaUltimoPago.ToString();
            }
            else
            {
                lbl_ultimopago.Text = "NINGÚN PAGO REGISTRADO";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Intervalo = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Intervalo = 3;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Intervalo = 6;
        }

        private void btn_pago_Click(object sender, EventArgs e)
        {
            Administrador admin = Administrador.GetInstance();
            DateTime currentDateTime = DateTime.Now;

            if (Rol == 121)
            {
                admin.crearCouta(1000, intervalo, IdPersona);
                fetchCarnet();
                renderPayment();
                this.Refresh();
            }
            else if (Rol == 122)
            {
                admin.crearActividad(100, IdPersona);
                fetchCarnet();
                renderPayment();
                this.Refresh();
            }
        }

    }
}
