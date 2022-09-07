namespace Operaciones.Reportes
{
    partial class FrmSaldoEnLinea
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.DataSaldo = new Operaciones.Reportes.DataSaldo();
            this.P_DetalleSaldosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.P_DetalleSaldosTableAdapter = new Operaciones.Reportes.DataSaldoTableAdapters.P_DetalleSaldosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_DetalleSaldosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.P_DetalleSaldosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Operaciones.Reportes.ReportSaldoEnLinea.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 76);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(680, 672);
            this.reportViewer1.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(159, 52);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(64, 24);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(175, 9);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(117, 39);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "HORA";
            // 
            // DataSaldo
            // 
            this.DataSaldo.DataSetName = "DataSaldo";
            this.DataSaldo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // P_DetalleSaldosBindingSource
            // 
            this.P_DetalleSaldosBindingSource.DataMember = "P_DetalleSaldos";
            this.P_DetalleSaldosBindingSource.DataSource = this.DataSaldo;
            // 
            // P_DetalleSaldosTableAdapter
            // 
            this.P_DetalleSaldosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmSaldoEnLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 759);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmSaldoEnLinea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSaldoEnLinea";
            this.Load += new System.EventHandler(this.FrmSaldoEnLinea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_DetalleSaldosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.BindingSource P_DetalleSaldosBindingSource;
        private DataSaldo DataSaldo;
        private DataSaldoTableAdapters.P_DetalleSaldosTableAdapter P_DetalleSaldosTableAdapter;
    }
}