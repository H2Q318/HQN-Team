﻿
namespace PBL.View
{
    partial class fHoaDon
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
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btXoa = new System.Windows.Forms.Button();
            this.btDetail = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbReset = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbbSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(4, 3);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(780, 538);
            this.dgvHoaDon.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvHoaDon);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 544);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btXoa);
            this.panel2.Controls.Add(this.btDetail);
            this.panel2.Location = new System.Drawing.Point(805, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 86);
            this.panel2.TabIndex = 2;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(17, 28);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(87, 33);
            this.btXoa.TabIndex = 1;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btDetail
            // 
            this.btDetail.Location = new System.Drawing.Point(130, 28);
            this.btDetail.Name = "btDetail";
            this.btDetail.Size = new System.Drawing.Size(87, 33);
            this.btDetail.TabIndex = 0;
            this.btDetail.Text = "Chi tiết";
            this.btDetail.UseVisualStyleBackColor = true;
            this.btDetail.Click += new System.EventHandler(this.btDetail_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.lbReset);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txbSearch);
            this.panel3.Location = new System.Drawing.Point(805, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 122);
            this.panel3.TabIndex = 3;
            // 
            // lbReset
            // 
            this.lbReset.AutoSize = true;
            this.lbReset.BackColor = System.Drawing.Color.White;
            this.lbReset.ForeColor = System.Drawing.Color.DarkRed;
            this.lbReset.Location = new System.Drawing.Point(199, 49);
            this.lbReset.Name = "lbReset";
            this.lbReset.Size = new System.Drawing.Size(17, 17);
            this.lbReset.TabIndex = 3;
            this.lbReset.Text = "X";
            this.lbReset.Click += new System.EventHandler(this.lbReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Mã Book:";
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(17, 47);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(200, 22);
            this.txbSearch.TabIndex = 0;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btReset);
            this.panel4.Controls.Add(this.cbbSort);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(805, 232);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 321);
            this.panel4.TabIndex = 4;
            // 
            // cbbSort
            // 
            this.cbbSort.FormattingEnabled = true;
            this.cbbSort.Location = new System.Drawing.Point(17, 44);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Size = new System.Drawing.Size(200, 24);
            this.cbbSort.TabIndex = 4;
            this.cbbSort.DropDownClosed += new System.EventHandler(this.cbbSort_DropDownClosed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sắp xếp theo:";
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(77, 74);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(87, 33);
            this.btReset.TabIndex = 2;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(77, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // fHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 568);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fHoaDon";
            this.Text = "fHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btDetail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbbSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbReset;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btnSearch;
    }
}