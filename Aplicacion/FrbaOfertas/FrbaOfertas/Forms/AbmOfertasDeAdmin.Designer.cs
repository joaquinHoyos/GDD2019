namespace FrbaOfertas.Forms
{
    partial class AbmOfertasDeAdmin
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
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtFechaVenc = new System.Windows.Forms.DateTimePicker();
            this.txtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaxCantUsuario = new System.Windows.Forms.TextBox();
            this.txtCantDisponible = new System.Windows.Forms.TextBox();
            this.txtPrecioLista = new System.Windows.Forms.TextBox();
            this.txtPrecioOferta = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFiltroProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Busqueda = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Enabled = false;
            this.btnHabilitar.Location = new System.Drawing.Point(355, 82);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(95, 27);
            this.btnHabilitar.TabIndex = 91;
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Enabled = false;
            this.btnSeleccionar.Location = new System.Drawing.Point(281, 119);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(85, 25);
            this.btnSeleccionar.TabIndex = 90;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtFechaVenc
            // 
            this.txtFechaVenc.Enabled = false;
            this.txtFechaVenc.Location = new System.Drawing.Point(579, 105);
            this.txtFechaVenc.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaVenc.Name = "txtFechaVenc";
            this.txtFechaVenc.Size = new System.Drawing.Size(123, 20);
            this.txtFechaVenc.TabIndex = 88;
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Enabled = false;
            this.txtFechaInicio.Location = new System.Drawing.Point(579, 76);
            this.txtFechaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(123, 20);
            this.txtFechaInicio.TabIndex = 87;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(629, 193);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 13);
            this.label10.TabIndex = 86;
            this.label10.Text = "Maxima cantidad por usuario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(629, 273);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 85;
            this.label11.Text = "Cantidad disponible";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(629, 215);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 84;
            this.label8.Text = "Precio de lista";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(629, 245);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 83;
            this.label9.Text = "Precio de Oferta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(477, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 82;
            this.label6.Text = "Fecha Vencimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(477, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 81;
            this.label7.Text = "Fecha Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(479, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "ID";
            // 
            // txtMaxCantUsuario
            // 
            this.txtMaxCantUsuario.Enabled = false;
            this.txtMaxCantUsuario.Location = new System.Drawing.Point(775, 193);
            this.txtMaxCantUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaxCantUsuario.Name = "txtMaxCantUsuario";
            this.txtMaxCantUsuario.Size = new System.Drawing.Size(53, 20);
            this.txtMaxCantUsuario.TabIndex = 78;
            // 
            // txtCantDisponible
            // 
            this.txtCantDisponible.Enabled = false;
            this.txtCantDisponible.Location = new System.Drawing.Point(775, 273);
            this.txtCantDisponible.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantDisponible.Name = "txtCantDisponible";
            this.txtCantDisponible.Size = new System.Drawing.Size(76, 20);
            this.txtCantDisponible.TabIndex = 77;
            // 
            // txtPrecioLista
            // 
            this.txtPrecioLista.Enabled = false;
            this.txtPrecioLista.Location = new System.Drawing.Point(775, 217);
            this.txtPrecioLista.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioLista.Name = "txtPrecioLista";
            this.txtPrecioLista.Size = new System.Drawing.Size(89, 20);
            this.txtPrecioLista.TabIndex = 76;
            // 
            // txtPrecioOferta
            // 
            this.txtPrecioOferta.Enabled = false;
            this.txtPrecioOferta.Location = new System.Drawing.Point(775, 245);
            this.txtPrecioOferta.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioOferta.Name = "txtPrecioOferta";
            this.txtPrecioOferta.Size = new System.Drawing.Size(76, 20);
            this.txtPrecioOferta.TabIndex = 75;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(579, 140);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(192, 20);
            this.txtDescripcion.TabIndex = 74;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(580, 43);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(122, 20);
            this.txtId.TabIndex = 73;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(583, 216);
            this.dataGridView1.TabIndex = 72;
            // 
            // txtFiltroProveedor
            // 
            this.txtFiltroProveedor.Enabled = false;
            this.txtFiltroProveedor.Location = new System.Drawing.Point(53, 121);
            this.txtFiltroProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltroProveedor.Name = "txtFiltroProveedor";
            this.txtFiltroProveedor.Size = new System.Drawing.Size(123, 20);
            this.txtFiltroProveedor.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(80, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Proveedor";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Enabled = false;
            this.btn_Eliminar.Location = new System.Drawing.Point(355, 42);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(95, 27);
            this.btn_Eliminar.TabIndex = 68;
            this.btn_Eliminar.Text = "Deshabilitar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Enabled = false;
            this.btn_Buscar.Location = new System.Drawing.Point(181, 119);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(95, 23);
            this.btn_Buscar.TabIndex = 67;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Enabled = false;
            this.btn_Editar.Location = new System.Drawing.Point(245, 42);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(95, 27);
            this.btn_Editar.TabIndex = 66;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Enabled = false;
            this.btn_Guardar.Location = new System.Drawing.Point(632, 308);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(172, 72);
            this.btn_Guardar.TabIndex = 65;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Busqueda
            // 
            this.btn_Busqueda.Location = new System.Drawing.Point(144, 42);
            this.btn_Busqueda.Name = "btn_Busqueda";
            this.btn_Busqueda.Size = new System.Drawing.Size(95, 27);
            this.btn_Busqueda.TabIndex = 64;
            this.btn_Busqueda.Text = "Busqueda";
            this.btn_Busqueda.UseVisualStyleBackColor = true;
            this.btn_Busqueda.Click += new System.EventHandler(this.btn_Busqueda_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(43, 42);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(95, 27);
            this.btn_Nuevo.TabIndex = 63;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(731, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "Proveedor";
            // 
            // cboProveedor
            // 
            this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(797, 43);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(187, 21);
            this.cboProveedor.TabIndex = 94;
            // 
            // AbmOfertasDeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 452);
            this.Controls.Add(this.cboProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.txtFechaVenc);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaxCantUsuario);
            this.Controls.Add(this.txtCantDisponible);
            this.Controls.Add(this.txtPrecioLista);
            this.Controls.Add(this.txtPrecioOferta);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtFiltroProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Busqueda);
            this.Controls.Add(this.btn_Nuevo);
            this.Name = "AbmOfertasDeAdmin";
            this.Text = "AmbOfertasDeAdmin";
            this.Load += new System.EventHandler(this.AmbOfertasDeAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DateTimePicker txtFechaVenc;
        private System.Windows.Forms.DateTimePicker txtFechaInicio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaxCantUsuario;
        private System.Windows.Forms.TextBox txtCantDisponible;
        private System.Windows.Forms.TextBox txtPrecioLista;
        private System.Windows.Forms.TextBox txtPrecioOferta;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFiltroProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Busqueda;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboProveedor;
    }
}