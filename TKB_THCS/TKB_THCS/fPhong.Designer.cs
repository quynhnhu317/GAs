namespace TKB_THCS
{
    partial class fPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPhong));
            this.btnLuu = new MetroFramework.Controls.MetroButton();
            this.txtVitri = new MetroFramework.Controls.MetroTextBox();
            this.bindingSourcePhong = new System.Windows.Forms.BindingSource(this.components);
            this.txtTenphong = new MetroFramework.Controls.MetroTextBox();
            this.txtSucchua = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePhong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(227, 157);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseSelectable = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtVitri
            // 
            // 
            // 
            // 
            this.txtVitri.CustomButton.Image = null;
            this.txtVitri.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txtVitri.CustomButton.Name = "";
            this.txtVitri.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtVitri.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVitri.CustomButton.TabIndex = 1;
            this.txtVitri.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVitri.CustomButton.UseSelectable = true;
            this.txtVitri.CustomButton.Visible = false;
            this.txtVitri.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePhong, "ViTri", true));
            this.txtVitri.Lines = new string[0];
            this.txtVitri.Location = new System.Drawing.Point(101, 128);
            this.txtVitri.MaxLength = 32767;
            this.txtVitri.Name = "txtVitri";
            this.txtVitri.PasswordChar = '\0';
            this.txtVitri.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVitri.SelectedText = "";
            this.txtVitri.SelectionLength = 0;
            this.txtVitri.SelectionStart = 0;
            this.txtVitri.ShortcutsEnabled = true;
            this.txtVitri.Size = new System.Drawing.Size(201, 23);
            this.txtVitri.TabIndex = 3;
            this.txtVitri.UseSelectable = true;
            this.txtVitri.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVitri.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bindingSourcePhong
            // 
            this.bindingSourcePhong.DataSource = typeof(TKB_THCS.PhongHoc);
            // 
            // txtTenphong
            // 
            // 
            // 
            // 
            this.txtTenphong.CustomButton.Image = null;
            this.txtTenphong.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txtTenphong.CustomButton.Name = "";
            this.txtTenphong.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTenphong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenphong.CustomButton.TabIndex = 1;
            this.txtTenphong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenphong.CustomButton.UseSelectable = true;
            this.txtTenphong.CustomButton.Visible = false;
            this.txtTenphong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePhong, "TenPH", true));
            this.txtTenphong.Lines = new string[0];
            this.txtTenphong.Location = new System.Drawing.Point(101, 70);
            this.txtTenphong.MaxLength = 32767;
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.PasswordChar = '\0';
            this.txtTenphong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenphong.SelectedText = "";
            this.txtTenphong.SelectionLength = 0;
            this.txtTenphong.SelectionStart = 0;
            this.txtTenphong.ShortcutsEnabled = true;
            this.txtTenphong.Size = new System.Drawing.Size(201, 23);
            this.txtTenphong.TabIndex = 1;
            this.txtTenphong.UseSelectable = true;
            this.txtTenphong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenphong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSucchua
            // 
            // 
            // 
            // 
            this.txtSucchua.CustomButton.Image = null;
            this.txtSucchua.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txtSucchua.CustomButton.Name = "";
            this.txtSucchua.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSucchua.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSucchua.CustomButton.TabIndex = 1;
            this.txtSucchua.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSucchua.CustomButton.UseSelectable = true;
            this.txtSucchua.CustomButton.Visible = false;
            this.txtSucchua.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePhong, "SucChua", true));
            this.txtSucchua.Lines = new string[0];
            this.txtSucchua.Location = new System.Drawing.Point(101, 99);
            this.txtSucchua.MaxLength = 32767;
            this.txtSucchua.Name = "txtSucchua";
            this.txtSucchua.PasswordChar = '\0';
            this.txtSucchua.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSucchua.SelectedText = "";
            this.txtSucchua.SelectionLength = 0;
            this.txtSucchua.SelectionStart = 0;
            this.txtSucchua.ShortcutsEnabled = true;
            this.txtSucchua.Size = new System.Drawing.Size(201, 23);
            this.txtSucchua.TabIndex = 2;
            this.txtSucchua.UseSelectable = true;
            this.txtSucchua.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSucchua.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 70);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Tên phòng:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 128);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Vị trí:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 99);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Sức chứa:";
            // 
            // fPhong
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 207);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtVitri);
            this.Controls.Add(this.txtTenphong);
            this.Controls.Add(this.txtSucchua);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fPhong";
            this.Resizable = false;
            this.Text = "Cập nhật phòng học";
            this.Load += new System.EventHandler(this.fPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLuu;
        private MetroFramework.Controls.MetroTextBox txtVitri;
        private MetroFramework.Controls.MetroTextBox txtTenphong;
        private MetroFramework.Controls.MetroTextBox txtSucchua;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.BindingSource bindingSourcePhong;
    }
}