namespace FrbaOfertas.Forms
{
    partial class Admin_Form
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Usuarios = new System.Windows.Forms.Button();
            this.btn_Roles = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Usuarios, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Roles, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(628, 39);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.BackColor = System.Drawing.Color.Silver;
            this.btn_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Usuarios.Location = new System.Drawing.Point(317, 3);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Size = new System.Drawing.Size(308, 33);
            this.btn_Usuarios.TabIndex = 2;
            this.btn_Usuarios.Text = "Usuarios";
            this.btn_Usuarios.UseVisualStyleBackColor = false;
            // 
            // btn_Roles
            // 
            this.btn_Roles.BackColor = System.Drawing.Color.Silver;
            this.btn_Roles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Roles.Location = new System.Drawing.Point(3, 3);
            this.btn_Roles.Name = "btn_Roles";
            this.btn_Roles.Size = new System.Drawing.Size(308, 33);
            this.btn_Roles.TabIndex = 1;
            this.btn_Roles.Text = "Roles";
            this.btn_Roles.UseVisualStyleBackColor = false;
            this.btn_Roles.Click += new System.EventHandler(this.btn_Roles_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 391);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Admin_Form";
            this.Text = "Admin_Form";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Roles;
        private System.Windows.Forms.Button btn_Usuarios;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}