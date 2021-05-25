namespace PBL
{
    partial class fAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAccount));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txbNote = new System.Windows.Forms.TextBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txbPosition = new System.Windows.Forms.TextBox();
            this.lbPosition = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txbCMND = new System.Windows.Forms.TextBox();
            this.lbCMND = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.panel17);
            this.panel4.Controls.Add(this.panel16);
            this.panel4.Controls.Add(this.panel12);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(12, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(427, 502);
            this.panel4.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 40);
            this.panel1.TabIndex = 0;
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(148, 10);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(245, 22);
            this.txbID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(316, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 35);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(229, 446);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 35);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.txbNote);
            this.panel17.Controls.Add(this.lbNote);
            this.panel17.Location = new System.Drawing.Point(4, 371);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(420, 41);
            this.panel17.TabIndex = 8;
            // 
            // txbNote
            // 
            this.txbNote.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNote.Location = new System.Drawing.Point(148, 10);
            this.txbNote.Name = "txbNote";
            this.txbNote.Size = new System.Drawing.Size(245, 22);
            this.txbNote.TabIndex = 2;
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.Location = new System.Drawing.Point(28, 13);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(61, 16);
            this.lbNote.TabIndex = 0;
            this.lbNote.Text = "Ghi chú:";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.txbPosition);
            this.panel16.Controls.Add(this.lbPosition);
            this.panel16.Location = new System.Drawing.Point(4, 325);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(420, 40);
            this.panel16.TabIndex = 7;
            // 
            // txbPosition
            // 
            this.txbPosition.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPosition.Location = new System.Drawing.Point(148, 9);
            this.txbPosition.Name = "txbPosition";
            this.txbPosition.ReadOnly = true;
            this.txbPosition.Size = new System.Drawing.Size(245, 22);
            this.txbPosition.TabIndex = 2;
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.Location = new System.Drawing.Point(25, 12);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(64, 16);
            this.lbPosition.TabIndex = 0;
            this.lbPosition.Text = "Chức vụ:";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txbAddress);
            this.panel12.Controls.Add(this.lbAddress);
            this.panel12.Location = new System.Drawing.Point(4, 279);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(420, 40);
            this.panel12.TabIndex = 6;
            // 
            // txbAddress
            // 
            this.txbAddress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddress.Location = new System.Drawing.Point(148, 10);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(245, 22);
            this.txbAddress.TabIndex = 1;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(33, 13);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(56, 16);
            this.lbAddress.TabIndex = 0;
            this.lbAddress.Text = "Địa chỉ:";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txbCMND);
            this.panel10.Controls.Add(this.lbCMND);
            this.panel10.Location = new System.Drawing.Point(4, 233);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(420, 40);
            this.panel10.TabIndex = 5;
            // 
            // txbCMND
            // 
            this.txbCMND.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCMND.Location = new System.Drawing.Point(148, 10);
            this.txbCMND.MaxLength = 10;
            this.txbCMND.Name = "txbCMND";
            this.txbCMND.Size = new System.Drawing.Size(245, 22);
            this.txbCMND.TabIndex = 1;
            this.txbCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumberKeyPress);
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCMND.Location = new System.Drawing.Point(39, 13);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(50, 16);
            this.lbCMND.TabIndex = 0;
            this.lbCMND.Text = "CMND:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txbPhone);
            this.panel9.Controls.Add(this.lbPhone);
            this.panel9.Location = new System.Drawing.Point(4, 187);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(420, 40);
            this.panel9.TabIndex = 4;
            // 
            // txbPhone
            // 
            this.txbPhone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhone.Location = new System.Drawing.Point(148, 10);
            this.txbPhone.MaxLength = 11;
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(245, 22);
            this.txbPhone.TabIndex = 2;
            this.txbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumberKeyPress);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(52, 13);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(37, 16);
            this.lbPhone.TabIndex = 0;
            this.lbPhone.Text = "SĐT:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dtpBirthday);
            this.panel8.Controls.Add(this.lbBirthday);
            this.panel8.Location = new System.Drawing.Point(4, 141);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(420, 40);
            this.panel8.TabIndex = 3;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthday.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(148, 9);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(245, 21);
            this.dtpBirthday.TabIndex = 3;
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthday.Location = new System.Drawing.Point(18, 13);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(71, 16);
            this.lbBirthday.TabIndex = 0;
            this.lbBirthday.Text = "Năm sinh:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbGender);
            this.panel7.Controls.Add(this.lbGender);
            this.panel7.Location = new System.Drawing.Point(4, 95);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(420, 40);
            this.panel7.TabIndex = 2;
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGender.Location = new System.Drawing.Point(148, 9);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(245, 23);
            this.cbGender.TabIndex = 2;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(22, 11);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(67, 16);
            this.lbGender.TabIndex = 0;
            this.lbGender.Text = "Giới tính:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbName);
            this.panel6.Controls.Add(this.lbName);
            this.panel6.Location = new System.Drawing.Point(4, 49);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(420, 40);
            this.panel6.TabIndex = 1;
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(148, 10);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(245, 22);
            this.txbName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(53, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(36, 16);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "TÀI KHOẢN";
            // 
            // fAccount
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(452, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAccount";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tài khoản";
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txbNote;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txbCMND;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label2;
    }
}