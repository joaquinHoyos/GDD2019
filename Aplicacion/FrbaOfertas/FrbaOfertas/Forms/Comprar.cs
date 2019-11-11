﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Server;
using FrbaOfertas.Modelo;
using FrbaOfertas.Repositorios;

namespace FrbaOfertas.Forms
{
    public partial class Comprar : Form
    {

        public int currentUserID;
        public int saldo;
        public Comprar()
        {
            InitializeComponent();
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void Comprar_Load(object sender, EventArgs e)
        {
            
            this.dataGridView1.SelectionMode =
    DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            var bindingList = new BindingList<Oferta>(RepoOferta.instance().traerOfertasDisponibles());
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            saldo = RepoCliente.instance().traerSaldo(currentUserID);
          /*  listBox1.DisplayMember = "ofer_descripcion";
            listBox1.ValueMember = "ofer_id";
            */

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_comprar.Enabled = true;
            txt_cantidad.Enabled = true;
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {


            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            int stock = Convert.ToInt32(selectedRow.Cells["ofer_disponible"].Value);
            int maximoPorCliente = Convert.ToInt32(selectedRow.Cells["ofer_maxDisponible"].Value);
            if (txt_cantidad.Value > 0)
            {
                if (txt_cantidad.Value <= maximoPorCliente &&  stock - txt_cantidad.Value >=0)
                {
                    /*
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    */
                    string a = Convert.ToString(selectedRow.Cells["ofer_id"].Value);

                    if (saldo - (Convert.ToInt32(selectedRow.Cells["ofer_precioOferta"].Value) * Convert.ToInt32(txt_cantidad.Value)) >=0)
                    {
                    RepoCliente.instance().generarCompra(currentUserID, a, Convert.ToInt32(txt_cantidad.Value));
                    
                    this.dataGridView1.SelectionMode =
                     DataGridViewSelectionMode.FullRowSelect;
                    this.dataGridView1.MultiSelect = false;
                    var bindingList = new BindingList<Oferta>(RepoOferta.instance().traerOfertasDisponibles());
                    var source = new BindingSource(bindingList, null);
                    dataGridView1.DataSource = source;

                    saldo = RepoCliente.instance().traerSaldo(currentUserID);
                    }else {
                    
                        MessageBox.Show("No hay saldo suficiente, su saldo actual es de "+ saldo.ToString() + " pesos.");
                    }
                }
                else {

                    MessageBox.Show("El stock no es suficiente o la cantidad supera al maximo por cliente");
                
                }
            }
            else {
                MessageBox.Show("La cantidad debe ser mayor a 0");
            
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_comprar.Enabled = true;
            txt_cantidad.Enabled = true;
        }
    }
}
