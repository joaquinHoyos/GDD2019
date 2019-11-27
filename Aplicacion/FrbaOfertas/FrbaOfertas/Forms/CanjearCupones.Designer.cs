namespace FrbaOfertas.Forms
{
    partial class CanjearCupones
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
            this.btnCanjear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(825, 383);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCanjear
            // 
            this.btnCanjear.Location = new System.Drawing.Point(371, 555);
            this.btnCanjear.Name = "btnCanjear";
            this.btnCanjear.Size = new System.Drawing.Size(191, 60);
            this.btnCanjear.TabIndex = 1;
            this.btnCanjear.Text = "Canjear";
            this.btnCanjear.UseVisualStyleBackColor = true;
            this.btnCanjear.Click += new System.EventHandler(this.btnCanjear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el DNI del cliente";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(319, 51);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(231, 26);
            this.txtDni.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(612, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(166, 50);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar Cupones";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // CanjearCupones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 642);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCanjear);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CanjearCupones";
            this.Text = "CanjearCupones";
            this.Load += new System.EventHandler(this.CanjearCupones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCanjear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnBuscar;
    }
}





