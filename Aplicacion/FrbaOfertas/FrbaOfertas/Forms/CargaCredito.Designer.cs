namespace FrbaOfertas.Forms
{
    partial class CargaCredito
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tarjeta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_altaCredito = new System.Windows.Forms.Button();
            this.cmb_TipoPago = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese tipo de pago";
            // 
            // txt_tarjeta
            // 
            this.txt_tarjeta.Location = new System.Drawing.Point(363, 206);
            this.txt_tarjeta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_tarjeta.Name = "txt_tarjeta";
            this.txt_tarjeta.Size = new System.Drawing.Size(148, 26);
            this.txt_tarjeta.TabIndex = 3;
            this.txt_tarjeta.TextChanged += new System.EventHandler(this.txt_tarjeta_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese numero de tarjeta";
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(363, 286);
            this.txt_monto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(148, 26);
            this.txt_monto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese Monto";
            // 
            // btn_altaCredito
            // 
            this.btn_altaCredito.Location = new System.Drawing.Point(363, 358);
            this.btn_altaCredito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_altaCredito.Name = "btn_altaCredito";
            this.btn_altaCredito.Size = new System.Drawing.Size(152, 62);
            this.btn_altaCredito.TabIndex = 6;
            this.btn_altaCredito.Text = "Cargar Credito";
            this.btn_altaCredito.UseVisualStyleBackColor = true;
            this.btn_altaCredito.Click += new System.EventHandler(this.btn_altaCredito_Click);
            // 
            // cmb_TipoPago
            // 
            this.cmb_TipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoPago.FormattingEnabled = true;
            this.cmb_TipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Credito",
            "Debito"});
            this.cmb_TipoPago.Location = new System.Drawing.Point(363, 120);
            this.cmb_TipoPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_TipoPago.Name = "cmb_TipoPago";
            this.cmb_TipoPago.Size = new System.Drawing.Size(148, 28);
            this.cmb_TipoPago.TabIndex = 7;
            this.cmb_TipoPago.SelectedIndexChanged += new System.EventHandler(this.cmb_TipoPago_SelectedIndexChanged);
            // 
            // CargaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 472);
            this.Controls.Add(this.cmb_TipoPago);
            this.Controls.Add(this.btn_altaCredito);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tarjeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CargaCredito";
            this.Text = "CargaCredito";
            this.Load += new System.EventHandler(this.CargaCredito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_altaCredito;
        private System.Windows.Forms.ComboBox cmb_TipoPago;
    }
}