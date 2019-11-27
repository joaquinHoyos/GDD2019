namespace FrbaOfertas.Forms
{
    partial class ABMCliente
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
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btn_Busqueda = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAsignarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(23, 149);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(169, 20);
            this.txtApellido.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(23, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Enabled = false;
            this.btnSeleccionar.Location = new System.Drawing.Point(434, 26);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(95, 23);
            this.btnSeleccionar.TabIndex = 34;
            this.btnSeleccionar.TabStop = false;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btn_Seleccionar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Enabled = false;
            this.btn_Editar.Location = new System.Drawing.Point(232, 26);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(95, 23);
            this.btn_Editar.TabIndex = 33;
            this.btn_Editar.TabStop = false;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(137, 315);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(177, 23);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Busqueda
            // 
            this.btn_Busqueda.Location = new System.Drawing.Point(131, 26);
            this.btn_Busqueda.Name = "btn_Busqueda";
            this.btn_Busqueda.Size = new System.Drawing.Size(95, 23);
            this.btn_Busqueda.TabIndex = 31;
            this.btn_Busqueda.Text = "Busqueda";
            this.btn_Busqueda.UseVisualStyleBackColor = true;
            this.btn_Busqueda.Click += new System.EventHandler(this.btn_Busqueda_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(23, 26);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(95, 23);
            this.btn_Nuevo.TabIndex = 30;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(558, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(589, 328);
            this.dataGridView1.TabIndex = 35;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(137, 286);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(177, 23);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Enabled = false;
            this.btnDeshabilitar.Location = new System.Drawing.Point(333, 26);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(95, 23);
            this.btnDeshabilitar.TabIndex = 37;
            this.btnDeshabilitar.TabStop = false;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Dni";
            // 
            // txtMail
            // 
            this.txtMail.Enabled = false;
            this.txtMail.Location = new System.Drawing.Point(198, 100);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(169, 20);
            this.txtMail.TabIndex = 39;
            // 
            // txtDni
            // 
            this.txtDni.Enabled = false;
            this.txtDni.Location = new System.Drawing.Point(198, 152);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(169, 20);
            this.txtDni.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Codigo postal";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(198, 197);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(169, 20);
            this.txtDireccion.TabIndex = 47;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Enabled = false;
            this.txtCodigoPostal.Location = new System.Drawing.Point(198, 249);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(169, 20);
            this.txtCodigoPostal.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Saldo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(23, 197);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(169, 20);
            this.txtTelefono.TabIndex = 43;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(23, 249);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(169, 20);
            this.txtSaldo.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(431, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Ciudad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(403, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "Fecha nacimiento";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Enabled = false;
            this.txtCiudad.Location = new System.Drawing.Point(373, 100);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(169, 20);
            this.txtCiudad.TabIndex = 51;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(383, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 20);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // btnAsignarUsuario
            // 
            this.btnAsignarUsuario.Location = new System.Drawing.Point(370, 305);
            this.btnAsignarUsuario.Name = "btnAsignarUsuario";
            this.btnAsignarUsuario.Size = new System.Drawing.Size(159, 33);
            this.btnAsignarUsuario.TabIndex = 55;
            this.btnAsignarUsuario.TabStop = false;
            this.btnAsignarUsuario.Text = "Asignar usuario a cliente";
            this.btnAsignarUsuario.UseVisualStyleBackColor = true;
            this.btnAsignarUsuario.Click += new System.EventHandler(this.btnAsignarUsuario_Click);
            // 
            // ABMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 361);
            this.Controls.Add(this.btnAsignarUsuario);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btn_Busqueda);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Name = "ABMCliente";
            this.Text = "Abm Clientes";
            this.Load += new System.EventHandler(this.ABMCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btn_Busqueda;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Button btnAsignarUsuario;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}