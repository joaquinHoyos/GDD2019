namespace FrbaOfertas.Forms
{
    partial class AltaProveedor
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
            this.btn_AltaProveedor = new System.Windows.Forms.Button();
            this.txt_Ciudad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_CP = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CUIT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Razon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Telefono)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AltaProveedor
            // 
            this.btn_AltaProveedor.Location = new System.Drawing.Point(370, 258);
            this.btn_AltaProveedor.Name = "btn_AltaProveedor";
            this.btn_AltaProveedor.Size = new System.Drawing.Size(117, 47);
            this.btn_AltaProveedor.TabIndex = 37;
            this.btn_AltaProveedor.Text = "Crear proveedor";
            this.btn_AltaProveedor.UseVisualStyleBackColor = true;
            this.btn_AltaProveedor.Click += new System.EventHandler(this.btn_AltaProveedor_Click);
            // 
            // txt_Ciudad
            // 
            this.txt_Ciudad.Location = new System.Drawing.Point(259, 205);
            this.txt_Ciudad.Name = "txt_Ciudad";
            this.txt_Ciudad.Size = new System.Drawing.Size(100, 20);
            this.txt_Ciudad.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Ingrese ciudad:";
            // 
            // txt_CP
            // 
            this.txt_CP.Location = new System.Drawing.Point(259, 152);
            this.txt_CP.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.txt_CP.Name = "txt_CP";
            this.txt_CP.Size = new System.Drawing.Size(120, 20);
            this.txt_CP.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ingrese codigo postal:";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(259, 97);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(100, 20);
            this.txt_Direccion.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ingrese direccion:";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(31, 152);
            this.txt_Telefono.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(120, 20);
            this.txt_Telefono.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ingrese CUIT:";
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(31, 205);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(100, 20);
            this.txt_Mail.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ingrese mail:";
            // 
            // txt_CUIT
            // 
            this.txt_CUIT.Location = new System.Drawing.Point(259, 43);
            this.txt_CUIT.Name = "txt_CUIT";
            this.txt_CUIT.Size = new System.Drawing.Size(100, 20);
            this.txt_CUIT.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ingrese telefono:";
            // 
            // txt_Razon
            // 
            this.txt_Razon.Location = new System.Drawing.Point(31, 43);
            this.txt_Razon.Name = "txt_Razon";
            this.txt_Razon.Size = new System.Drawing.Size(100, 20);
            this.txt_Razon.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ingrese nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ingrese razon social:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(31, 98);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Ingrese rubro:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 263);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 40;
            // 
            // AltaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 352);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_AltaProveedor);
            this.Controls.Add(this.txt_Ciudad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_CP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Mail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_CUIT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Razon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaProveedor";
            this.Text = "AltaProveedor";
            this.Load += new System.EventHandler(this.AltaProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_CP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Telefono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AltaProveedor;
        private System.Windows.Forms.TextBox txt_Ciudad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txt_CP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txt_Telefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CUIT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Razon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}