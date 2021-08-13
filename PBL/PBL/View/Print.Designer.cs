
namespace PBL.View
{
    partial class Print
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.func_XemChiTietHoaDon_DichVu_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.func_XemChiTietHoaDon_VatTu_Result1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.func_XemChiTietHoaDon_DichVu_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.func_XemChiTietHoaDon_VatTu_Result1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpHoaDon
            // 
            this.rpHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "HoaDonDichVu";
            reportDataSource1.Value = this.func_XemChiTietHoaDon_DichVu_ResultBindingSource;
            reportDataSource2.Name = "HoaDonVatTu";
            reportDataSource2.Value = this.func_XemChiTietHoaDon_VatTu_Result1BindingSource;
            this.rpHoaDon.LocalReport.DataSources.Add(reportDataSource1);
            this.rpHoaDon.LocalReport.DataSources.Add(reportDataSource2);
            this.rpHoaDon.LocalReport.ReportEmbeddedResource = "PBL.Report1.rdlc";
            this.rpHoaDon.Location = new System.Drawing.Point(0, 0);
            this.rpHoaDon.Name = "rpHoaDon";
            this.rpHoaDon.ServerReport.BearerToken = null;
            this.rpHoaDon.Size = new System.Drawing.Size(924, 550);
            this.rpHoaDon.TabIndex = 0;
            // 
            // func_XemChiTietHoaDon_DichVu_ResultBindingSource
            // 
            this.func_XemChiTietHoaDon_DichVu_ResultBindingSource.DataSource = typeof(PBL.DAL.func_XemChiTietHoaDon_DichVu_Result);
            // 
            // func_XemChiTietHoaDon_VatTu_Result1BindingSource
            // 
            this.func_XemChiTietHoaDon_VatTu_Result1BindingSource.DataSource = typeof(PBL.DAL.func_XemChiTietHoaDon_VatTu_Result1);
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 550);
            this.Controls.Add(this.rpHoaDon);
            this.Name = "Print";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.func_XemChiTietHoaDon_DichVu_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.func_XemChiTietHoaDon_VatTu_Result1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpHoaDon;
        private System.Windows.Forms.BindingSource func_XemChiTietHoaDon_DichVu_ResultBindingSource;
        private System.Windows.Forms.BindingSource func_XemChiTietHoaDon_VatTu_Result1BindingSource;
    }
}