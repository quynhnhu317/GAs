namespace TKB_THCS
{
    partial class fLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLop));
            this.btnLuu = new MetroFramework.Controls.MetroButton();
            this.cbxBuoi = new MetroFramework.Controls.MetroComboBox();
            this.bindingSourceLop = new System.Windows.Forms.BindingSource(this.components);
            this.cbxKhoihoc = new MetroFramework.Controls.MetroComboBox();
            this.cbxGvcn = new MetroFramework.Controls.MetroComboBox();
            this.txtSiso = new MetroFramework.Controls.MetroTextBox();
            this.txtTenlop = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbxPhong = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtNamhoc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLop)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(261, 290);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseSelectable = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbxBuoi
            // 
            this.cbxBuoi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceLop, "BuoiHoc", true));
            this.cbxBuoi.FormattingEnabled = true;
            this.cbxBuoi.ItemHeight = 23;
            this.cbxBuoi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbxBuoi.Location = new System.Drawing.Point(166, 226);
            this.cbxBuoi.Name = "cbxBuoi";
            this.cbxBuoi.Size = new System.Drawing.Size(170, 29);
            this.cbxBuoi.TabIndex = 6;
            this.cbxBuoi.UseSelectable = true;
            // 
            // bindingSourceLop
            // 
            this.bindingSourceLop.DataSource = typeof(TKB_THCS.LopHoc);
            // 
            // cbxKhoihoc
            // 
            this.cbxKhoihoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceLop, "Khoi", true));
            this.cbxKhoihoc.FormattingEnabled = true;
            this.cbxKhoihoc.ItemHeight = 23;
            this.cbxKhoihoc.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9"});
            this.cbxKhoihoc.Location = new System.Drawing.Point(166, 127);
            this.cbxKhoihoc.Name = "cbxKhoihoc";
            this.cbxKhoihoc.Size = new System.Drawing.Size(170, 29);
            this.cbxKhoihoc.TabIndex = 3;
            this.cbxKhoihoc.UseSelectable = true;
            // 
            // cbxGvcn
            // 
            this.cbxGvcn.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceLop, "IDGV", true));
            this.cbxGvcn.FormattingEnabled = true;
            this.cbxGvcn.ItemHeight = 23;
            this.cbxGvcn.Location = new System.Drawing.Point(166, 92);
            this.cbxGvcn.Name = "cbxGvcn";
            this.cbxGvcn.Size = new System.Drawing.Size(170, 29);
            this.cbxGvcn.TabIndex = 2;
            this.cbxGvcn.UseSelectable = true;
            // 
            // txtSiso
            // 
            // 
            // 
            // 
            this.txtSiso.CustomButton.Image = null;
            this.txtSiso.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtSiso.CustomButton.Name = "";
            this.txtSiso.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSiso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSiso.CustomButton.TabIndex = 1;
            this.txtSiso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSiso.CustomButton.UseSelectable = true;
            this.txtSiso.CustomButton.Visible = false;
            this.txtSiso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceLop, "SiSo", true));
            this.txtSiso.Lines = new string[0];
            this.txtSiso.Location = new System.Drawing.Point(166, 162);
            this.txtSiso.MaxLength = 32767;
            this.txtSiso.Name = "txtSiso";
            this.txtSiso.PasswordChar = '\0';
            this.txtSiso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSiso.SelectedText = "";
            this.txtSiso.SelectionLength = 0;
            this.txtSiso.SelectionStart = 0;
            this.txtSiso.ShortcutsEnabled = true;
            this.txtSiso.Size = new System.Drawing.Size(170, 23);
            this.txtSiso.TabIndex = 4;
            this.txtSiso.UseSelectable = true;
            this.txtSiso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSiso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTenlop
            // 
            // 
            // 
            // 
            this.txtTenlop.CustomButton.Image = null;
            this.txtTenlop.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtTenlop.CustomButton.Name = "";
            this.txtTenlop.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTenlop.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenlop.CustomButton.TabIndex = 1;
            this.txtTenlop.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenlop.CustomButton.UseSelectable = true;
            this.txtTenlop.CustomButton.Visible = false;
            this.txtTenlop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceLop, "TenLop", true));
            this.txtTenlop.Lines = new string[0];
            this.txtTenlop.Location = new System.Drawing.Point(166, 63);
            this.txtTenlop.MaxLength = 32767;
            this.txtTenlop.Name = "txtTenlop";
            this.txtTenlop.PasswordChar = '\0';
            this.txtTenlop.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenlop.SelectedText = "";
            this.txtTenlop.SelectionLength = 0;
            this.txtTenlop.SelectionStart = 0;
            this.txtTenlop.ShortcutsEnabled = true;
            this.txtTenlop.Size = new System.Drawing.Size(170, 23);
            this.txtTenlop.TabIndex = 1;
            this.txtTenlop.UseSelectable = true;
            this.txtTenlop.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenlop.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(30, 226);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Buổi học (*):";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(30, 162);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(39, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Sỉ số:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(30, 127);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Khối học:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(30, 191);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Phòng học:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(29, 92);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(130, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Giáo viên chủ nhiệm:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(30, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Tên lớp:";
            // 
            // cbxPhong
            // 
            this.cbxPhong.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceLop, "IDPH", true));
            this.cbxPhong.FormattingEnabled = true;
            this.cbxPhong.ItemHeight = 23;
            this.cbxPhong.Location = new System.Drawing.Point(166, 191);
            this.cbxPhong.Name = "cbxPhong";
            this.cbxPhong.Size = new System.Drawing.Size(170, 29);
            this.cbxPhong.TabIndex = 5;
            this.cbxPhong.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(30, 261);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(66, 19);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Năm học:";
            // 
            // txtNamhoc
            // 
            // 
            // 
            // 
            this.txtNamhoc.CustomButton.Image = null;
            this.txtNamhoc.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtNamhoc.CustomButton.Name = "";
            this.txtNamhoc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNamhoc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNamhoc.CustomButton.TabIndex = 1;
            this.txtNamhoc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNamhoc.CustomButton.UseSelectable = true;
            this.txtNamhoc.CustomButton.Visible = false;
            this.txtNamhoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceLop, "Nam", true));
            this.txtNamhoc.Lines = new string[0];
            this.txtNamhoc.Location = new System.Drawing.Point(166, 261);
            this.txtNamhoc.MaxLength = 32767;
            this.txtNamhoc.Name = "txtNamhoc";
            this.txtNamhoc.PasswordChar = '\0';
            this.txtNamhoc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNamhoc.SelectedText = "";
            this.txtNamhoc.SelectionLength = 0;
            this.txtNamhoc.SelectionStart = 0;
            this.txtNamhoc.ShortcutsEnabled = true;
            this.txtNamhoc.Size = new System.Drawing.Size(170, 23);
            this.txtNamhoc.TabIndex = 7;
            this.txtNamhoc.UseSelectable = true;
            this.txtNamhoc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNamhoc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.ForeColor = System.Drawing.Color.Red;
            this.metroLabel8.Location = new System.Drawing.Point(30, 332);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(260, 19);
            this.metroLabel8.TabIndex = 9;
            this.metroLabel8.Text = "(*): Số 1 là \"Buổi sáng\", số 2 là \"Buổi chiều\"";
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // fLop
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 380);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbxPhong);
            this.Controls.Add(this.cbxBuoi);
            this.Controls.Add(this.cbxKhoihoc);
            this.Controls.Add(this.cbxGvcn);
            this.Controls.Add(this.txtNamhoc);
            this.Controls.Add(this.txtSiso);
            this.Controls.Add(this.txtTenlop);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fLop";
            this.Resizable = false;
            this.Text = "Cập nhật lớp học";
            this.Load += new System.EventHandler(this.fLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLuu;
        private MetroFramework.Controls.MetroComboBox cbxBuoi;
        private MetroFramework.Controls.MetroComboBox cbxKhoihoc;
        private MetroFramework.Controls.MetroComboBox cbxGvcn;
        private MetroFramework.Controls.MetroTextBox txtSiso;
        private MetroFramework.Controls.MetroTextBox txtTenlop;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbxPhong;
        private System.Windows.Forms.BindingSource bindingSourceLop;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtNamhoc;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}