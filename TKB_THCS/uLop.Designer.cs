namespace TKB_THCS
{
    partial class uLop
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
            this.dataLophoc = new MetroFramework.Controls.MetroGrid();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDGVDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.giaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDPHDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.phongHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.namDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buoiHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtHuy = new MetroFramework.Controls.MetroTile();
            this.mtLuu = new MetroFramework.Controls.MetroTile();
            this.mtXoa = new MetroFramework.Controls.MetroTile();
            this.mtSua = new MetroFramework.Controls.MetroTile();
            this.mtThem = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dataLophoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Maroon;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroLabel5.Location = new System.Drawing.Point(304, 21);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(128, 25);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Dữ liệu lớp học";
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // dataLophoc
            // 
            this.dataLophoc.AllowUserToResizeRows = false;
            this.dataLophoc.AutoGenerateColumns = false;
            this.dataLophoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataLophoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataLophoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataLophoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLophoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataLophoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLophoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.iDLopDataGridViewTextBoxColumn,
            this.tenLopDataGridViewTextBoxColumn,
            this.iDGVDataGridViewComboBoxColumn,
            this.iDPHDataGridViewComboBoxColumn,
            this.namDataGridViewTextBoxColumn,
            this.khoiDataGridViewTextBoxColumn,
            this.siSoDataGridViewTextBoxColumn,
            this.buoiHocDataGridViewTextBoxColumn});
            this.dataLophoc.DataSource = this.lopHocBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataLophoc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataLophoc.EnableHeadersVisualStyles = false;
            this.dataLophoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataLophoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataLophoc.Location = new System.Drawing.Point(25, 53);
            this.dataLophoc.Name = "dataLophoc";
            this.dataLophoc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLophoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataLophoc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataLophoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLophoc.Size = new System.Drawing.Size(745, 290);
            this.dataLophoc.TabIndex = 12;
            this.dataLophoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLophoc_CellContentClick);
            this.dataLophoc.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataLophoc_RowPrePaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // iDLopDataGridViewTextBoxColumn
            // 
            this.iDLopDataGridViewTextBoxColumn.DataPropertyName = "IDLop";
            this.iDLopDataGridViewTextBoxColumn.HeaderText = "Mã lớp";
            this.iDLopDataGridViewTextBoxColumn.Name = "iDLopDataGridViewTextBoxColumn";
            // 
            // tenLopDataGridViewTextBoxColumn
            // 
            this.tenLopDataGridViewTextBoxColumn.DataPropertyName = "TenLop";
            this.tenLopDataGridViewTextBoxColumn.HeaderText = "Tên lớp";
            this.tenLopDataGridViewTextBoxColumn.Name = "tenLopDataGridViewTextBoxColumn";
            // 
            // iDGVDataGridViewComboBoxColumn
            // 
            this.iDGVDataGridViewComboBoxColumn.DataPropertyName = "IDGV";
            this.iDGVDataGridViewComboBoxColumn.DataSource = this.giaoVienBindingSource;
            this.iDGVDataGridViewComboBoxColumn.DisplayMember = "TenGV";
            this.iDGVDataGridViewComboBoxColumn.HeaderText = "Giáo viên chủ nhiệm";
            this.iDGVDataGridViewComboBoxColumn.Name = "iDGVDataGridViewComboBoxColumn";
            this.iDGVDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDGVDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDGVDataGridViewComboBoxColumn.ValueMember = "IDGV";
            // 
            // giaoVienBindingSource
            // 
            this.giaoVienBindingSource.DataSource = typeof(TKB_THCS.GiaoVien);
            // 
            // iDPHDataGridViewComboBoxColumn
            // 
            this.iDPHDataGridViewComboBoxColumn.DataPropertyName = "IDPH";
            this.iDPHDataGridViewComboBoxColumn.DataSource = this.phongHocBindingSource;
            this.iDPHDataGridViewComboBoxColumn.DisplayMember = "TenPH";
            this.iDPHDataGridViewComboBoxColumn.HeaderText = "Phòng";
            this.iDPHDataGridViewComboBoxColumn.Name = "iDPHDataGridViewComboBoxColumn";
            this.iDPHDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDPHDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDPHDataGridViewComboBoxColumn.ValueMember = "IDPH";
            // 
            // phongHocBindingSource
            // 
            this.phongHocBindingSource.DataSource = typeof(TKB_THCS.PhongHoc);
            // 
            // namDataGridViewTextBoxColumn
            // 
            this.namDataGridViewTextBoxColumn.DataPropertyName = "Nam";
            this.namDataGridViewTextBoxColumn.HeaderText = "Năm học";
            this.namDataGridViewTextBoxColumn.Name = "namDataGridViewTextBoxColumn";
            // 
            // khoiDataGridViewTextBoxColumn
            // 
            this.khoiDataGridViewTextBoxColumn.DataPropertyName = "Khoi";
            this.khoiDataGridViewTextBoxColumn.HeaderText = "Khối";
            this.khoiDataGridViewTextBoxColumn.Name = "khoiDataGridViewTextBoxColumn";
            // 
            // siSoDataGridViewTextBoxColumn
            // 
            this.siSoDataGridViewTextBoxColumn.DataPropertyName = "SiSo";
            this.siSoDataGridViewTextBoxColumn.HeaderText = "Sỉ số";
            this.siSoDataGridViewTextBoxColumn.Name = "siSoDataGridViewTextBoxColumn";
            // 
            // buoiHocDataGridViewTextBoxColumn
            // 
            this.buoiHocDataGridViewTextBoxColumn.DataPropertyName = "BuoiHoc";
            this.buoiHocDataGridViewTextBoxColumn.HeaderText = "Buổi học";
            this.buoiHocDataGridViewTextBoxColumn.Name = "buoiHocDataGridViewTextBoxColumn";
            // 
            // lopHocBindingSource
            // 
            this.lopHocBindingSource.DataSource = typeof(TKB_THCS.LopHoc);
            // 
            // mtHuy
            // 
            this.mtHuy.ActiveControl = null;
            this.mtHuy.Location = new System.Drawing.Point(625, 349);
            this.mtHuy.Name = "mtHuy";
            this.mtHuy.Size = new System.Drawing.Size(145, 81);
            this.mtHuy.TabIndex = 15;
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
            this.mtLuu.Location = new System.Drawing.Point(475, 349);
            this.mtLuu.Name = "mtLuu";
            this.mtLuu.Size = new System.Drawing.Size(145, 81);
            this.mtLuu.TabIndex = 16;
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
            this.mtXoa.Location = new System.Drawing.Point(325, 349);
            this.mtXoa.Name = "mtXoa";
            this.mtXoa.Size = new System.Drawing.Size(145, 81);
            this.mtXoa.TabIndex = 17;
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
            this.mtSua.Location = new System.Drawing.Point(175, 349);
            this.mtSua.Name = "mtSua";
            this.mtSua.Size = new System.Drawing.Size(145, 81);
            this.mtSua.TabIndex = 18;
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
            this.mtThem.Location = new System.Drawing.Point(25, 349);
            this.mtThem.Name = "mtThem";
            this.mtThem.Size = new System.Drawing.Size(145, 81);
            this.mtThem.TabIndex = 19;
            this.mtThem.Text = "Thêm";
            this.mtThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtThem.TileImage = global::TKB_THCS.Properties.Resources.add_icon;
            this.mtThem.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtThem.UseSelectable = true;
            this.mtThem.UseTileImage = true;
            this.mtThem.Click += new System.EventHandler(this.mtThem_Click);
            // 
            // uLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtHuy);
            this.Controls.Add(this.mtLuu);
            this.Controls.Add(this.mtXoa);
            this.Controls.Add(this.mtSua);
            this.Controls.Add(this.mtThem);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.dataLophoc);
            this.Name = "uLop";
            this.Size = new System.Drawing.Size(790, 450);
            this.Load += new System.EventHandler(this.uLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLophoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroGrid dataLophoc;
        private MetroFramework.Controls.MetroTile mtHuy;
        private MetroFramework.Controls.MetroTile mtLuu;
        private MetroFramework.Controls.MetroTile mtXoa;
        private MetroFramework.Controls.MetroTile mtSua;
        private MetroFramework.Controls.MetroTile mtThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDGVDataGridViewComboBoxColumn;
        private System.Windows.Forms.BindingSource giaoVienBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDPHDataGridViewComboBoxColumn;
        private System.Windows.Forms.BindingSource phongHocBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn namDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buoiHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lopHocBindingSource;
    }
}
