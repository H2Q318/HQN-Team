
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.càiĐătThôngTinKháchSạnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.func_XemChiTietHoaDon_DichVu_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.func_XemChiTietHoaDon_VatTu_Result1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
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
            this.rpHoaDon.Location = new System.Drawing.Point(0, 28);
            this.rpHoaDon.Name = "rpHoaDon";
            this.rpHoaDon.ServerReport.BearerToken = null;
            this.rpHoaDon.Size = new System.Drawing.Size(924, 522);
            this.rpHoaDon.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.càiĐătThôngTinKháchSạnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // càiĐătThôngTinKháchSạnToolStripMenuItem
            // 
            this.càiĐătThôngTinKháchSạnToolStripMenuItem.Name = "càiĐătThôngTinKháchSạnToolStripMenuItem";
            this.càiĐătThôngTinKháchSạnToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.càiĐătThôngTinKháchSạnToolStripMenuItem.Text = "Cài đăt thông tin khách sạn";
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Print";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Print_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.func_XemChiTietHoaDon_DichVu_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.func_XemChiTietHoaDon_VatTu_Result1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpHoaDon;
        private System.Windows.Forms.BindingSource func_XemChiTietHoaDon_DichVu_ResultBindingSource;
        private System.Windows.Forms.BindingSource func_XemChiTietHoaDon_VatTu_Result1BindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem càiĐătThôngTinKháchSạnToolStripMenuItem;
    }
}