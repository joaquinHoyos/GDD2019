﻿namespace FrbaOfertas.Forms
{
    partial class AbmOfertas
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
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Busqueda = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiltroPrecio = new System.Windows.Forms.TextBox();
            this.txtFiltrarDescripcion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Enabled = false;
            this.btn_Eliminar.Location = new System.Drawing.Point(336, 38);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(95, 27);
            this.btn_Eliminar.TabIndex = 35;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(287, 115);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(95, 23);
            this.btn_Buscar.TabIndex = 34;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Enabled = false;
            this.btn_Editar.Location = new System.Drawing.Point(226, 38);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(95, 27);
            this.btn_Editar.TabIndex = 33;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Enabled = false;
            this.btn_Guardar.Location = new System.Drawing.Point(560, 333);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(95, 23);
            this.btn_Guardar.TabIndex = 32;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // btn_Busqueda
            // 
            this.btn_Busqueda.Location = new System.Drawing.Point(125, 38);
            this.btn_Busqueda.Name = "btn_Busqueda";
            this.btn_Busqueda.Size = new System.Drawing.Size(95, 27);
            this.btn_Busqueda.TabIndex = 31;
            this.btn_Busqueda.Text = "Busqueda";
            this.btn_Busqueda.UseVisualStyleBackColor = true;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(24, 38);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(95, 27);
            this.btn_Nuevo.TabIndex = 30;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Fecha tope";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(141, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Descripcion";
            // 
            // txtFiltroPrecio
            // 
            this.txtFiltroPrecio.Location = new System.Drawing.Point(34, 115);
            this.txtFiltroPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFiltroPrecio.Name = "txtFiltroPrecio";
            this.txtFiltroPrecio.Size = new System.Drawing.Size(68, 20);
            this.txtFiltroPrecio.TabIndex = 39;
            // 
            // txtFiltrarDescripcion
            // 
            this.txtFiltrarDescripcion.Location = new System.Drawing.Point(118, 115);
            this.txtFiltrarDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFiltrarDescripcion.Name = "txtFiltrarDescripcion";
            this.txtFiltrarDescripcion.Size = new System.Drawing.Size(123, 20);
            this.txtFiltrarDescripcion.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(407, 285);
            this.dataGridView1.TabIndex = 41;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(618, 147);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(89, 20);
            this.textBox3.TabIndex = 43;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(503, 147);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 20);
            this.textBox4.TabIndex = 42;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(618, 193);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(89, 20);
            this.textBox5.TabIndex = 45;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(503, 193);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(76, 20);
            this.textBox6.TabIndex = 44;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(618, 236);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(89, 20);
            this.textBox7.TabIndex = 47;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(503, 236);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(76, 20);
            this.textBox8.TabIndex = 46;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(618, 285);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(89, 20);
            this.textBox9.TabIndex = 49;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(503, 285);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(76, 20);
            this.textBox10.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(629, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(629, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Fecha Vencimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Fecha Inicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(629, 221);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Fecha de Lista";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(500, 221);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Precio de Oferta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(608, 270);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Maxima cantidad disponible";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(494, 270);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Cantidad disponible";
            // 
            // AbmOfertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 525);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtFiltrarDescripcion);
            this.Controls.Add(this.txtFiltroPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Busqueda);
            this.Controls.Add(this.btn_Nuevo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AbmOfertas";
            this.Text = "AbmOfertas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Busqueda;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiltroPrecio;
        private System.Windows.Forms.TextBox txtFiltrarDescripcion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}