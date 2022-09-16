namespace Operaciones.Seguridad
{
    partial class FrmActualizarMac
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
            this.dtListadoBd = new System.Windows.Forms.DataGridView();
            this.PnelInformacion = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTipoModulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMac = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCarril = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdConsignacion = new System.Windows.Forms.TextBox();
            this.txtIdEstacionamiento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtListadoBd)).BeginInit();
            this.PnelInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtListadoBd
            // 
            this.dtListadoBd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListadoBd.Location = new System.Drawing.Point(219, 275);
            this.dtListadoBd.Name = "dtListadoBd";
            this.dtListadoBd.Size = new System.Drawing.Size(561, 143);
            this.dtListadoBd.TabIndex = 2;
            // 
            // PnelInformacion
            // 
            this.PnelInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnelInformacion.Controls.Add(this.txtIp);
            this.PnelInformacion.Controls.Add(this.label3);
            this.PnelInformacion.Controls.Add(this.txtIdEstacionamiento);
            this.PnelInformacion.Controls.Add(this.label1);
            this.PnelInformacion.Controls.Add(this.cboEstado);
            this.PnelInformacion.Controls.Add(this.label2);
            this.PnelInformacion.Controls.Add(this.label4);
            this.PnelInformacion.Controls.Add(this.txtTipoModulo);
            this.PnelInformacion.Controls.Add(this.label5);
            this.PnelInformacion.Controls.Add(this.txtMac);
            this.PnelInformacion.Controls.Add(this.label6);
            this.PnelInformacion.Controls.Add(this.txtCarril);
            this.PnelInformacion.Controls.Add(this.label7);
            this.PnelInformacion.Controls.Add(this.txtIdConsignacion);
            this.PnelInformacion.Location = new System.Drawing.Point(54, 12);
            this.PnelInformacion.Name = "PnelInformacion";
            this.PnelInformacion.Size = new System.Drawing.Size(925, 210);
            this.PnelInformacion.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Modulo";
            // 
            // cboEstado
            // 
            this.cboEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(655, 133);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(151, 27);
            this.cboEstado.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id Estacionamiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(573, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado";
            // 
            // txtTipoModulo
            // 
            this.txtTipoModulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtTipoModulo.Location = new System.Drawing.Point(401, 138);
            this.txtTipoModulo.Name = "txtTipoModulo";
            this.txtTipoModulo.Size = new System.Drawing.Size(151, 26);
            this.txtTipoModulo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(292, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo Modulo";
            // 
            // txtMac
            // 
            this.txtMac.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtMac.Location = new System.Drawing.Point(403, 84);
            this.txtMac.Name = "txtMac";
            this.txtMac.Size = new System.Drawing.Size(194, 26);
            this.txtMac.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(335, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "MAC";
            // 
            // txtCarril
            // 
            this.txtCarril.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtCarril.Location = new System.Drawing.Point(118, 134);
            this.txtCarril.Name = "txtCarril";
            this.txtCarril.Size = new System.Drawing.Size(130, 26);
            this.txtCarril.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Carril";
            // 
            // txtIdConsignacion
            // 
            this.txtIdConsignacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtIdConsignacion.Location = new System.Drawing.Point(118, 17);
            this.txtIdConsignacion.Name = "txtIdConsignacion";
            this.txtIdConsignacion.Size = new System.Drawing.Size(130, 26);
            this.txtIdConsignacion.TabIndex = 9;
            // 
            // txtIdEstacionamiento
            // 
            this.txtIdEstacionamiento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtIdEstacionamiento.Location = new System.Drawing.Point(450, 17);
            this.txtIdEstacionamiento.Name = "txtIdEstacionamiento";
            this.txtIdEstacionamiento.Size = new System.Drawing.Size(130, 26);
            this.txtIdEstacionamiento.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(618, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ip";
            // 
            // txtIp
            // 
            this.txtIp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtIp.Location = new System.Drawing.Point(660, 17);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(130, 26);
            this.txtIp.TabIndex = 18;
            // 
            // FrmActualizarMac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 482);
            this.Controls.Add(this.PnelInformacion);
            this.Controls.Add(this.dtListadoBd);
            this.Name = "FrmActualizarMac";
            this.Text = "FrmActualizarMac";
            ((System.ComponentModel.ISupportInitialize)(this.dtListadoBd)).EndInit();
            this.PnelInformacion.ResumeLayout(false);
            this.PnelInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtListadoBd;
        private System.Windows.Forms.Panel PnelInformacion;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdEstacionamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTipoModulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCarril;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdConsignacion;
    }
}