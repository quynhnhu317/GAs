namespace TKB_THCS
{
    partial class fMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMon));
            this.ck7 = new MetroFramework.Controls.MetroCheckBox();
            this.bindingSourceMon = new System.Windows.Forms.BindingSource(this.components);
            this.ck8 = new MetroFramework.Controls.MetroCheckBox();
            this.ck6 = new MetroFramework.Controls.MetroCheckBox();
            this.ck9 = new MetroFramework.Controls.MetroCheckBox();
            this.btnLuu = new MetroFramework.Controls.MetroButton();
            this.ckPhu = new MetroFramework.Controls.MetroCheckBox();
            this.ckKep = new MetroFramework.Controls.MetroCheckBox();
            this.txtSobuoi8 = new MetroFramework.Controls.MetroTextBox();
            this.txtSotiet8 = new MetroFramework.Controls.MetroTextBox();
            this.txtSobuoi9 = new MetroFramework.Controls.MetroTextBox();
            this.txtSotiet9 = new MetroFramework.Controls.MetroTextBox();
            this.txtSobuoi7 = new MetroFramework.Controls.MetroTextBox();
            this.txtSotiet7 = new MetroFramework.Controls.MetroTextBox();
            this.txtSobuoi6 = new MetroFramework.Controls.MetroTextBox();
            this.txtSotiet6 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtTenmh = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMon)).BeginInit();
            this.SuspendLayout();
            // 
            // ck7
            // 
            this.ck7.AutoSize = true;
            this.ck7.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceMon, "Khoi7", true));
            this.ck7.Location = new System.Drawing.Point(237, 126);
            this.ck7.Name = "ck7";
            this.ck7.Size = new System.Drawing.Size(56, 15);
            this.ck7.TabIndex = 3;
            this.ck7.Text = "Khối 7";
            this.ck7.UseSelectable = true;
            // 
            // bindingSourceMon
            // 
            this.bindingSourceMon.DataSource = typeof(TKB_THCS.MonHoc);
            // 
            // ck8
            // 
            this.ck8.AutoSize = true;
            this.ck8.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceMon, "Khoi8", true));
            this.ck8.Location = new System.Drawing.Point(299, 126);
            this.ck8.Name = "ck8";
            this.ck8.Size = new System.Drawing.Size(56, 15);
            this.ck8.TabIndex = 4;
            this.ck8.Text = "Khối 8";
            this.ck8.UseSelectable = true;
            // 
            // ck6
            // 
            this.ck6.AutoSize = true;
            this.ck6.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceMon, "Khoi6", true));
            this.ck6.Location = new System.Drawing.Point(175, 126);
            this.ck6.Name = "ck6";
            this.ck6.Size = new System.Drawing.Size(56, 15);
            this.ck6.TabIndex = 2;
            this.ck6.Text = "Khối 6";
            this.ck6.UseSelectable = true;
            // 
            // ck9
            // 
            this.ck9.AutoSize = true;
            this.ck9.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceMon, "Khoi9", true));
            this.ck9.Location = new System.Drawing.Point(361, 126);
            this.ck9.Name = "ck9";
            this.ck9.Size = new System.Drawing.Size(56, 15);
            this.ck9.TabIndex = 5;
            this.ck9.Text = "Khối 9";
            this.ck9.UseSelectable = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(678, 264);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseSelectable = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // ckPhu
            // 
            this.ckPhu.AutoSize = true;
            this.ckPhu.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceMon, "Phu", true));
            this.ckPhu.Location = new System.Drawing.Point(580, 126);
            this.ckPhu.Name = "ckPhu";
            this.ckPhu.Size = new System.Drawing.Size(28, 15);
            this.ckPhu.TabIndex = 11;
            this.ckPhu.Text = "?";
            this.ckPhu.UseSelectable = true;
            this.ckPhu.CheckStateChanged += new System.EventHandler(this.ckPhu_CheckStateChanged);
            // 
            // ckKep
            // 
            this.ckKep.AutoSize = true;
            this.ckKep.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceMon, "Kep", true));
            this.ckKep.Location = new System.Drawing.Point(580, 95);
            this.ckKep.Name = "ckKep";
            this.ckKep.Size = new System.Drawing.Size(28, 15);
            this.ckKep.TabIndex = 10;
            this.ckKep.Text = "?";
            this.ckKep.UseSelectable = true;
            this.ckKep.CheckStateChanged += new System.EventHandler(this.ckKep_CheckStateChanged);
            // 
            // txtSobuoi8
            // 
            // 
            // 
            // 
            this.txtSobuoi8.CustomButton.Image = null;
            this.txtSobuoi8.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtSobuoi8.CustomButton.Name = "";
            this.txtSobuoi8.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSobuoi8.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSobuoi8.CustomButton.TabIndex = 1;
            this.txtSobuoi8.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSobuoi8.CustomButton.UseSelectable = true;
            this.txtSobuoi8.CustomButton.Visible = false;
            this.txtSobuoi8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMon, "SoBuoiK8", true));
            this.txtSobuoi8.Lines = new string[0];
            this.txtSobuoi8.Location = new System.Drawing.Point(580, 206);
            this.txtSobuoi8.MaxLength = 32767;
            this.txtSobuoi8.Name = "txtSobuoi8";
            this.txtSobuoi8.PasswordChar = '\0';
            this.txtSobuoi8.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSobuoi8.SelectedText = "";
            this.txtSobuoi8.SelectionLength = 0;
            this.txtSobuoi8.SelectionStart = 0;
            this.txtSobuoi8.ShortcutsEnabled = true;
            this.txtSobuoi8.Size = new System.Drawing.Size(193, 23);
            this.txtSobuoi8.TabIndex = 11;
            this.txtSobuoi8.UseSelectable = true;
            this.txtSobuoi8.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSobuoi8.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSotiet8
            // 
            // 
            // 
            // 
            this.txtSotiet8.CustomButton.Image = null;
            this.txtSotiet8.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtSotiet8.CustomButton.Name = "";
            this.txtSotiet8.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSotiet8.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSotiet8.CustomButton.TabIndex = 1;
            this.txtSotiet8.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSotiet8.CustomButton.UseSelectable = true;
            this.txtSotiet8.CustomButton.Visible = false;
            this.txtSotiet8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMon, "SoTietK8", true));
            this.txtSotiet8.Lines = new string[0];
            this.txtSotiet8.Location = new System.Drawing.Point(175, 205);
            this.txtSotiet8.MaxLength = 32767;
            this.txtSotiet8.Name = "txtSotiet8";
            this.txtSotiet8.PasswordChar = '\0';
            this.txtSotiet8.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSotiet8.SelectedText = "";
            this.txtSotiet8.SelectionLength = 0;
            this.txtSotiet8.SelectionStart = 0;
            this.txtSotiet8.ShortcutsEnabled = true;
            this.txtSotiet8.Size = new System.Drawing.Size(193, 23);
            this.txtSotiet8.TabIndex = 10;
            this.txtSotiet8.UseSelectable = true;
            this.txtSotiet8.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSotiet8.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSobuoi9
            // 
            // 
            // 
            // 
            this.txtSobuoi9.CustomButton.Image = null;
            this.txtSobuoi9.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtSobuoi9.CustomButton.Name = "";
            this.txtSobuoi9.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSobuoi9.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSobuoi9.CustomButton.TabIndex = 1;
            this.txtSobuoi9.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSobuoi9.CustomButton.UseSelectable = true;
            this.txtSobuoi9.CustomButton.Visible = false;
            this.txtSobuoi9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMon, "SoBuoiK9", true));
            this.txtSobuoi9.Lines = new string[0];
            this.txtSobuoi9.Location = new System.Drawing.Point(580, 235);
            this.txtSobuoi9.MaxLength = 32767;
            this.txtSobuoi9.Name = "txtSobuoi9";
            this.txtSobuoi9.PasswordChar = '\0';
            this.txtSobuoi9.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSobuoi9.SelectedText = "";
            this.txtSobuoi9.SelectionLength = 0;
            this.txtSobuoi9.SelectionStart = 0;
            this.txtSobuoi9.ShortcutsEnabled = true;
            this.txtSobuoi9.Size = new System.Drawing.Size(193, 23);
            this.txtSobuoi9.TabIndex = 13;
            this.txtSobuoi9.UseSelectable = true;
            this.txtSobuoi9.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSobuoi9.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSotiet9
            // 
            // 
            // 
            // 
            this.txtSotiet9.CustomButton.Image = null;
            this.txtSotiet9.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtSotiet9.CustomButton.Name = "";
            this.txtSotiet9.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSotiet9.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSotiet9.CustomButton.TabIndex = 1;
            this.txtSotiet9.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSotiet9.CustomButton.UseSelectable = true;
            this.txtSotiet9.CustomButton.Visible = false;
            this.txtSotiet9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMon, "SoTietK9", true));
            this.txtSotiet9.Lines = new string[0];
            this.txtSotiet9.Location = new System.Drawing.Point(175, 234);
            this.txtSotiet9.MaxLength = 32767;
            this.txtSotiet9.Name = "txtSotiet9";
            this.txtSotiet9.PasswordChar = '\0';
            this.txtSotiet9.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSotiet9.SelectedText = "";
            this.txtSotiet9.SelectionLength = 0;
            this.txtSotiet9.SelectionStart = 0;
            this.txtSotiet9.ShortcutsEnabled = true;
            this.txtSotiet9.Size = new System.Drawing.Size(193, 23);
            this.txtSotiet9.TabIndex = 12;
            this.txtSotiet9.UseSelectable = true;
            this.txtSotiet9.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSotiet9.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSobuoi7
            // 
            // 
            // 
            // 
            this.txtSobuoi7.CustomButton.Image = null;
            this.txtSobuoi7.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtSobuoi7.CustomButton.Name = "";
            this.txtSobuoi7.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSobuoi7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSobuoi7.CustomButton.TabIndex = 1;
            this.txtSobuoi7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSobuoi7.CustomButton.UseSelectable = true;
            this.txtSobuoi7.CustomButton.Visible = false;
            this.txtSobuoi7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMon, "SoBuoiK7", true));
            this.txtSobuoi7.Lines = new string[0];
            this.txtSobuoi7.Location = new System.Drawing.Point(580, 177);
            this.txtSobuoi7.MaxLength = 32767;
            this.txtSobuoi7.Name = "txtSobuoi7";
            this.txtSobuoi7.PasswordChar = '\0';
            this.txtSobuoi7.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSobuoi7.SelectedText = "";
            this.txtSobuoi7.SelectionLength = 0;
            this.txtSobuoi7.SelectionStart = 0;
            this.txtSobuoi7.ShortcutsEnabled = true;
            this.txtSobuoi7.Size = new System.Drawing.Size(193, 23);
            this.txtSobuoi7.TabIndex = 9;
            this.txtSobuoi7.UseSelectable = true;
            this.txtSobuoi7.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSobuoi7.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSotiet7
            // 
            // 
            // 
            // 
            this.txtSotiet7.CustomButton.Image = null;
            this.txtSotiet7.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtSotiet7.CustomButton.Name = "";
            this.txtSotiet7.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSotiet7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSotiet7.CustomButton.TabIndex = 1;
            this.txtSotiet7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSotiet7.CustomButton.UseSelectable = true;
            this.txtSotiet7.CustomButton.Visible = false;
            this.txtSotiet7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMon, "SoTietK7", true));
            this.txtSotiet7.Lines = new string[0];
            this.txtSotiet7.Location = new System.Drawing.Point(175, 176);
            this.txtSotiet7.MaxLength = 32767;
            this.txtSotiet7.Name = "txtSotiet7";
            this.txtSotiet7.PasswordChar = '\0';
            this.txtSotiet7.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSotiet7.SelectedText = "";
            this.txtSotiet7.SelectionLength = 0;
            this.txtSotiet7.SelectionStart = 0;
            this.txtSotiet7.ShortcutsEnabled = true;
            this.txtSotiet7.Size = new System.Drawing.Size(193, 23);
            this.txtSotiet7.TabIndex = 8;
            this.txtSotiet7.UseSelectable = true;
            this.txtSotiet7.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSotiet7.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSobuoi6
            // 
            // 
            // 
            // 
            this.txtSobuoi6.CustomButton.Image = null;
            this.txtSobuoi6.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtSobuoi6.CustomButton.Name = "";
            this.txtSobuoi6.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSobuoi6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSobuoi6.CustomButton.TabIndex = 1;
            this.txtSobuoi6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSobuoi6.CustomButton.UseSelectable = true;
            this.txtSobuoi6.CustomButton.Visible = false;
            this.txtSobuoi6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMon, "SoBuoiK6", true));
            this.txtSobuoi6.Lines = new string[0];
            this.txtSobuoi6.Location = new System.Drawing.Point(580, 148);
            this.txtSobuoi6.MaxLength = 32767;
            this.txtSobuoi6.Name = "txtSobuoi6";
            this.txtSobuoi6.PasswordChar = '\0';
            this.txtSobuoi6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSobuoi6.SelectedText = "";
            this.txtSobuoi6.SelectionLength = 0;
            this.txtSobuoi6.SelectionStart = 0;
            this.txtSobuoi6.ShortcutsEnabled = true;
            this.txtSobuoi6.Size = new System.Drawing.Size(193, 23);
            this.txtSobuoi6.TabIndex = 7;
            this.txtSobuoi6.UseSelectable = true;
            this.txtSobuoi6.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSobuoi6.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSotiet6
            // 
            // 
            // 
            // 
            this.txtSotiet6.CustomButton.Image = null;
            this.txtSotiet6.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtSotiet6.CustomButton.Name = "";
            this.txtSotiet6.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSotiet6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSotiet6.CustomButton.TabIndex = 1;
            this.txtSotiet6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSotiet6.CustomButton.UseSelectable = true;
            this.txtSotiet6.CustomButton.Visible = false;
            this.txtSotiet6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMon, "SoTietK6", true));
            this.txtSotiet6.Lines = new string[0];
            this.txtSotiet6.Location = new System.Drawing.Point(175, 147);
            this.txtSotiet6.MaxLength = 32767;
            this.txtSotiet6.Name = "txtSotiet6";
            this.txtSotiet6.PasswordChar = '\0';
            this.txtSotiet6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSotiet6.SelectedText = "";
            this.txtSotiet6.SelectionLength = 0;
            this.txtSotiet6.SelectionStart = 0;
            this.txtSotiet6.ShortcutsEnabled = true;
            this.txtSotiet6.Size = new System.Drawing.Size(193, 23);
            this.txtSotiet6.TabIndex = 6;
            this.txtSotiet6.UseSelectable = true;
            this.txtSotiet6.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSotiet6.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(448, 209);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(126, 19);
            this.metroLabel11.TabIndex = 26;
            this.metroLabel11.Text = "Số buổi/tuần khối 8:";
            // 
            // txtTenmh
            // 
            // 
            // 
            // 
            this.txtTenmh.CustomButton.Image = null;
            this.txtTenmh.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtTenmh.CustomButton.Name = "";
            this.txtTenmh.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTenmh.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenmh.CustomButton.TabIndex = 1;
            this.txtTenmh.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenmh.CustomButton.UseSelectable = true;
            this.txtTenmh.CustomButton.Visible = false;
            this.txtTenmh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMon, "Ten", true));
            this.txtTenmh.Lines = new string[0];
            this.txtTenmh.Location = new System.Drawing.Point(175, 91);
            this.txtTenmh.MaxLength = 32767;
            this.txtTenmh.Name = "txtTenmh";
            this.txtTenmh.PasswordChar = '\0';
            this.txtTenmh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenmh.SelectedText = "";
            this.txtTenmh.SelectionLength = 0;
            this.txtTenmh.SelectionStart = 0;
            this.txtTenmh.ShortcutsEnabled = true;
            this.txtTenmh.Size = new System.Drawing.Size(193, 23);
            this.txtTenmh.TabIndex = 1;
            this.txtTenmh.UseSelectable = true;
            this.txtTenmh.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenmh.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(63, 208);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(88, 19);
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "Số tiết khối 8:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(448, 238);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(126, 19);
            this.metroLabel10.TabIndex = 27;
            this.metroLabel10.Text = "Số buổi/tuần khối 9:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(448, 180);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(126, 19);
            this.metroLabel9.TabIndex = 25;
            this.metroLabel9.Text = "Số buổi/tuần khối 7:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(63, 237);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(88, 19);
            this.metroLabel7.TabIndex = 21;
            this.metroLabel7.Text = "Số tiết khối 9:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(63, 179);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Số tiết khối 7:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(448, 151);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(126, 19);
            this.metroLabel8.TabIndex = 24;
            this.metroLabel8.Text = "Số buổi/tuần khối 6:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(63, 126);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Khối học:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(63, 150);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Số tiết khối 6:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(448, 122);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(59, 19);
            this.metroLabel12.TabIndex = 23;
            this.metroLabel12.Text = "Tiết phụ:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(448, 91);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 19);
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "Tiết kép:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(63, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Tên môn học:";
            // 
            // fMon
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 326);
            this.Controls.Add(this.ck7);
            this.Controls.Add(this.ck8);
            this.Controls.Add(this.ck6);
            this.Controls.Add(this.ck9);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.ckPhu);
            this.Controls.Add(this.ckKep);
            this.Controls.Add(this.txtSobuoi8);
            this.Controls.Add(this.txtSotiet8);
            this.Controls.Add(this.txtSobuoi9);
            this.Controls.Add(this.txtSotiet9);
            this.Controls.Add(this.txtSobuoi7);
            this.Controls.Add(this.txtSotiet7);
            this.Controls.Add(this.txtSobuoi6);
            this.Controls.Add(this.txtSotiet6);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.txtTenmh);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fMon";
            this.Resizable = false;
            this.Text = "Cập nhật môn học";
            this.Load += new System.EventHandler(this.fMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox ck7;
        private MetroFramework.Controls.MetroCheckBox ck8;
        private MetroFramework.Controls.MetroCheckBox ck6;
        private MetroFramework.Controls.MetroCheckBox ck9;
        private MetroFramework.Controls.MetroButton btnLuu;
        private MetroFramework.Controls.MetroCheckBox ckPhu;
        private MetroFramework.Controls.MetroCheckBox ckKep;
        private MetroFramework.Controls.MetroTextBox txtSobuoi8;
        private MetroFramework.Controls.MetroTextBox txtSotiet8;
        private MetroFramework.Controls.MetroTextBox txtSobuoi9;
        private MetroFramework.Controls.MetroTextBox txtSotiet9;
        private MetroFramework.Controls.MetroTextBox txtSobuoi7;
        private MetroFramework.Controls.MetroTextBox txtSotiet7;
        private MetroFramework.Controls.MetroTextBox txtSobuoi6;
        private MetroFramework.Controls.MetroTextBox txtSotiet6;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtTenmh;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.BindingSource bindingSourceMon;
    }
}