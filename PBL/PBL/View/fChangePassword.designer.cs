namespace PBL
{
    partial class fChangePassword
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNotUpdatePassword = new System.Windows.Forms.Button();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.txbNewPasswordAgain = new System.Windows.Forms.TextBox();
            this.lbNewPasswordAgain = new System.Windows.Forms.Label();
            this.txbNewPassword = new System.Windows.Forms.TextBox();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.txbOldPassword = new System.Windows.Forms.TextBox();
            this.lbOldPassword = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelTitle.Controls.Add(this.lbTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1110, 80);
            this.panelTitle.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTitle.Location = new System.Drawing.Point(367, 12);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(377, 56);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "ĐỔI MẬT KHẨU";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1110, 670);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnNotUpdatePassword);
            this.panel1.Controls.Add(this.btnUpdatePassword);
            this.panel1.Controls.Add(this.txbNewPasswordAgain);
            this.panel1.Controls.Add(this.lbNewPasswordAgain);
            this.panel1.Controls.Add(this.txbNewPassword);
            this.panel1.Controls.Add(this.lbNewPassword);
            this.panel1.Controls.Add(this.txbOldPassword);
            this.panel1.Controls.Add(this.lbOldPassword);
            this.panel1.Location = new System.Drawing.Point(255, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 318);
            this.panel1.TabIndex = 0;
            // 
            // btnNotUpdatePassword
            // 
            this.btnNotUpdatePassword.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNotUpdatePassword.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotUpdatePassword.Location = new System.Drawing.Point(397, 270);
            this.btnNotUpdatePassword.Name = "btnNotUpdatePassword";
            this.btnNotUpdatePassword.Size = new System.Drawing.Size(111, 30);
            this.btnNotUpdatePassword.TabIndex = 7;
            this.btnNotUpdatePassword.Text = "Hủy";
            this.btnNotUpdatePassword.UseVisualStyleBackColor = true;
            this.btnNotUpdatePassword.Click += new System.EventHandler(this.btnNotUpdatePassword_Click);
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePassword.Location = new System.Drawing.Point(248, 270);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(111, 30);
            this.btnUpdatePassword.TabIndex = 6;
            this.btnUpdatePassword.Text = "Cập nhật";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // txbNewPasswordAgain
            // 
            this.txbNewPasswordAgain.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewPasswordAgain.Location = new System.Drawing.Point(247, 175);
            this.txbNewPasswordAgain.Name = "txbNewPasswordAgain";
            this.txbNewPasswordAgain.Size = new System.Drawing.Size(260, 26);
            this.txbNewPasswordAgain.TabIndex = 5;
            this.txbNewPasswordAgain.UseSystemPasswordChar = true;
            // 
            // lbNewPasswordAgain
            // 
            this.lbNewPasswordAgain.AutoSize = true;
            this.lbNewPasswordAgain.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPasswordAgain.Location = new System.Drawing.Point(34, 178);
            this.lbNewPasswordAgain.Name = "lbNewPasswordAgain";
            this.lbNewPasswordAgain.Size = new System.Drawing.Size(184, 19);
            this.lbNewPasswordAgain.TabIndex = 4;
            this.lbNewPasswordAgain.Text = "Nhập lại mật khẩu mới:";
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewPassword.Location = new System.Drawing.Point(248, 107);
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.Size = new System.Drawing.Size(260, 26);
            this.txbNewPassword.TabIndex = 3;
            this.txbNewPassword.UseSystemPasswordChar = true;
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPassword.Location = new System.Drawing.Point(102, 110);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(117, 19);
            this.lbNewPassword.TabIndex = 2;
            this.lbNewPassword.Text = "Mật khẩu mới:";
            // 
            // txbOldPassword
            // 
            this.txbOldPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOldPassword.Location = new System.Drawing.Point(248, 39);
            this.txbOldPassword.Name = "txbOldPassword";
            this.txbOldPassword.Size = new System.Drawing.Size(260, 26);
            this.txbOldPassword.TabIndex = 1;
            this.txbOldPassword.UseSystemPasswordChar = true;
            // 
            // lbOldPassword
            // 
            this.lbOldPassword.AutoSize = true;
            this.lbOldPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbOldPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldPassword.Location = new System.Drawing.Point(112, 42);
            this.lbOldPassword.Name = "lbOldPassword";
            this.lbOldPassword.Size = new System.Drawing.Size(107, 19);
            this.lbOldPassword.TabIndex = 0;
            this.lbOldPassword.Text = "Mật khẩu cũ:";
            // 
            // fChangePassword
            // 
            this.AcceptButton = this.btnUpdatePassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.btnNotUpdatePassword;
            this.ClientSize = new System.Drawing.Size(1110, 750);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNotUpdatePassword;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.TextBox txbNewPasswordAgain;
        private System.Windows.Forms.Label lbNewPasswordAgain;
        private System.Windows.Forms.TextBox txbNewPassword;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.TextBox txbOldPassword;
        private System.Windows.Forms.Label lbOldPassword;
        private System.Windows.Forms.Label lbTitle;
    }
}