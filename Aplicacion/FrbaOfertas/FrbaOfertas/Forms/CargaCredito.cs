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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

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

            SqlConnection myConnection = new SqlConnection(ConfigurationManager.AppSettings["server"]);
            myConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM PASO_A_PASO.TipoPago", myConnection);
            try
            {

                List<char> tiposDisponibles = new List<char>();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        tiposDisponibles.Add(Char.Parse(reader["tipoPago_id"].ToString()));

                    }
                }
                cmb_TipoPago.Items.Clear();
                Dictionary<char, string> test = new Dictionary<char, string>();
                for (int i = 0; i < tiposDisponibles.Count; i++) {
                    if (tiposDisponibles[i] == 'E') {

                        test.Add('E',"Efectivo");
                        

                    }
                    if (tiposDisponibles[i] == 'C')
                    {
                        test.Add('C', "Credito");

                    }
                    if (tiposDisponibles[i] == 'D')
                    {
                        test.Add('D', "Debito");

                    }
                
                }

                cmb_TipoPago.DataSource = new BindingSource(test, null);
                cmb_TipoPago.DisplayMember = "Value";
                cmb_TipoPago.ValueMember = "Key";
                

            }
            catch (SqlException error) {

                MessageBox.Show(error.Message);
            }

        }

        private void btn_altaCredito_Click(object sender, EventArgs e)
        {
            if (txt_monto.Text != "" && cmb_TipoPago.Text != "")
            {

                long monto;
                long tarjetaNum;
                String tarjeta = txt_tarjeta.Text;
                bool montoEsNumerico;
                montoEsNumerico = long.TryParse(txt_monto.Text, out monto);
                bool tarjetaEsNumerica;
                tarjetaEsNumerica = long.TryParse(txt_tarjeta.Text, out tarjetaNum);
                string tipoPago = "";
                if (montoEsNumerico )
                {


                    switch (cmb_TipoPago.Text)
                    {
                        case "Efectivo":
                            tipoPago = "E";
                            tarjeta= "0";
                            break;
                        case "Credito":
                            if (tarjetaEsNumerica)
                            {
                                tipoPago = "C";
                            }
                            else {
                                MessageBox.Show("Tarjeta no numerica");
                                return;
                            }
                            break;
                        case "Debito":
                            if (tarjetaEsNumerica)
                            {
                                tipoPago = "D";
                            }

                            else
                            {
                                MessageBox.Show("Tarjeta no numerica");
                                return;
                            }
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

        private void txt_tarjeta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
