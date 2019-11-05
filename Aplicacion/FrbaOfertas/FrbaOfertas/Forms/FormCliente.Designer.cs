namespace FrbaOfertas.Forms
{
    partial class FormCliente
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_verCupones = new System.Windows.Forms.Button();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.btn_cargaCredito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(634, 391);
            this.splitContainer1.SplitterDistance = 42;
            this.splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btn_verCupones, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_comprar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_cargaCredito, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(628, 39);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_verCupones
            // 
            this.btn_verCupones.BackColor = System.Drawing.Color.Silver;
            this.btn_verCupones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verCupones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verCupones.Location = new System.Drawing.Point(421, 3);
            this.btn_verCupones.Name = "btn_verCupones";
            this.btn_verCupones.Size = new System.Drawing.Size(203, 33);
            this.btn_verCupones.TabIndex = 4;
            this.btn_verCupones.Text = "Ver Cupones";
            this.btn_verCupones.UseVisualStyleBackColor = false;
            this.btn_verCupones.Click += new System.EventHandler(this.btn_verCupones_Click);
            // 
            // btn_comprar
            // 
            this.btn_comprar.BackColor = System.Drawing.Color.Silver;
            this.btn_comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprar.Location = new System.Drawing.Point(212, 3);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(203, 33);
            this.btn_comprar.TabIndex = 3;
            this.btn_comprar.Text = "Comprar";
            this.btn_comprar.UseVisualStyleBackColor = false;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // btn_cargaCredito
            // 
            this.btn_cargaCredito.BackColor = System.Drawing.Color.Silver;
            this.btn_cargaCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargaCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargaCredito.Location = new System.Drawing.Point(3, 3);
            this.btn_cargaCredito.Name = "btn_cargaCredito";
            this.btn_cargaCredito.Size = new System.Drawing.Size(203, 33);
            this.btn_cargaCredito.TabIndex = 2;
            this.btn_cargaCredito.Text = "Cargar Credito";
            this.btn_cargaCredito.UseVisualStyleBackColor = false;
            this.btn_cargaCredito.Click += new System.EventHandler(this.btn_cargaCredito_Click_1);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 391);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_verCupones;
        private System.Windows.Forms.Button btn_comprar;
        private System.Windows.Forms.Button btn_cargaCredito;

    }
}