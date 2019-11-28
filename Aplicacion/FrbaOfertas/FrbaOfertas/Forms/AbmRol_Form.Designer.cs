namespace FrbaOfertas.Forms
{
    partial class AbmRol_Form
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.list_Proveedor = new System.Windows.Forms.CheckedListBox();
            this.list_Cliente = new System.Windows.Forms.CheckedListBox();
            this.list_Admin = new System.Windows.Forms.CheckedListBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Busqueda = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Seleccionar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nud_id = new System.Windows.Forms.NumericUpDown();
            this.btn_Habilitar = new System.Windows.Forms.Button();
            this.btn_Deshabilitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_id)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(600, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Funciones de Proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(369, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Funciones de Cliente";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Enabled = false;
            this.label.Location = new System.Drawing.Point(173, 131);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(137, 13);
            this.label.TabIndex = 25;
            this.label.Text = "Funciones de Administrador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID";
            // 
            // list_Proveedor
            // 
            this.list_Proveedor.Enabled = false;
            this.list_Proveedor.FormattingEnabled = true;
            this.list_Proveedor.Location = new System.Drawing.Point(592, 147);
            this.list_Proveedor.Name = "list_Proveedor";
            this.list_Proveedor.Size = new System.Drawing.Size(180, 64);
            this.list_Proveedor.TabIndex = 22;
            // 
            // list_Cliente
            // 
            this.list_Cliente.Enabled = false;
            this.list_Cliente.FormattingEnabled = true;
            this.list_Cliente.Location = new System.Drawing.Point(372, 147);
            this.list_Cliente.Name = "list_Cliente";
            this.list_Cliente.Size = new System.Drawing.Size(198, 64);
            this.list_Cliente.TabIndex = 21;
            // 
            // list_Admin
            // 
            this.list_Admin.Enabled = false;
            this.list_Admin.FormattingEnabled = true;
            this.list_Admin.Location = new System.Drawing.Point(173, 147);
            this.list_Admin.Name = "list_Admin";
            this.list_Admin.Size = new System.Drawing.Size(180, 64);
            this.list_Admin.TabIndex = 20;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Enabled = false;
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(253, 83);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(183, 23);
            this.txt_Nombre.TabIndex = 19;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Enabled = false;
            this.btn_Editar.Location = new System.Drawing.Point(372, 33);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(95, 23);
            this.btn_Editar.TabIndex = 17;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Enabled = false;
            this.btn_Guardar.Location = new System.Drawing.Point(475, 32);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(95, 23);
            this.btn_Guardar.TabIndex = 16;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Busqueda
            // 
            this.btn_Busqueda.Location = new System.Drawing.Point(271, 33);
            this.btn_Busqueda.Name = "btn_Busqueda";
            this.btn_Busqueda.Size = new System.Drawing.Size(95, 23);
            this.btn_Busqueda.TabIndex = 15;
            this.btn_Busqueda.Text = "Busqueda";
            this.btn_Busqueda.UseVisualStyleBackColor = true;
            this.btn_Busqueda.Click += new System.EventHandler(this.btn_Busqueda_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(173, 33);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(95, 23);
            this.btn_Nuevo.TabIndex = 14;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(475, 84);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(95, 23);
            this.btn_Buscar.TabIndex = 28;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Visible = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.Enabled = false;
            this.btn_Seleccionar.Location = new System.Drawing.Point(576, 33);
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(95, 23);
            this.btn_Seleccionar.TabIndex = 29;
            this.btn_Seleccionar.Text = "Seleccionar";
            this.btn_Seleccionar.UseVisualStyleBackColor = true;
            this.btn_Seleccionar.Click += new System.EventHandler(this.btn_Seleccionar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(173, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(599, 108);
            this.dataGridView1.TabIndex = 30;
            // 
            // nud_id
            // 
            this.nud_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_id.Location = new System.Drawing.Point(178, 84);
            this.nud_id.Name = "nud_id";
            this.nud_id.Size = new System.Drawing.Size(52, 23);
            this.nud_id.TabIndex = 31;
            // 
            // btn_Habilitar
            // 
            this.btn_Habilitar.Location = new System.Drawing.Point(475, 84);
            this.btn_Habilitar.Name = "btn_Habilitar";
            this.btn_Habilitar.Size = new System.Drawing.Size(95, 23);
            this.btn_Habilitar.TabIndex = 32;
            this.btn_Habilitar.Text = "Habilitar";
            this.btn_Habilitar.UseVisualStyleBackColor = true;
            this.btn_Habilitar.Visible = false;
            this.btn_Habilitar.Click += new System.EventHandler(this.btn_Habilitar_Click);
            // 
            // btn_Deshabilitar
            // 
            this.btn_Deshabilitar.Location = new System.Drawing.Point(475, 84);
            this.btn_Deshabilitar.Name = "btn_Deshabilitar";
            this.btn_Deshabilitar.Size = new System.Drawing.Size(95, 23);
            this.btn_Deshabilitar.TabIndex = 33;
            this.btn_Deshabilitar.Text = "Deshabilitar";
            this.btn_Deshabilitar.UseVisualStyleBackColor = true;
            this.btn_Deshabilitar.Visible = false;
            this.btn_Deshabilitar.Click += new System.EventHandler(this.btn_Deshabilitar_Click);
            // 
            // AbmRol_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 388);
            this.Controls.Add(this.btn_Deshabilitar);
            this.Controls.Add(this.btn_Habilitar);
            this.Controls.Add(this.nud_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Seleccionar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_Proveedor);
            this.Controls.Add(this.list_Cliente);
            this.Controls.Add(this.list_Admin);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Busqueda);
            this.Controls.Add(this.btn_Nuevo);
            this.Name = "AbmRol_Form";
            this.Text = "AbmRol_Form";
            this.Load += new System.EventHandler(this.AbmRol_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckedListBox list_Proveedor;
        public System.Windows.Forms.CheckedListBox list_Cliente;
        public System.Windows.Forms.CheckedListBox list_Admin;
        public System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Busqueda;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Seleccionar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown nud_id;
        private System.Windows.Forms.Button btn_Habilitar;
        private System.Windows.Forms.Button btn_Deshabilitar;
    }
}