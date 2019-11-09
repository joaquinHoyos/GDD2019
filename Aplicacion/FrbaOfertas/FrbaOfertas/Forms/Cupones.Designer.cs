namespace FrbaOfertas.Forms
{
    partial class Cupones
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmb_Clientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Regalar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(594, 147);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmb_Clientes
            // 
            this.cmb_Clientes.Enabled = false;
            this.cmb_Clientes.FormattingEnabled = true;
            this.cmb_Clientes.Location = new System.Drawing.Point(144, 204);
            this.cmb_Clientes.Name = "cmb_Clientes";
            this.cmb_Clientes.Size = new System.Drawing.Size(121, 21);
            this.cmb_Clientes.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cliente a regalar:";
            // 
            // btn_Regalar
            // 
            this.btn_Regalar.Enabled = false;
            this.btn_Regalar.Location = new System.Drawing.Point(324, 242);
            this.btn_Regalar.Name = "btn_Regalar";
            this.btn_Regalar.Size = new System.Drawing.Size(100, 35);
            this.btn_Regalar.TabIndex = 9;
            this.btn_Regalar.Text = "Regalar";
            this.btn_Regalar.UseVisualStyleBackColor = true;
            this.btn_Regalar.Click += new System.EventHandler(this.btn_Regalar_Click);
            // 
            // Cupones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 307);
            this.Controls.Add(this.btn_Regalar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Clientes);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Cupones";
            this.Text = "Cupones";
            this.Load += new System.EventHandler(this.Cupones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_Clientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Regalar;

    }
}