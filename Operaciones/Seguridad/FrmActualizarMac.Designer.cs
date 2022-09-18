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
            this.dtListadoModulos = new System.Windows.Forms.DataGridView();
            this.PnelInformacion = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdEstacionamiento = new System.Windows.Forms.TextBox();
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
            this.txtModulo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtListadoModulos)).BeginInit();
            this.PnelInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtListadoModulos
            // 
            this.dtListadoModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListadoModulos.Location = new System.Drawing.Point(157, 338);
            this.dtListadoModulos.Margin = new System.Windows.Forms.Padding(4);
            this.dtListadoModulos.Name = "dtListadoModulos";
            this.dtListadoModulos.Size = new System.Drawing.Size(1006, 176);
            this.dtListadoModulos.TabIndex = 2;
            this.dtListadoModulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListadoModulos_CellDoubleClick);
            // 
            // PnelInformacion
            // 
            this.PnelInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnelInformacion.Controls.Add(this.BtnCancelar);
            this.PnelInformacion.Controls.Add(this.BtnActualizar);
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
            this.PnelInformacion.Controls.Add(this.txtModulo);
            this.PnelInformacion.Location = new System.Drawing.Point(72, 15);
            this.PnelInformacion.Margin = new System.Windows.Forms.Padding(4);
            this.PnelInformacion.Name = "PnelInformacion";
            this.PnelInformacion.Size = new System.Drawing.Size(1233, 289);
            this.PnelInformacion.TabIndex = 17;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(1093, 241);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(134, 42);
            this.BtnCancelar.TabIndex = 23;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(174)))), ((int)(((byte)(68)))));
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(1093, 191);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(134, 42);
            this.BtnActualizar.TabIndex = 22;
            this.BtnActualizar.Text = "Guardar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // txtIp
            // 
            this.txtIp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtIp.Location = new System.Drawing.Point(873, 21);
            this.txtIp.Margin = new System.Windows.Forms.Padding(4);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(172, 30);
            this.txtIp.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(826, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ip";
            // 
            // txtIdEstacionamiento
            // 
            this.txtIdEstacionamiento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtIdEstacionamiento.Location = new System.Drawing.Point(535, 20);
            this.txtIdEstacionamiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdEstacionamiento.Name = "txtIdEstacionamiento";
            this.txtIdEstacionamiento.Size = new System.Drawing.Size(45, 30);
            this.txtIdEstacionamiento.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Modulo";
            // 
            // cboEstado
            // 
            this.cboEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(873, 163);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(200, 32);
            this.cboEstado.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id Estacionamiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(777, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado";
            // 
            // txtTipoModulo
            // 
            this.txtTipoModulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtTipoModulo.Location = new System.Drawing.Point(535, 170);
            this.txtTipoModulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoModulo.Name = "txtTipoModulo";
            this.txtTipoModulo.Size = new System.Drawing.Size(200, 30);
            this.txtTipoModulo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo Modulo";
            // 
            // txtMac
            // 
            this.txtMac.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtMac.Location = new System.Drawing.Point(537, 103);
            this.txtMac.Margin = new System.Windows.Forms.Padding(4);
            this.txtMac.Name = "txtMac";
            this.txtMac.Size = new System.Drawing.Size(198, 30);
            this.txtMac.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "MAC";
            // 
            // txtCarril
            // 
            this.txtCarril.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtCarril.Location = new System.Drawing.Point(118, 165);
            this.txtCarril.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarril.Name = "txtCarril";
            this.txtCarril.Size = new System.Drawing.Size(172, 30);
            this.txtCarril.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Carril";
            // 
            // txtModulo
            // 
            this.txtModulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtModulo.Location = new System.Drawing.Point(118, 21);
            this.txtModulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.Size = new System.Drawing.Size(172, 30);
            this.txtModulo.TabIndex = 9;
            // 
            // FrmActualizarMac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 593);
            this.Controls.Add(this.PnelInformacion);
            this.Controls.Add(this.dtListadoModulos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmActualizarMac";
            this.Text = "FrmActualizarMac";
            this.Load += new System.EventHandler(this.FrmActualizarMac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtListadoModulos)).EndInit();
            this.PnelInformacion.ResumeLayout(false);
            this.PnelInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtListadoModulos;
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
        private System.Windows.Forms.TextBox txtModulo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnActualizar;
    }
}