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
            this.txt_tipoPago = new System.Windows.Forms.TextBox();
            this.txt_tarjeta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_altaCredito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese tipo de pago";
            // 
            // txt_tipoPago
            // 
            this.txt_tipoPago.Location = new System.Drawing.Point(242, 78);
            this.txt_tipoPago.Name = "txt_tipoPago";
            this.txt_tipoPago.Size = new System.Drawing.Size(100, 20);
            this.txt_tipoPago.TabIndex = 1;
            // 
            // txt_tarjeta
            // 
            this.txt_tarjeta.Location = new System.Drawing.Point(242, 134);
            this.txt_tarjeta.Name = "txt_tarjeta";
            this.txt_tarjeta.Size = new System.Drawing.Size(100, 20);
            this.txt_tarjeta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese numero de tarjeta";
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(242, 186);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(100, 20);
            this.txt_monto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese Monto";
            // 
            // btn_altaCredito
            // 
            this.btn_altaCredito.Location = new System.Drawing.Point(242, 233);
            this.btn_altaCredito.Name = "btn_altaCredito";
            this.btn_altaCredito.Size = new System.Drawing.Size(101, 40);
            this.btn_altaCredito.TabIndex = 6;
            this.btn_altaCredito.Text = "Cargar Credito";
            this.btn_altaCredito.UseVisualStyleBackColor = true;
            // 
            // CargaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 307);
            this.Controls.Add(this.btn_altaCredito);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tarjeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tipoPago);
            this.Controls.Add(this.label1);
            this.Name = "CargaCredito";
            this.Text = "CargaCredito";
            this.Load += new System.EventHandler(this.CargaCredito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tipoPago;
        private System.Windows.Forms.TextBox txt_tarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_altaCredito;
    }
}