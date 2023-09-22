namespace TKB_THCS
{
    partial class fNguoidung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNguoidung));
            this.btnLuu = new MetroFramework.Controls.MetroButton();
            this.txtQuyen = new MetroFramework.Controls.MetroTextBox();
            this.bindingSourceNguoidung = new System.Windows.Forms.BindingSource(this.components);
            this.txtMk = new MetroFramework.Controls.MetroTextBox();
            this.txtTendn = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNguoidung)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(262, 168);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseSelectable = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtQuyen
            // 
            // 
            // 
            // 
            this.txtQuyen.CustomButton.Image = null;
            this.txtQuyen.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtQuyen.CustomButton.Name = "";
            this.txtQuyen.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuyen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuyen.CustomButton.TabIndex = 1;
            this.txtQuyen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuyen.CustomButton.UseSelectable = true;
            this.txtQuyen.CustomButton.Visible = false;
            this.txtQuyen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceNguoidung, "Quyen", true));
            this.txtQuyen.Lines = new string[0];
            this.txtQuyen.Location = new System.Drawing.Point(144, 139);
            this.txtQuyen.MaxLength = 32767;
            this.txtQuyen.Name = "txtQuyen";
            this.txtQuyen.PasswordChar = '\0';
            this.txtQuyen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuyen.SelectedText = "";
            this.txtQuyen.SelectionLength = 0;
            this.txtQuyen.SelectionStart = 0;
            this.txtQuyen.ShortcutsEnabled = true;
            this.txtQuyen.Size = new System.Drawing.Size(193, 23);
            this.txtQuyen.TabIndex = 3;
            this.txtQuyen.UseSelectable = true;
            this.txtQuyen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuyen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bindingSourceNguoidung
            // 
            this.bindingSourceNguoidung.DataSource = typeof(TKB_THCS.QuyenTruyCap);
            // 
            // txtMk
            // 
            // 
            // 
            // 
            this.txtMk.CustomButton.Image = null;
            this.txtMk.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtMk.CustomButton.Name = "";
            this.txtMk.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMk.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMk.CustomButton.TabIndex = 1;
            this.txtMk.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMk.CustomButton.UseSelectable = true;
            this.txtMk.CustomButton.Visible = false;
            this.txtMk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceNguoidung, "MatKhau", true));
            this.txtMk.Lines = new string[0];
            this.txtMk.Location = new System.Drawing.Point(144, 110);
            this.txtMk.MaxLength = 32767;
            this.txtMk.Name = "txtMk";
            this.txtMk.PasswordChar = '\0';
            this.txtMk.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMk.SelectedText = "";
            this.txtMk.SelectionLength = 0;
            this.txtMk.SelectionStart = 0;
            this.txtMk.ShortcutsEnabled = true;
            this.txtMk.Size = new System.Drawing.Size(193, 23);
            this.txtMk.TabIndex = 2;
            this.txtMk.UseSelectable = true;
            this.txtMk.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMk.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTendn
            // 
            // 
            // 
            // 
            this.txtTendn.CustomButton.Image = null;
            this.txtTendn.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtTendn.CustomButton.Name = "";
            this.txtTendn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTendn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTendn.CustomButton.TabIndex = 1;
            this.txtTendn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTendn.CustomButton.UseSelectable = true;
            this.txtTendn.CustomButton.Visible = false;
            this.txtTendn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceNguoidung, "TenDN", true));
            this.txtTendn.Lines = new string[0];
            this.txtTendn.Location = new System.Drawing.Point(144, 81);
            this.txtTendn.MaxLength = 32767;
            this.txtTendn.Name = "txtTendn";
            this.txtTendn.PasswordChar = '\0';
            this.txtTendn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTendn.SelectedText = "";
            this.txtTendn.SelectionLength = 0;
            this.txtTendn.SelectionStart = 0;
            this.txtTendn.ShortcutsEnabled = true;
            this.txtTendn.Size = new System.Drawing.Size(193, 23);
            this.txtTendn.TabIndex = 1;
            this.txtTendn.UseSelectable = true;
            this.txtTendn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTendn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(32, 142);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(50, 19);
            this.metroLabel11.TabIndex = 0;
            this.metroLabel11.Text = "Quyền:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(32, 113);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(66, 19);
            this.metroLabel9.TabIndex = 0;
            this.metroLabel9.Text = "Mật khẩu:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(32, 84);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(100, 19);
            this.metroLabel8.TabIndex = 0;
            this.metroLabel8.Text = "Tên đăng nhập:";
            // 
            // fNguoidung
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 215);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtQuyen);
            this.Controls.Add(this.txtMk);
            this.Controls.Add(this.txtTendn);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fNguoidung";
            this.Resizable = false;
            this.Text = "Cập nhật người dùng";
            this.Load += new System.EventHandler(this.fNguoidung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNguoidung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLuu;
        private MetroFramework.Controls.MetroTextBox txtQuyen;
        private MetroFramework.Controls.MetroTextBox txtMk;
        private MetroFramework.Controls.MetroTextBox txtTendn;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.BindingSource bindingSourceNguoidung;
    }
}