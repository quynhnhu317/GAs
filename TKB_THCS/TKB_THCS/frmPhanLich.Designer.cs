namespace TKB_THCS
{
    partial class frmPhanLich
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
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation textAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation textAnnotation2 = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanLich));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTime = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnTienHoa = new MetroFramework.Controls.MetroTile();
            this.btnTienHoa100 = new MetroFramework.Controls.MetroTile();
            this.btnTienHoaAll = new MetroFramework.Controls.MetroTile();
            this.btnStop = new MetroFramework.Controls.MetroTile();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnTKB = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.chart1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 15;
            this.metroPanel1.Location = new System.Drawing.Point(64, 83);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(918, 529);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 15;
            // 
            // chart1
            // 
            textAnnotation1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textAnnotation1.IsSizeAlwaysRelative = false;
            textAnnotation1.Name = "TextAnnotation2";
            textAnnotation1.Text = "Độ thích nghi (%)";
            textAnnotation1.X = 4D;
            textAnnotation1.Y = 4D;
            textAnnotation2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textAnnotation2.Name = "TextAnnotation1";
            textAnnotation2.Text = "Thế hệ";
            textAnnotation2.X = 90D;
            textAnnotation2.Y = 94D;
            this.chart1.Annotations.Add(textAnnotation1);
            this.chart1.Annotations.Add(textAnnotation2);
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "Độ thích nghi";
            series1.YValuesPerPoint = 3;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(918, 529);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Độ thích nghi của Nhiễm sắc thể";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(662, 617);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(81, 37);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "0:00";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(534, 658);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(342, 25);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Value = 50;
            this.progressBar1.Visible = false;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btnTienHoa
            // 
            this.btnTienHoa.ActiveControl = null;
            this.btnTienHoa.Location = new System.Drawing.Point(411, 692);
            this.btnTienHoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTienHoa.Name = "btnTienHoa";
            this.btnTienHoa.Size = new System.Drawing.Size(142, 60);
            this.btnTienHoa.TabIndex = 15;
            this.btnTienHoa.Text = "Tiến hóa";
            this.btnTienHoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTienHoa.UseSelectable = true;
            this.btnTienHoa.Click += new System.EventHandler(this.btnTienHoa_Click);
            // 
            // btnTienHoa100
            // 
            this.btnTienHoa100.ActiveControl = null;
            this.btnTienHoa100.Location = new System.Drawing.Point(562, 692);
            this.btnTienHoa100.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTienHoa100.Name = "btnTienHoa100";
            this.btnTienHoa100.Size = new System.Drawing.Size(142, 60);
            this.btnTienHoa100.TabIndex = 15;
            this.btnTienHoa100.Text = "Tiến hóa 100";
            this.btnTienHoa100.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTienHoa100.UseSelectable = true;
            this.btnTienHoa100.Click += new System.EventHandler(this.btnTienHoa100_Click);
            // 
            // btnTienHoaAll
            // 
            this.btnTienHoaAll.ActiveControl = null;
            this.btnTienHoaAll.Location = new System.Drawing.Point(714, 692);
            this.btnTienHoaAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTienHoaAll.Name = "btnTienHoaAll";
            this.btnTienHoaAll.Size = new System.Drawing.Size(142, 60);
            this.btnTienHoaAll.TabIndex = 15;
            this.btnTienHoaAll.Text = "Tiến hóa hết";
            this.btnTienHoaAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTienHoaAll.UseSelectable = true;
            this.btnTienHoaAll.Click += new System.EventHandler(this.btnTienHoaAll_Click);
            // 
            // btnStop
            // 
            this.btnStop.ActiveControl = null;
            this.btnStop.Location = new System.Drawing.Point(866, 692);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(142, 60);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Dừng";
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStop.UseSelectable = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridView1.Location = new System.Drawing.Point(998, 115);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(398, 438);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnTKB
            // 
            this.btnTKB.ActiveControl = null;
            this.btnTKB.Location = new System.Drawing.Point(1095, 565);
            this.btnTKB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTKB.Name = "btnTKB";
            this.btnTKB.Size = new System.Drawing.Size(206, 58);
            this.btnTKB.TabIndex = 17;
            this.btnTKB.Text = "Lập thời kháo biểu";
            this.btnTKB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTKB.UseSelectable = true;
            this.btnTKB.Click += new System.EventHandler(this.btnTKB_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroLabel1.Location = new System.Drawing.Point(590, 25);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(165, 25);
            this.metroLabel1.TabIndex = 72;
            this.metroLabel1.Text = "Phân thời khóa biểu";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // frmPhanLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 846);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnTKB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnTienHoaAll);
            this.Controls.Add(this.btnTienHoa100);
            this.Controls.Add(this.btnTienHoa);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmPhanLich";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Resizable = false;
            this.Load += new System.EventHandler(this.uLapTKB_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ProgressBar progressBar1;
        private MetroFramework.Controls.MetroTile btnTienHoa;
        private MetroFramework.Controls.MetroTile btnTienHoa100;
        private MetroFramework.Controls.MetroTile btnTienHoaAll;
        private MetroFramework.Controls.MetroTile btnStop;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView1;
        private MetroFramework.Controls.MetroTile btnTKB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
