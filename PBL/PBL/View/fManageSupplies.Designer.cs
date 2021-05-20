namespace PBL
{
    partial class fManageSupplies
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
            this.dgvVatDungPhong = new System.Windows.Forms.DataGridView();
            this.panel25 = new System.Windows.Forms.Panel();
            this.btnResetSPhong = new System.Windows.Forms.Button();
            this.BtnSeachPhong = new System.Windows.Forms.Button();
            this.txbSeachPhong = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.btnResetVt = new System.Windows.Forms.Button();
            this.BtnXoaVt = new System.Windows.Forms.Button();
            this.BtnSuaVt = new System.Windows.Forms.Button();
            this.btnThemVt = new System.Windows.Forms.Button();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.label43 = new System.Windows.Forms.Label();
            this.nUDSLHienTai = new System.Windows.Forms.NumericUpDown();
            this.nUDSLBanDau = new System.Windows.Forms.NumericUpDown();
            this.cbTenVatTu = new System.Windows.Forms.ComboBox();
            this.panel27 = new System.Windows.Forms.Panel();
            this.label42 = new System.Windows.Forms.Label();
            this.panel28 = new System.Windows.Forms.Panel();
            this.cbPhongID = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatDungPhong)).BeginInit();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSLHienTai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSLBanDau)).BeginInit();
            this.panel27.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVatDungPhong
            // 
            this.dgvVatDungPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVatDungPhong.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvVatDungPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVatDungPhong.Location = new System.Drawing.Point(3, 2);
            this.dgvVatDungPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVatDungPhong.Name = "dgvVatDungPhong";
            this.dgvVatDungPhong.ReadOnly = true;
            this.dgvVatDungPhong.RowHeadersVisible = false;
            this.dgvVatDungPhong.RowHeadersWidth = 51;
            this.dgvVatDungPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVatDungPhong.Size = new System.Drawing.Size(917, 416);
            this.dgvVatDungPhong.TabIndex = 0;
            this.dgvVatDungPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVatDungPhong_CellClick);
            // 
            // panel25
            // 
            this.panel25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel25.Controls.Add(this.btnResetSPhong);
            this.panel25.Controls.Add(this.BtnSeachPhong);
            this.panel25.Controls.Add(this.txbSeachPhong);
            this.panel25.Controls.Add(this.label15);
            this.panel25.Location = new System.Drawing.Point(944, 129);
            this.panel25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(363, 423);
            this.panel25.TabIndex = 23;
            // 
            // btnResetSPhong
            // 
            this.btnResetSPhong.Location = new System.Drawing.Point(203, 96);
            this.btnResetSPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetSPhong.Name = "btnResetSPhong";
            this.btnResetSPhong.Size = new System.Drawing.Size(84, 41);
            this.btnResetSPhong.TabIndex = 19;
            this.btnResetSPhong.Text = "Reset";
            this.btnResetSPhong.UseVisualStyleBackColor = true;
            this.btnResetSPhong.Click += new System.EventHandler(this.btnResetSPhong_Click);
            // 
            // BtnSeachPhong
            // 
            this.BtnSeachPhong.Location = new System.Drawing.Point(73, 96);
            this.BtnSeachPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSeachPhong.Name = "BtnSeachPhong";
            this.BtnSeachPhong.Size = new System.Drawing.Size(84, 41);
            this.BtnSeachPhong.TabIndex = 18;
            this.BtnSeachPhong.Text = "Tìm kiếm";
            this.BtnSeachPhong.UseVisualStyleBackColor = true;
            this.BtnSeachPhong.Click += new System.EventHandler(this.BtnSeachPhong_Click);
            // 
            // txbSeachPhong
            // 
            this.txbSeachPhong.Location = new System.Drawing.Point(179, 36);
            this.txbSeachPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSeachPhong.Name = "txbSeachPhong";
            this.txbSeachPhong.Size = new System.Drawing.Size(161, 22);
            this.txbSeachPhong.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(47, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 17);
            this.label15.TabIndex = 16;
            this.label15.Text = "Nhập tên phòng";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(292, 22);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(120, 17);
            this.label37.TabIndex = 21;
            this.label37.Text = "Số lượng ban đầu";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(300, 73);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(114, 17);
            this.label40.TabIndex = 20;
            this.label40.Text = "Số lượng hiện tại";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(29, 73);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(72, 17);
            this.label41.TabIndex = 19;
            this.label41.Text = "Tên vật tư";
            // 
            // panel26
            // 
            this.panel26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel26.Controls.Add(this.btnResetVt);
            this.panel26.Controls.Add(this.BtnXoaVt);
            this.panel26.Controls.Add(this.BtnSuaVt);
            this.panel26.Controls.Add(this.btnThemVt);
            this.panel26.Location = new System.Drawing.Point(944, 12);
            this.panel26.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(363, 110);
            this.panel26.TabIndex = 22;
            // 
            // btnResetVt
            // 
            this.btnResetVt.Location = new System.Drawing.Point(203, 60);
            this.btnResetVt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetVt.Name = "btnResetVt";
            this.btnResetVt.Size = new System.Drawing.Size(84, 39);
            this.btnResetVt.TabIndex = 3;
            this.btnResetVt.Text = "Reset";
            this.btnResetVt.UseVisualStyleBackColor = true;
            this.btnResetVt.Click += new System.EventHandler(this.btnResetVt_Click);
            // 
            // BtnXoaVt
            // 
            this.BtnXoaVt.Location = new System.Drawing.Point(73, 60);
            this.BtnXoaVt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnXoaVt.Name = "BtnXoaVt";
            this.BtnXoaVt.Size = new System.Drawing.Size(84, 39);
            this.BtnXoaVt.TabIndex = 2;
            this.BtnXoaVt.Text = "Xóa";
            this.BtnXoaVt.UseVisualStyleBackColor = true;
            this.BtnXoaVt.Click += new System.EventHandler(this.BtnXoaVt_Click);
            // 
            // BtnSuaVt
            // 
            this.BtnSuaVt.Location = new System.Drawing.Point(203, 10);
            this.BtnSuaVt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSuaVt.Name = "BtnSuaVt";
            this.BtnSuaVt.Size = new System.Drawing.Size(84, 39);
            this.BtnSuaVt.TabIndex = 1;
            this.BtnSuaVt.Text = "Sửa";
            this.BtnSuaVt.UseVisualStyleBackColor = true;
            this.BtnSuaVt.Click += new System.EventHandler(this.BtnSuaVt_Click);
            // 
            // btnThemVt
            // 
            this.btnThemVt.Location = new System.Drawing.Point(73, 10);
            this.btnThemVt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemVt.Name = "btnThemVt";
            this.btnThemVt.Size = new System.Drawing.Size(84, 39);
            this.btnThemVt.TabIndex = 0;
            this.btnThemVt.Text = "Thêm";
            this.btnThemVt.UseVisualStyleBackColor = true;
            this.btnThemVt.Click += new System.EventHandler(this.btnThemVt_Click);
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(692, 69);
            this.cbTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(164, 24);
            this.cbTrangThai.TabIndex = 30;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(613, 73);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(73, 17);
            this.label43.TabIndex = 29;
            this.label43.Text = "Trạng thái";
            // 
            // nUDSLHienTai
            // 
            this.nUDSLHienTai.Location = new System.Drawing.Point(420, 68);
            this.nUDSLHienTai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUDSLHienTai.Name = "nUDSLHienTai";
            this.nUDSLHienTai.Size = new System.Drawing.Size(120, 22);
            this.nUDSLHienTai.TabIndex = 28;
            // 
            // nUDSLBanDau
            // 
            this.nUDSLBanDau.Location = new System.Drawing.Point(420, 20);
            this.nUDSLBanDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUDSLBanDau.Name = "nUDSLBanDau";
            this.nUDSLBanDau.Size = new System.Drawing.Size(120, 22);
            this.nUDSLBanDau.TabIndex = 27;
            // 
            // cbTenVatTu
            // 
            this.cbTenVatTu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenVatTu.FormattingEnabled = true;
            this.cbTenVatTu.Location = new System.Drawing.Point(123, 66);
            this.cbTenVatTu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTenVatTu.Name = "cbTenVatTu";
            this.cbTenVatTu.Size = new System.Drawing.Size(121, 24);
            this.cbTenVatTu.TabIndex = 26;
            // 
            // panel27
            // 
            this.panel27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel27.Controls.Add(this.dgvVatDungPhong);
            this.panel27.Location = new System.Drawing.Point(12, 129);
            this.panel27.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(925, 423);
            this.panel27.TabIndex = 21;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(35, 22);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(49, 17);
            this.label42.TabIndex = 18;
            this.label42.Text = "Phòng";
            // 
            // panel28
            // 
            this.panel28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel28.Controls.Add(this.cbPhongID);
            this.panel28.Controls.Add(this.cbTrangThai);
            this.panel28.Controls.Add(this.label43);
            this.panel28.Controls.Add(this.nUDSLHienTai);
            this.panel28.Controls.Add(this.nUDSLBanDau);
            this.panel28.Controls.Add(this.cbTenVatTu);
            this.panel28.Controls.Add(this.label37);
            this.panel28.Controls.Add(this.label40);
            this.panel28.Controls.Add(this.label41);
            this.panel28.Controls.Add(this.label42);
            this.panel28.Location = new System.Drawing.Point(12, 12);
            this.panel28.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(925, 110);
            this.panel28.TabIndex = 20;
            // 
            // cbPhongID
            // 
            this.cbPhongID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhongID.FormattingEnabled = true;
            this.cbPhongID.Location = new System.Drawing.Point(123, 18);
            this.cbPhongID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPhongID.Name = "cbPhongID";
            this.cbPhongID.Size = new System.Drawing.Size(121, 24);
            this.cbPhongID.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel25);
            this.panel1.Controls.Add(this.panel26);
            this.panel1.Controls.Add(this.panel27);
            this.panel1.Controls.Add(this.panel28);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1321, 564);
            this.panel1.TabIndex = 1;
            // 
            // fManageSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 564);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fManageSupplies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý vật tư";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatDungPhong)).EndInit();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel26.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUDSLHienTai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSLBanDau)).EndInit();
            this.panel27.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVatDungPhong;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Button btnResetSPhong;
        private System.Windows.Forms.Button BtnSeachPhong;
        private System.Windows.Forms.TextBox txbSeachPhong;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Button btnResetVt;
        private System.Windows.Forms.Button BtnXoaVt;
        private System.Windows.Forms.Button BtnSuaVt;
        private System.Windows.Forms.Button btnThemVt;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.NumericUpDown nUDSLHienTai;
        private System.Windows.Forms.NumericUpDown nUDSLBanDau;
        private System.Windows.Forms.ComboBox cbTenVatTu;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbPhongID;
    }
}