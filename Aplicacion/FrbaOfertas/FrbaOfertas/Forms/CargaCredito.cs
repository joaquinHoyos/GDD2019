using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Repositorios;

namespace FrbaOfertas.Forms
{
    public partial class CargaCredito : Form
    {

        public int currentUserID;
        public CargaCredito()
        {
            InitializeComponent();
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void CargaCredito_Load(object sender, EventArgs e)
        {

        }

        private void btn_altaCredito_Click(object sender, EventArgs e)
        {
            if (txt_monto.Text != "" && cmb_TipoPago.Text != "")
            {

                long monto;
                String tarjeta = txt_tarjeta.Text;
                bool montoEsNumerico;
                montoEsNumerico = long.TryParse(txt_monto.Text, out monto);
                string tipoPago = "";
                if (montoEsNumerico)
                {


                    switch (cmb_TipoPago.Text)
                    {
                        case "Efectivo":
                            tipoPago = "E";
                            tarjeta= "0";
                            break;
                        case "Credito":
                            tipoPago = "C";
                            break;
                        case "Debito":
                            tipoPago = "D";
                            break;
                    }

                    RepoCliente.instance().cargarCredito(tipoPago, long.Parse(tarjeta), monto, currentUserID);

                  
                    

                }
                else {


                    MessageBox.Show("Los campos monto y/o tarjeta no son validos");
                }


            }
            else {
                MessageBox.Show("Todos los campos deben tener informacion");
            }
        }

        private void cmb_TipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch(cmb_TipoPago.Text){
                case "Efectivo":
                    txt_tarjeta.Enabled = false;
                    txt_tarjeta.Text = "";
                break;
                default:
                    txt_tarjeta.Enabled = true;
                break;
            }
        }
    }
}
