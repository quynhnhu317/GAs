namespace TKB_THCS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mdiTabStrip1 = new MdiTabStrip.MdiTabStrip();
            this.rbtnPhanLich = new DevComponents.DotNetBar.ButtonX();
            this.btnLichGV = new MetroFramework.Controls.MetroButton();
            this.btnTKB = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.mdiTabStrip1)).BeginInit();
            this.SuspendLayout();
            // 
            // mdiTabStrip1
            // 
            this.mdiTabStrip1.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdiTabStrip1.AllowDrop = true;
            this.mdiTabStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.mdiTabStrip1.InactiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdiTabStrip1.Location = new System.Drawing.Point(20, 60);
            this.mdiTabStrip1.MdiNewTabImage = null;
            this.mdiTabStrip1.MinimumSize = new System.Drawing.Size(50, 33);
            this.mdiTabStrip1.MouseOverTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdiTabStrip1.Name = "mdiTabStrip1";
            this.mdiTabStrip1.NewTabToolTipText = "New Tab";
            this.mdiTabStrip1.Padding = new System.Windows.Forms.Padding(5, 3, 20, 5);
            this.mdiTabStrip1.Size = new System.Drawing.Size(1000, 35);
            this.mdiTabStrip1.TabIndex = 1;
            this.mdiTabStrip1.Text = "mdiTabStrip1";
            // 
            // rbtnPhanLich
            // 
            this.rbtnPhanLich.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.rbtnPhanLich.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.rbtnPhanLich.Location = new System.Drawing.Point(222, 26);
            this.rbtnPhanLich.Name = "rbtnPhanLich";
            this.rbtnPhanLich.Size = new System.Drawing.Size(96, 25);
            this.rbtnPhanLich.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbtnPhanLich.TabIndex = 24;
            this.rbtnPhanLich.Text = "Tại đây";
            this.rbtnPhanLich.Click += new System.EventHandler(this.rbtnPhanLich_Click);
            // 
            // btnLichGV
            // 
            this.btnLichGV.Location = new System.Drawing.Point(861, 26);
            this.btnLichGV.Name = "btnLichGV";
            this.btnLichGV.Size = new System.Drawing.Size(156, 23);
            this.btnLichGV.TabIndex = 26;
            this.btnLichGV.Text = "Xem lịch dạy của giáo viên";
            this.btnLichGV.UseSelectable = true;
            this.btnLichGV.Click += new System.EventHandler(this.btnLichGV_Click);
            // 
            // btnTKB
            // 
            this.btnTKB.Location = new System.Drawing.Point(699, 26);
            this.btnTKB.Name = "btnTKB";
            this.btnTKB.Size = new System.Drawing.Size(156, 23);
            this.btnTKB.TabIndex = 28;
            this.btnTKB.Text = "Xem thời khóa biểu";
            this.btnTKB.UseSelectable = true;
            this.btnTKB.Click += new System.EventHandler(this.btnTKB_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 700);
            this.Controls.Add(this.btnTKB);
            this.Controls.Add(this.btnLichGV);
            this.Controls.Add(this.rbtnPhanLich);
            this.Controls.Add(this.mdiTabStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Resizable = false;
            this.Text = "Lập thời khóa biểu:";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mdiTabStrip1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MdiTabStrip.MdiTabStrip mdiTabStrip1;
        private DevComponents.DotNetBar.ButtonX rbtnPhanLich;
        private MetroFramework.Controls.MetroButton btnLichGV;
        private MetroFramework.Controls.MetroButton btnTKB;
    }
}