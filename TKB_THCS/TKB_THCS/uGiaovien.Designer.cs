namespace TKB_THCS
{
    partial class uGiaovien
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
            this.mtHuy = new MetroFramework.Controls.MetroTile();
            this.mtLuu = new MetroFramework.Controls.MetroTile();
            this.mtXoa = new MetroFramework.Controls.MetroTile();
            this.mtSua = new MetroFramework.Controls.MetroTile();
            this.mtThem = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dataGV = new MetroFramework.Controls.MetroGrid();
            this.giaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMonDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.chuyenKhoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namSinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.soTietDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mtHuy
            // 
            this.mtHuy.ActiveControl = null;
            this.mtHuy.Location = new System.Drawing.Point(623, 349);
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
            this.mtLuu.Location = new System.Drawing.Point(473, 349);
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
            this.mtXoa.Location = new System.Drawing.Point(323, 349);
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
            this.mtSua.Location = new System.Drawing.Point(173, 349);
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
            this.mtThem.Location = new System.Drawing.Point(23, 349);
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
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Maroon;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroLabel5.Location = new System.Drawing.Point(302, 21);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(140, 25);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Dữ liệu giáo viên";
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // dataGV
            // 
            this.dataGV.AllowUserToResizeRows = false;
            this.dataGV.AutoGenerateColumns = false;
            this.dataGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.iDGVDataGridViewTextBoxColumn,
            this.tenGVDataGridViewTextBoxColumn,
            this.iDMonDataGridViewComboBoxColumn,
            this.chuyenKhoiDataGridViewTextBoxColumn,
            this.namSinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewCheckBoxColumn,
            this.soTietDataGridViewTextBoxColumn,
            this.soDTDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGV.DataSource = this.giaoVienBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGV.EnableHeadersVisualStyles = false;
            this.dataGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGV.Location = new System.Drawing.Point(23, 53);
            this.dataGV.Name = "dataGV";
            this.dataGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV.Size = new System.Drawing.Size(745, 290);
            this.dataGV.TabIndex = 20;
            this.dataGV.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGV_RowPrePaint);
            // 
            // giaoVienBindingSource
            // 
            this.giaoVienBindingSource.DataSource = typeof(TKB_THCS.GiaoVien);
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataSource = typeof(TKB_THCS.MonHoc);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // iDGVDataGridViewTextBoxColumn
            // 
            this.iDGVDataGridViewTextBoxColumn.DataPropertyName = "IDGV";
            this.iDGVDataGridViewTextBoxColumn.HeaderText = "Mã giáo viên";
            this.iDGVDataGridViewTextBoxColumn.Name = "iDGVDataGridViewTextBoxColumn";
            // 
            // tenGVDataGridViewTextBoxColumn
            // 
            this.tenGVDataGridViewTextBoxColumn.DataPropertyName = "TenGV";
            this.tenGVDataGridViewTextBoxColumn.HeaderText = "Tên giáo viên";
            this.tenGVDataGridViewTextBoxColumn.Name = "tenGVDataGridViewTextBoxColumn";
            // 
            // iDMonDataGridViewComboBoxColumn
            // 
            this.iDMonDataGridViewComboBoxColumn.DataPropertyName = "IDMon";
            this.iDMonDataGridViewComboBoxColumn.DataSource = this.monHocBindingSource;
            this.iDMonDataGridViewComboBoxColumn.DisplayMember = "Ten";
            this.iDMonDataGridViewComboBoxColumn.HeaderText = "Môn";
            this.iDMonDataGridViewComboBoxColumn.Name = "iDMonDataGridViewComboBoxColumn";
            this.iDMonDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDMonDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDMonDataGridViewComboBoxColumn.ValueMember = "IDMon";
            // 
            // chuyenKhoiDataGridViewTextBoxColumn
            // 
            this.chuyenKhoiDataGridViewTextBoxColumn.DataPropertyName = "ChuyenKhoi";
            this.chuyenKhoiDataGridViewTextBoxColumn.HeaderText = "Chuyên khối";
            this.chuyenKhoiDataGridViewTextBoxColumn.Name = "chuyenKhoiDataGridViewTextBoxColumn";
            // 
            // namSinhDataGridViewTextBoxColumn
            // 
            this.namSinhDataGridViewTextBoxColumn.DataPropertyName = "NamSinh";
            this.namSinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.namSinhDataGridViewTextBoxColumn.Name = "namSinhDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewCheckBoxColumn
            // 
            this.gioiTinhDataGridViewCheckBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewCheckBoxColumn.HeaderText = "Nam";
            this.gioiTinhDataGridViewCheckBoxColumn.Name = "gioiTinhDataGridViewCheckBoxColumn";
            this.gioiTinhDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gioiTinhDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // soTietDataGridViewTextBoxColumn
            // 
            this.soTietDataGridViewTextBoxColumn.DataPropertyName = "SoTiet";
            this.soTietDataGridViewTextBoxColumn.HeaderText = "Số tiết";
            this.soTietDataGridViewTextBoxColumn.Name = "soTietDataGridViewTextBoxColumn";
            // 
            // soDTDataGridViewTextBoxColumn
            // 
            this.soDTDataGridViewTextBoxColumn.DataPropertyName = "SoDT";
            this.soDTDataGridViewTextBoxColumn.HeaderText = "Điện thoại";
            this.soDTDataGridViewTextBoxColumn.Name = "soDTDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // uGiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtHuy);
            this.Controls.Add(this.mtLuu);
            this.Controls.Add(this.mtXoa);
            this.Controls.Add(this.mtSua);
            this.Controls.Add(this.mtThem);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.dataGV);
            this.Name = "uGiaovien";
            this.Size = new System.Drawing.Size(790, 450);
            this.Load += new System.EventHandler(this.uGiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
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
        private MetroFramework.Controls.MetroGrid dataGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDMonDataGridViewComboBoxColumn;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuyenKhoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namSinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gioiTinhDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTietDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource giaoVienBindingSource;
    }
}
