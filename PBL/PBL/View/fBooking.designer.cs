namespace PBL
{
    partial class fBooking
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
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.panel18 = new System.Windows.Forms.Panel();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btXoaKH = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel20 = new System.Windows.Forms.Panel();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTenNhanVien = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBookID = new System.Windows.Forms.TextBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTitleBook = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lbTotalCost = new System.Windows.Forms.Label();
            this.txbThanhToan = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lbCheckOut = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lbCheckIn = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbCost = new System.Windows.Forms.Label();
            this.txbGia = new System.Windows.Forms.TextBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.txbLoaiPhong = new System.Windows.Forms.TextBox();
            this.lbTypeRoom = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.lbID = new System.Windows.Forms.Label();
            this.txbPhongID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.panel18.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel23.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBooking
            // 
            this.dgvBooking.AllowUserToAddRows = false;
            this.dgvBooking.AllowUserToDeleteRows = false;
            this.dgvBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBooking.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Location = new System.Drawing.Point(16, 530);
            this.dgvBooking.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            this.dgvBooking.RowHeadersWidth = 51;
            this.dgvBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooking.Size = new System.Drawing.Size(1448, 287);
            this.dgvBooking.TabIndex = 20;
            this.dgvBooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooking_CellClick);
            this.dgvBooking.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvBooking_DataBindingComplete);
            // 
            // panel18
            // 
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Controls.Add(this.lbSearch);
            this.panel18.Controls.Add(this.btnSearch);
            this.panel18.Controls.Add(this.txbSearch);
            this.panel18.Controls.Add(this.cbSearch);
            this.panel18.Location = new System.Drawing.Point(16, 447);
            this.panel18.Margin = new System.Windows.Forms.Padding(4);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1447, 76);
            this.panel18.TabIndex = 19;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(40, 26);
            this.lbSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(103, 24);
            this.lbSearch.TabIndex = 20;
            this.lbSearch.Text = "Tìm kiếm:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1317, 22);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 28);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(444, 23);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(865, 26);
            this.txbSearch.TabIndex = 1;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Theo mã phòng",
            "Theo tên khách hàng",
            "Theo tên nhân viên"});
            this.cbSearch.Location = new System.Drawing.Point(151, 24);
            this.cbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(260, 26);
            this.cbSearch.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btXoaKH);
            this.panel3.Controls.Add(this.btnDetail);
            this.panel3.Controls.Add(this.dgvKhachHang);
            this.panel3.Controls.Add(this.lbCustomer);
            this.panel3.Location = new System.Drawing.Point(891, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(573, 424);
            this.panel3.TabIndex = 18;
            // 
            // btXoaKH
            // 
            this.btXoaKH.Enabled = false;
            this.btXoaKH.Location = new System.Drawing.Point(309, 7);
            this.btXoaKH.Margin = new System.Windows.Forms.Padding(4);
            this.btXoaKH.Name = "btXoaKH";
            this.btXoaKH.Size = new System.Drawing.Size(125, 34);
            this.btXoaKH.TabIndex = 15;
            this.btXoaKH.Text = "Xoá khỏi book";
            this.btXoaKH.UseVisualStyleBackColor = true;
            this.btXoaKH.Click += new System.EventHandler(this.btXoaKH_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Enabled = false;
            this.btnDetail.Location = new System.Drawing.Point(442, 7);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(125, 34);
            this.btnDetail.TabIndex = 14;
            this.btnDetail.Text = "Xem chi tiết";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(4, 49);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(563, 369);
            this.dgvKhachHang.TabIndex = 12;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            this.dgvKhachHang.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvKhachHang_DataBindingComplete);
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomer.Location = new System.Drawing.Point(4, 12);
            this.lbCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(151, 29);
            this.lbCustomer.TabIndex = 11;
            this.lbCustomer.Text = "Khách hàng";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnReset);
            this.panel6.Controls.Add(this.btnDelete);
            this.panel6.Controls.Add(this.btnUpdate);
            this.panel6.Controls.Add(this.panel20);
            this.panel6.Controls.Add(this.panel17);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel21);
            this.panel6.Controls.Add(this.lbTitleBook);
            this.panel6.Controls.Add(this.panel12);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel22);
            this.panel6.Controls.Add(this.panel23);
            this.panel6.Location = new System.Drawing.Point(16, 15);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(866, 424);
            this.panel6.TabIndex = 17;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(741, 377);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 34);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(633, 377);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 34);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(525, 377);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 34);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.dtpNgayDen);
            this.panel20.Controls.Add(this.label8);
            this.panel20.Location = new System.Drawing.Point(444, 127);
            this.panel20.Margin = new System.Windows.Forms.Padding(4);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(397, 42);
            this.panel20.TabIndex = 7;
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDen.Location = new System.Drawing.Point(157, 7);
            this.dtpNgayDen.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(225, 25);
            this.dtpNgayDen.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ngày đến:";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.dtpNgayDi);
            this.panel17.Controls.Add(this.label7);
            this.panel17.Location = new System.Drawing.Point(444, 176);
            this.panel17.Margin = new System.Windows.Forms.Padding(4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(397, 42);
            this.panel17.TabIndex = 6;
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDi.Location = new System.Drawing.Point(157, 7);
            this.dtpNgayDi.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(225, 25);
            this.dtpNgayDi.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày đi:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.txbTenNhanVien);
            this.panel7.Location = new System.Drawing.Point(21, 127);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(401, 42);
            this.panel7.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên nhân viên:";
            // 
            // txbTenNhanVien
            // 
            this.txbTenNhanVien.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenNhanVien.Location = new System.Drawing.Point(157, 7);
            this.txbTenNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txbTenNhanVien.Name = "txbTenNhanVien";
            this.txbTenNhanVien.ReadOnly = true;
            this.txbTenNhanVien.Size = new System.Drawing.Size(233, 26);
            this.txbTenNhanVien.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txbBookID);
            this.panel2.Location = new System.Drawing.Point(21, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 42);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã đặt phòng:";
            // 
            // txbBookID
            // 
            this.txbBookID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBookID.Location = new System.Drawing.Point(157, 7);
            this.txbBookID.Margin = new System.Windows.Forms.Padding(4);
            this.txbBookID.Name = "txbBookID";
            this.txbBookID.ReadOnly = true;
            this.txbBookID.Size = new System.Drawing.Size(233, 26);
            this.txbBookID.TabIndex = 0;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.dtpNgayDat);
            this.panel21.Controls.Add(this.label6);
            this.panel21.Location = new System.Drawing.Point(444, 78);
            this.panel21.Margin = new System.Windows.Forms.Padding(4);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(401, 42);
            this.panel21.TabIndex = 5;
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDat.Location = new System.Drawing.Point(157, 7);
            this.dtpNgayDat.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(233, 25);
            this.dtpNgayDat.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày đặt:";
            // 
            // lbTitleBook
            // 
            this.lbTitleBook.AutoSize = true;
            this.lbTitleBook.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleBook.Location = new System.Drawing.Point(40, 25);
            this.lbTitleBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitleBook.Name = "lbTitleBook";
            this.lbTitleBook.Size = new System.Drawing.Size(89, 29);
            this.lbTitleBook.TabIndex = 10;
            this.lbTitleBook.Text = "Phòng";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.lbTotalCost);
            this.panel12.Controls.Add(this.txbThanhToan);
            this.panel12.Location = new System.Drawing.Point(444, 324);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(397, 42);
            this.panel12.TabIndex = 7;
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.AutoSize = true;
            this.lbTotalCost.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCost.Location = new System.Drawing.Point(4, 11);
            this.lbTotalCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(90, 19);
            this.lbTotalCost.TabIndex = 1;
            this.lbTotalCost.Text = "Thành tiền:";
            // 
            // txbThanhToan
            // 
            this.txbThanhToan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbThanhToan.Location = new System.Drawing.Point(157, 7);
            this.txbThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.txbThanhToan.Name = "txbThanhToan";
            this.txbThanhToan.ReadOnly = true;
            this.txbThanhToan.Size = new System.Drawing.Size(225, 26);
            this.txbThanhToan.TabIndex = 3;
            this.txbThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dtpCheckOut);
            this.panel10.Controls.Add(this.lbCheckOut);
            this.panel10.Location = new System.Drawing.Point(444, 274);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(397, 42);
            this.panel10.TabIndex = 5;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpCheckOut.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckOut.Location = new System.Drawing.Point(157, 9);
            this.dtpCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(225, 25);
            this.dtpCheckOut.TabIndex = 3;
            // 
            // lbCheckOut
            // 
            this.lbCheckOut.AutoSize = true;
            this.lbCheckOut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckOut.Location = new System.Drawing.Point(4, 11);
            this.lbCheckOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCheckOut.Name = "lbCheckOut";
            this.lbCheckOut.Size = new System.Drawing.Size(88, 19);
            this.lbCheckOut.TabIndex = 1;
            this.lbCheckOut.Text = "Check out:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dtpCheckIn);
            this.panel9.Controls.Add(this.lbCheckIn);
            this.panel9.Location = new System.Drawing.Point(444, 225);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(397, 42);
            this.panel9.TabIndex = 4;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpCheckIn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckIn.Location = new System.Drawing.Point(157, 7);
            this.dtpCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(225, 25);
            this.dtpCheckIn.TabIndex = 2;
            // 
            // lbCheckIn
            // 
            this.lbCheckIn.AutoSize = true;
            this.lbCheckIn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckIn.Location = new System.Drawing.Point(4, 11);
            this.lbCheckIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCheckIn.Name = "lbCheckIn";
            this.lbCheckIn.Size = new System.Drawing.Size(79, 19);
            this.lbCheckIn.TabIndex = 1;
            this.lbCheckIn.Text = "Check in:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lbCost);
            this.panel8.Controls.Add(this.txbGia);
            this.panel8.Location = new System.Drawing.Point(21, 274);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(401, 42);
            this.panel8.TabIndex = 3;
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.Location = new System.Drawing.Point(12, 11);
            this.lbCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(89, 19);
            this.lbCost.TabIndex = 1;
            this.lbCost.Text = "Giá phòng:";
            // 
            // txbGia
            // 
            this.txbGia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGia.Location = new System.Drawing.Point(157, 7);
            this.txbGia.Margin = new System.Windows.Forms.Padding(4);
            this.txbGia.Name = "txbGia";
            this.txbGia.ReadOnly = true;
            this.txbGia.Size = new System.Drawing.Size(233, 26);
            this.txbGia.TabIndex = 0;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.txbLoaiPhong);
            this.panel22.Controls.Add(this.lbTypeRoom);
            this.panel22.Location = new System.Drawing.Point(21, 225);
            this.panel22.Margin = new System.Windows.Forms.Padding(4);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(401, 42);
            this.panel22.TabIndex = 1;
            // 
            // txbLoaiPhong
            // 
            this.txbLoaiPhong.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLoaiPhong.Location = new System.Drawing.Point(157, 7);
            this.txbLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txbLoaiPhong.Name = "txbLoaiPhong";
            this.txbLoaiPhong.ReadOnly = true;
            this.txbLoaiPhong.Size = new System.Drawing.Size(233, 26);
            this.txbLoaiPhong.TabIndex = 2;
            // 
            // lbTypeRoom
            // 
            this.lbTypeRoom.AutoSize = true;
            this.lbTypeRoom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeRoom.Location = new System.Drawing.Point(12, 11);
            this.lbTypeRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTypeRoom.Name = "lbTypeRoom";
            this.lbTypeRoom.Size = new System.Drawing.Size(95, 19);
            this.lbTypeRoom.TabIndex = 1;
            this.lbTypeRoom.Text = "Loại phòng:";
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.lbID);
            this.panel23.Controls.Add(this.txbPhongID);
            this.panel23.Location = new System.Drawing.Point(21, 176);
            this.panel23.Margin = new System.Windows.Forms.Padding(4);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(401, 42);
            this.panel23.TabIndex = 0;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(12, 11);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(86, 19);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "Mã phòng:";
            // 
            // txbPhongID
            // 
            this.txbPhongID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhongID.Location = new System.Drawing.Point(157, 7);
            this.txbPhongID.Margin = new System.Windows.Forms.Padding(4);
            this.txbPhongID.Name = "txbPhongID";
            this.txbPhongID.ReadOnly = true;
            this.txbPhongID.Size = new System.Drawing.Size(233, 26);
            this.txbPhongID.TabIndex = 0;
            // 
            // fBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1480, 830);
            this.Controls.Add(this.dgvBooking);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "fBooking";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTitleBook;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lbTotalCost;
        private System.Windows.Forms.TextBox txbThanhToan;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lbCheckOut;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lbCheckIn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.TextBox txbGia;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.TextBox txbLoaiPhong;
        private System.Windows.Forms.Label lbTypeRoom;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txbPhongID;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTenNhanVien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBookID;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Button btXoaKH;
    }
}