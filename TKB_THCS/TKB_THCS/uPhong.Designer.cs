namespace TKB_THCS
{
    partial class uPhong
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
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dataPhong = new MetroFramework.Controls.MetroGrid();
            this.mtLuu = new MetroFramework.Controls.MetroTile();
            this.mtXoa = new MetroFramework.Controls.MetroTile();
            this.mtSua = new MetroFramework.Controls.MetroTile();
            this.mtThem = new MetroFramework.Controls.MetroTile();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucChuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viTriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mtHuy
            // 
            this.mtHuy.ActiveControl = null;
            this.mtHuy.Location = new System.Drawing.Point(628, 351);
            this.mtHuy.Name = "mtHuy";
            this.mtHuy.Size = new System.Drawing.Size(145, 81);
            this.mtHuy.TabIndex = 10;
            this.mtHuy.Text = "Hủy";
            this.mtHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtHuy.TileImage = global::TKB_THCS.Properties.Resources.Reload_icon;
            this.mtHuy.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtHuy.UseSelectable = true;
            this.mtHuy.UseTileImage = true;
            this.mtHuy.Click += new System.EventHandler(this.mtHuy_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Maroon;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroLabel5.Location = new System.Drawing.Point(309, 18);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(154, 25);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Dữ liệu phòng học";
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // dataPhong
            // 
            this.dataPhong.AllowUserToResizeRows = false;
            this.dataPhong.AutoGenerateColumns = false;
            this.dataPhong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPhong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataPhong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.iDPHDataGridViewTextBoxColumn,
            this.tenPHDataGridViewTextBoxColumn,
            this.sucChuaDataGridViewTextBoxColumn,
            this.viTriDataGridViewTextBoxColumn});
            this.dataPhong.DataSource = this.phongHocBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPhong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataPhong.EnableHeadersVisualStyles = false;
            this.dataPhong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataPhong.Location = new System.Drawing.Point(28, 55);
            this.dataPhong.Name = "dataPhong";
            this.dataPhong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPhong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataPhong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPhong.Size = new System.Drawing.Size(745, 290);
            this.dataPhong.TabIndex = 8;
            this.dataPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPhong_CellContentClick);
            this.dataPhong.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataPhong_RowPrePaint);
            // 
            // mtLuu
            // 
            this.mtLuu.ActiveControl = null;
            this.mtLuu.Location = new System.Drawing.Point(478, 351);
            this.mtLuu.Name = "mtLuu";
            this.mtLuu.Size = new System.Drawing.Size(145, 81);
            this.mtLuu.TabIndex = 11;
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
            this.mtXoa.Location = new System.Drawing.Point(328, 351);
            this.mtXoa.Name = "mtXoa";
            this.mtXoa.Size = new System.Drawing.Size(145, 81);
            this.mtXoa.TabIndex = 12;
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
            this.mtSua.Location = new System.Drawing.Point(178, 351);
            this.mtSua.Name = "mtSua";
            this.mtSua.Size = new System.Drawing.Size(145, 81);
            this.mtSua.TabIndex = 13;
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
            this.mtThem.Location = new System.Drawing.Point(28, 351);
            this.mtThem.Name = "mtThem";
            this.mtThem.Size = new System.Drawing.Size(145, 81);
            this.mtThem.TabIndex = 14;
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
            this.STT.Width = 50;
            // 
            // iDPHDataGridViewTextBoxColumn
            // 
            this.iDPHDataGridViewTextBoxColumn.DataPropertyName = "IDPH";
            this.iDPHDataGridViewTextBoxColumn.HeaderText = "Mã phòng";
            this.iDPHDataGridViewTextBoxColumn.Name = "iDPHDataGridViewTextBoxColumn";
            this.iDPHDataGridViewTextBoxColumn.Width = 50;
            // 
            // tenPHDataGridViewTextBoxColumn
            // 
            this.tenPHDataGridViewTextBoxColumn.DataPropertyName = "TenPH";
            this.tenPHDataGridViewTextBoxColumn.HeaderText = "Tên phòng";
            this.tenPHDataGridViewTextBoxColumn.Name = "tenPHDataGridViewTextBoxColumn";
            this.tenPHDataGridViewTextBoxColumn.Width = 175;
            // 
            // sucChuaDataGridViewTextBoxColumn
            // 
            this.sucChuaDataGridViewTextBoxColumn.DataPropertyName = "SucChua";
            this.sucChuaDataGridViewTextBoxColumn.HeaderText = "Sức chứa";
            this.sucChuaDataGridViewTextBoxColumn.Name = "sucChuaDataGridViewTextBoxColumn";
            this.sucChuaDataGridViewTextBoxColumn.Width = 50;
            // 
            // viTriDataGridViewTextBoxColumn
            // 
            this.viTriDataGridViewTextBoxColumn.DataPropertyName = "ViTri";
            this.viTriDataGridViewTextBoxColumn.HeaderText = "Vị trí";
            this.viTriDataGridViewTextBoxColumn.Name = "viTriDataGridViewTextBoxColumn";
            this.viTriDataGridViewTextBoxColumn.Width = 175;
            // 
            // phongHocBindingSource
            // 
            this.phongHocBindingSource.DataSource = typeof(TKB_THCS.PhongHoc);
            // 
            // uPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtHuy);
            this.Controls.Add(this.mtLuu);
            this.Controls.Add(this.mtXoa);
            this.Controls.Add(this.mtSua);
            this.Controls.Add(this.mtThem);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.dataPhong);
            this.Name = "uPhong";
            this.Size = new System.Drawing.Size(790, 450);
            this.Load += new System.EventHandler(this.uPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongHocBindingSource)).EndInit();
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
        private MetroFramework.Controls.MetroGrid dataPhong;
        private System.Windows.Forms.BindingSource phongHocBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucChuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viTriDataGridViewTextBoxColumn;
    }
}
