namespace FrbaOfertas.Forms
{
    partial class ListadoEstadisitico
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_descuentos = new System.Windows.Forms.Button();
            this.nud_anioDescuentos = new System.Windows.Forms.NumericUpDown();
            this.combo_descuentos = new System.Windows.Forms.ComboBox();
            this.grid_descuentos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.nud_anioVentas = new System.Windows.Forms.NumericUpDown();
            this.grid_ventas = new System.Windows.Forms.DataGridView();
            this.combo_ventas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_anioDescuentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_descuentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_anioVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btn_descuentos);
            this.splitContainer1.Panel1.Controls.Add(this.nud_anioDescuentos);
            this.splitContainer1.Panel1.Controls.Add(this.combo_descuentos);
            this.splitContainer1.Panel1.Controls.Add(this.grid_descuentos);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.btn_ventas);
            this.splitContainer1.Panel2.Controls.Add(this.nud_anioVentas);
            this.splitContainer1.Panel2.Controls.Add(this.grid_ventas);
            this.splitContainer1.Panel2.Controls.Add(this.combo_ventas);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1148, 417);
            this.splitContainer1.SplitterDistance = 577;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_descuentos
            // 
            this.btn_descuentos.Location = new System.Drawing.Point(439, 86);
            this.btn_descuentos.Name = "btn_descuentos";
            this.btn_descuentos.Size = new System.Drawing.Size(120, 23);
            this.btn_descuentos.TabIndex = 5;
            this.btn_descuentos.Text = "Generar";
            this.btn_descuentos.UseVisualStyleBackColor = true;
            this.btn_descuentos.Click += new System.EventHandler(this.btn_descuentos_Click);
            // 
            // nud_anioDescuentos
            // 
            this.nud_anioDescuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_anioDescuentos.Location = new System.Drawing.Point(234, 86);
            this.nud_anioDescuentos.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nud_anioDescuentos.Name = "nud_anioDescuentos";
            this.nud_anioDescuentos.Size = new System.Drawing.Size(120, 23);
            this.nud_anioDescuentos.TabIndex = 3;
            // 
            // combo_descuentos
            // 
            this.combo_descuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_descuentos.FormattingEnabled = true;
            this.combo_descuentos.Items.AddRange(new object[] {
            "1",
            "2"});
            this.combo_descuentos.Location = new System.Drawing.Point(10, 87);
            this.combo_descuentos.Name = "combo_descuentos";
            this.combo_descuentos.Size = new System.Drawing.Size(121, 24);
            this.combo_descuentos.TabIndex = 4;
            // 
            // grid_descuentos
            // 
            this.grid_descuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_descuentos.Location = new System.Drawing.Point(10, 161);
            this.grid_descuentos.Name = "grid_descuentos";
            this.grid_descuentos.Size = new System.Drawing.Size(549, 249);
            this.grid_descuentos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estadistica Descuentos";
            // 
            // btn_ventas
            // 
            this.btn_ventas.Location = new System.Drawing.Point(433, 86);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(120, 23);
            this.btn_ventas.TabIndex = 8;
            this.btn_ventas.Text = "Generar";
            this.btn_ventas.UseVisualStyleBackColor = true;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // nud_anioVentas
            // 
            this.nud_anioVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_anioVentas.Location = new System.Drawing.Point(237, 87);
            this.nud_anioVentas.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nud_anioVentas.Name = "nud_anioVentas";
            this.nud_anioVentas.Size = new System.Drawing.Size(120, 23);
            this.nud_anioVentas.TabIndex = 6;
            // 
            // grid_ventas
            // 
            this.grid_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ventas.Location = new System.Drawing.Point(15, 161);
            this.grid_ventas.Name = "grid_ventas";
            this.grid_ventas.Size = new System.Drawing.Size(549, 249);
            this.grid_ventas.TabIndex = 2;
            // 
            // combo_ventas
            // 
            this.combo_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_ventas.FormattingEnabled = true;
            this.combo_ventas.Items.AddRange(new object[] {
            "1",
            "2"});
            this.combo_ventas.Location = new System.Drawing.Point(15, 86);
            this.combo_ventas.Name = "combo_ventas";
            this.combo_ventas.Size = new System.Drawing.Size(121, 24);
            this.combo_ventas.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estadistica Ventas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Semestre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Año";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Año";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Semestre";
            // 
            // ListadoEstadisitico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 417);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ListadoEstadisitico";
            this.Text = "ListadoEstadisitico";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_anioDescuentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_descuentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_anioVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_descuentos;
        private System.Windows.Forms.NumericUpDown nud_anioDescuentos;
        private System.Windows.Forms.ComboBox combo_descuentos;
        private System.Windows.Forms.DataGridView grid_descuentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.NumericUpDown nud_anioVentas;
        private System.Windows.Forms.DataGridView grid_ventas;
        private System.Windows.Forms.ComboBox combo_ventas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}