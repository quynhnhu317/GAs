namespace TKB_THCS
{
    partial class uNguoidung
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dataNguoidung = new MetroFramework.Controls.MetroGrid();
            this.mtHuy = new MetroFramework.Controls.MetroTile();
            this.mtLuu = new MetroFramework.Controls.MetroTile();
            this.mtXoa = new MetroFramework.Controls.MetroTile();
            this.mtSua = new MetroFramework.Controls.MetroTile();
            this.mtThem = new MetroFramework.Controls.MetroTile();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyenTruyCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataNguoidung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quyenTruyCapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Maroon;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroLabel5.Location = new System.Drawing.Point(302, 21);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(166, 25);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Quản lý người dùng";
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // dataNguoidung
            // 
            this.dataNguoidung.AllowUserToResizeRows = false;
            this.dataNguoidung.AutoGenerateColumns = false;
            this.dataNguoidung.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataNguoidung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataNguoidung.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataNguoidung.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataNguoidung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataNguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNguoidung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.iDDataGridViewTextBoxColumn,
            this.tenDNDataGridViewTextBoxColumn,
            this.matKhauDataGridViewTextBoxColumn,
            this.quyenDataGridViewTextBoxColumn});
            this.dataNguoidung.DataSource = this.quyenTruyCapBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataNguoidung.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataNguoidung.EnableHeadersVisualStyles = false;
            this.dataNguoidung.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataNguoidung.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataNguoidung.Location = new System.Drawing.Point(30, 53);
            this.dataNguoidung.Name = "dataNguoidung";
            this.dataNguoidung.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataNguoidung.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataNguoidung.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataNguoidung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataNguoidung.Size = new System.Drawing.Size(745, 290);
            this.dataNguoidung.TabIndex = 20;
            this.dataNguoidung.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataNguoidung_RowPrePaint);
            // 
            // mtHuy
            // 
            this.mtHuy.ActiveControl = null;
            this.mtHuy.Location = new System.Drawing.Point(630, 349);
            this.mtHuy.Name = "mtHuy";
            this.mtHuy.Size = new System.Drawing.Size(145, 81);
            this.mtHuy.TabIndex = 22;
            this.mtHuy.Text = "Hủy";
            this.mtHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtHuy.TileImage = global::TKB_THCS.Properties.Resources.Reload_icon;
            this.mtHuy.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtHuy.UseSelectable = true;
            this.mtHuy.UseTileImage = true;
            this.mtHuy.Click += new System.EventHandler(this.mtHuy_Click);
            // 
            // mtLuu
            // 
            this.mtLuu.ActiveControl = null;
            this.mtLuu.Location = new System.Drawing.Point(480, 349);
            this.mtLuu.Name = "mtLuu";
            this.mtLuu.Size = new System.Drawing.Size(145, 81);
            this.mtLuu.TabIndex = 23;
            this.mtLuu.Text = "Lưu";
            this.mtLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtLuu.TileImage = global::TKB_THCS.Properties.Resources.Actions_document_save_all_icon;
            this.mtLuu.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtLuu.UseSelectable = true;
            this.mtLuu.UseTileImage = true;
            this.mtLuu.Click += new System.EventHandler(this.mtLuu_Click);
            // 
            // mtXoa
            // 
            this.mtXoa.ActiveControl = null;
            this.mtXoa.Location = new System.Drawing.Point(330, 349);
            this.mtXoa.Name = "mtXoa";
            this.mtXoa.Size = new System.Drawing.Size(145, 81);
            this.mtXoa.TabIndex = 24;
            this.mtXoa.Text = "Xóa";
            this.mtXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtXoa.TileImage = global::TKB_THCS.Properties.Resources.delete_icon;
            this.mtXoa.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtXoa.UseSelectable = true;
            this.mtXoa.UseTileImage = true;
            this.mtXoa.Click += new System.EventHandler(this.mtXoa_Click);
            // 
            // mtSua
            // 
            this.mtSua.ActiveControl = null;
            this.mtSua.Location = new System.Drawing.Point(180, 349);
            this.mtSua.Name = "mtSua";
            this.mtSua.Size = new System.Drawing.Size(145, 81);
            this.mtSua.TabIndex = 25;
            this.mtSua.Text = "Sửa";
            this.mtSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtSua.TileImage = global::TKB_THCS.Properties.Resources.edit_validated_icon;
            this.mtSua.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSua.UseSelectable = true;
            this.mtSua.UseTileImage = true;
            this.mtSua.Click += new System.EventHandler(this.mtSua_Click);
            // 
            // mtThem
            // 
            this.mtThem.ActiveControl = null;
            this.mtThem.Location = new System.Drawing.Point(30, 349);
            this.mtThem.Name = "mtThem";
            this.mtThem.Size = new System.Drawing.Size(145, 81);
            this.mtThem.TabIndex = 26;
            this.mtThem.Text = "Thêm";
            this.mtThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtThem.TileImage = global::TKB_THCS.Properties.Resources.add_icon;
            this.mtThem.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtThem.UseSelectable = true;
            this.mtThem.UseTileImage = true;
            this.mtThem.Click += new System.EventHandler(this.mtThem_Click);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Mã người dùng";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // tenDNDataGridViewTextBoxColumn
            // 
            this.tenDNDataGridViewTextBoxColumn.DataPropertyName = "TenDN";
            this.tenDNDataGridViewTextBoxColumn.HeaderText = "Tên đăng nhập";
            this.tenDNDataGridViewTextBoxColumn.Name = "tenDNDataGridViewTextBoxColumn";
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.HeaderText = "Mật khẩu";
            this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            // 
            // quyenDataGridViewTextBoxColumn
            // 
            this.quyenDataGridViewTextBoxColumn.DataPropertyName = "Quyen";
            this.quyenDataGridViewTextBoxColumn.HeaderText = "Quyền truy cập";
            this.quyenDataGridViewTextBoxColumn.Name = "quyenDataGridViewTextBoxColumn";
            // 
            // quyenTruyCapBindingSource
            // 
            this.quyenTruyCapBindingSource.DataSource = typeof(TKB_THCS.QuyenTruyCap);
            // 
            // uNguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtHuy);
            this.Controls.Add(this.mtLuu);
            this.Controls.Add(this.mtXoa);
            this.Controls.Add(this.mtSua);
            this.Controls.Add(this.mtThem);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.dataNguoidung);
            this.Name = "uNguoidung";
            this.Size = new System.Drawing.Size(790, 450);
            this.Load += new System.EventHandler(this.uNguoidung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataNguoidung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quyenTruyCapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtHuy;
        private MetroFramework.Controls.MetroTile mtLuu;
        private MetroFramework.Controls.MetroTile mtXoa;
        private MetroFramework.Controls.MetroTile mtSua;
        private MetroFramework.Controls.MetroTile mtThem;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroGrid dataNguoidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource quyenTruyCapBindingSource;
    }
}
