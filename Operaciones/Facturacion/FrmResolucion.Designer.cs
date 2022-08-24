
namespace Operaciones.Facturacion
{
    partial class FrmResolucion
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.CboEstacionamiento = new System.Windows.Forms.ComboBox();
            this.DtmResolucion = new System.Windows.Forms.DateTimePicker();
            this.DtmFinResolucion = new System.Windows.Forms.DateTimePicker();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.PanelResolucion = new System.Windows.Forms.Panel();
            this.TxtResolucion = new System.Windows.Forms.TextBox();
            this.TxtFacActual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFacFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFacInicial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPrefijo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtModulo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtFacturacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.PanelResolucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Location = new System.Drawing.Point(39, 538);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.Size = new System.Drawing.Size(861, 150);
            this.DgvListado.TabIndex = 27;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(174)))), ((int)(((byte)(68)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(679, 450);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(120, 34);
            this.BtnBuscar.TabIndex = 25;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(156, 458);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 26);
            this.label10.TabIndex = 26;
            this.label10.Text = "Sede";
            // 
            // CboEstacionamiento
            // 
            this.CboEstacionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEstacionamiento.FormattingEnabled = true;
            this.CboEstacionamiento.Location = new System.Drawing.Point(283, 456);
            this.CboEstacionamiento.Name = "CboEstacionamiento";
            this.CboEstacionamiento.Size = new System.Drawing.Size(309, 28);
            this.CboEstacionamiento.TabIndex = 24;
            // 
            // DtmResolucion
            // 
            this.DtmResolucion.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmResolucion.CustomFormat = "dd-MM-yyyy";
            this.DtmResolucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtmResolucion.Location = new System.Drawing.Point(441, 120);
            this.DtmResolucion.Name = "DtmResolucion";
            this.DtmResolucion.Size = new System.Drawing.Size(90, 20);
            this.DtmResolucion.TabIndex = 23;
            this.DtmResolucion.Value = new System.DateTime(2021, 11, 25, 0, 0, 0, 0);
            // 
            // DtmFinResolucion
            // 
            this.DtmFinResolucion.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmFinResolucion.CustomFormat = "dd-MM-yyyy";
            this.DtmFinResolucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtmFinResolucion.Location = new System.Drawing.Point(441, 176);
            this.DtmFinResolucion.Name = "DtmFinResolucion";
            this.DtmFinResolucion.Size = new System.Drawing.Size(90, 20);
            this.DtmFinResolucion.TabIndex = 22;
            this.DtmFinResolucion.Value = new System.DateTime(2021, 11, 25, 0, 0, 0, 0);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(499, 255);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(122, 34);
            this.BtnCancelar.TabIndex = 20;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(174)))), ((int)(((byte)(68)))));
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(320, 255);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(120, 34);
            this.BtnActualizar.TabIndex = 19;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            // 
            // PanelResolucion
            // 
            this.PanelResolucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelResolucion.Controls.Add(this.DtmResolucion);
            this.PanelResolucion.Controls.Add(this.DtmFinResolucion);
            this.PanelResolucion.Controls.Add(this.BtnCancelar);
            this.PanelResolucion.Controls.Add(this.BtnActualizar);
            this.PanelResolucion.Controls.Add(this.TxtResolucion);
            this.PanelResolucion.Controls.Add(this.TxtFacActual);
            this.PanelResolucion.Controls.Add(this.label1);
            this.PanelResolucion.Controls.Add(this.TxtFacFinal);
            this.PanelResolucion.Controls.Add(this.label2);
            this.PanelResolucion.Controls.Add(this.TxtFacInicial);
            this.PanelResolucion.Controls.Add(this.label3);
            this.PanelResolucion.Controls.Add(this.label4);
            this.PanelResolucion.Controls.Add(this.label5);
            this.PanelResolucion.Controls.Add(this.label6);
            this.PanelResolucion.Controls.Add(this.TxtPrefijo);
            this.PanelResolucion.Controls.Add(this.label7);
            this.PanelResolucion.Controls.Add(this.TxtModulo);
            this.PanelResolucion.Controls.Add(this.label8);
            this.PanelResolucion.Controls.Add(this.TxtFacturacion);
            this.PanelResolucion.Controls.Add(this.label9);
            this.PanelResolucion.Location = new System.Drawing.Point(20, 105);
            this.PanelResolucion.Name = "PanelResolucion";
            this.PanelResolucion.Size = new System.Drawing.Size(891, 310);
            this.PanelResolucion.TabIndex = 23;
            // 
            // TxtResolucion
            // 
            this.TxtResolucion.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResolucion.Location = new System.Drawing.Point(387, 49);
            this.TxtResolucion.Name = "TxtResolucion";
            this.TxtResolucion.Size = new System.Drawing.Size(184, 27);
            this.TxtResolucion.TabIndex = 13;
            // 
            // TxtFacActual
            // 
            this.TxtFacActual.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFacActual.Location = new System.Drawing.Point(722, 175);
            this.TxtFacActual.Name = "TxtFacActual";
            this.TxtFacActual.Size = new System.Drawing.Size(150, 27);
            this.TxtFacActual.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Facturación";
            // 
            // TxtFacFinal
            // 
            this.TxtFacFinal.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFacFinal.Location = new System.Drawing.Point(722, 115);
            this.TxtFacFinal.Name = "TxtFacFinal";
            this.TxtFacFinal.Size = new System.Drawing.Size(150, 27);
            this.TxtFacFinal.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modulo";
            // 
            // TxtFacInicial
            // 
            this.TxtFacInicial.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFacInicial.Location = new System.Drawing.Point(722, 48);
            this.TxtFacInicial.Name = "TxtFacInicial";
            this.TxtFacInicial.Size = new System.Drawing.Size(150, 27);
            this.TxtFacInicial.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prefijo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Resolución";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha Resolución";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha Final Resolución";
            // 
            // TxtPrefijo
            // 
            this.TxtPrefijo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrefijo.Location = new System.Drawing.Point(123, 173);
            this.TxtPrefijo.Name = "TxtPrefijo";
            this.TxtPrefijo.Size = new System.Drawing.Size(111, 27);
            this.TxtPrefijo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(586, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Factura Inicial ";
            // 
            // TxtModulo
            // 
            this.TxtModulo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtModulo.Location = new System.Drawing.Point(123, 113);
            this.TxtModulo.Name = "TxtModulo";
            this.TxtModulo.Size = new System.Drawing.Size(111, 27);
            this.TxtModulo.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(586, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Factura Final ";
            // 
            // TxtFacturacion
            // 
            this.TxtFacturacion.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFacturacion.Location = new System.Drawing.Point(123, 46);
            this.TxtFacturacion.Name = "TxtFacturacion";
            this.TxtFacturacion.Size = new System.Drawing.Size(111, 27);
            this.TxtFacturacion.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(586, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "Factura Actual ";
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // FrmResolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 793);
            this.Controls.Add(this.DgvListado);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CboEstacionamiento);
            this.Controls.Add(this.PanelResolucion);
            this.Name = "FrmResolucion";
            this.Text = "FrmResolucion";
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.PanelResolucion.ResumeLayout(false);
            this.PanelResolucion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CboEstacionamiento;
        private System.Windows.Forms.DateTimePicker DtmResolucion;
        private System.Windows.Forms.DateTimePicker DtmFinResolucion;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Panel PanelResolucion;
        private System.Windows.Forms.TextBox TxtResolucion;
        private System.Windows.Forms.TextBox TxtFacActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFacFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFacInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPrefijo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtModulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtFacturacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
    }
}