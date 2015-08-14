namespace BKI_QLTTQuocAnh.BaoCao
{
    partial class f530_bao_cao_tinh_hinh_tai_chinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f530_bao_cao_tinh_hinh_tai_chinh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_dat_den_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_den_ngay = new System.Windows.Forms.Label();
            this.m_dat_tu_ngay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.m_sle_lop = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_lbl_lop_mon = new System.Windows.Forms.Label();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.TEN_LOP = new DevExpress.XtraPivotGrid.PivotGridField();
            this.NAM = new DevExpress.XtraPivotGrid.PivotGridField();
            this.QUY = new DevExpress.XtraPivotGrid.PivotGridField();
            this.THANG = new DevExpress.XtraPivotGrid.PivotGridField();
            this.NGAY = new DevExpress.XtraPivotGrid.PivotGridField();
            this.TIEN = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_lop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.panel2.SuspendLayout();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.m_dat_den_ngay);
            this.panel1.Controls.Add(this.m_lbl_den_ngay);
            this.panel1.Controls.Add(this.m_dat_tu_ngay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_sle_lop);
            this.panel1.Controls.Add(this.m_lbl_header);
            this.panel1.Controls.Add(this.m_lbl_lop_mon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 116);
            this.panel1.TabIndex = 1;
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(342, 75);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 8;
            this.m_cmd_search.Text = "Lọc dữ liệu";
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // m_dat_den_ngay
            // 
            this.m_dat_den_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_dat_den_ngay.Location = new System.Drawing.Point(321, 47);
            this.m_dat_den_ngay.Name = "m_dat_den_ngay";
            this.m_dat_den_ngay.Size = new System.Drawing.Size(109, 20);
            this.m_dat_den_ngay.TabIndex = 7;
            // 
            // m_lbl_den_ngay
            // 
            this.m_lbl_den_ngay.AutoSize = true;
            this.m_lbl_den_ngay.Location = new System.Drawing.Point(254, 50);
            this.m_lbl_den_ngay.Name = "m_lbl_den_ngay";
            this.m_lbl_den_ngay.Size = new System.Drawing.Size(53, 13);
            this.m_lbl_den_ngay.TabIndex = 6;
            this.m_lbl_den_ngay.Text = "Đến ngày";
            // 
            // m_dat_tu_ngay
            // 
            this.m_dat_tu_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_dat_tu_ngay.Location = new System.Drawing.Point(92, 47);
            this.m_dat_tu_ngay.Name = "m_dat_tu_ngay";
            this.m_dat_tu_ngay.Size = new System.Drawing.Size(109, 20);
            this.m_dat_tu_ngay.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Từ ngày";
            // 
            // m_sle_lop
            // 
            this.m_sle_lop.EditValue = "";
            this.m_sle_lop.Location = new System.Drawing.Point(92, 80);
            this.m_sle_lop.Name = "m_sle_lop";
            this.m_sle_lop.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.m_sle_lop.Properties.Appearance.Options.UseFont = true;
            this.m_sle_lop.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.m_sle_lop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_lop.Properties.NullText = "Chọn lớp";
            this.m_sle_lop.Properties.View = this.gridView1;
            this.m_sle_lop.Size = new System.Drawing.Size(187, 20);
            this.m_sle_lop.TabIndex = 2;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(913, 44);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "TỔNG BÁO CÁO THỰC THU";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_lbl_lop_mon
            // 
            this.m_lbl_lop_mon.AutoSize = true;
            this.m_lbl_lop_mon.Location = new System.Drawing.Point(43, 83);
            this.m_lbl_lop_mon.Name = "m_lbl_lop_mon";
            this.m_lbl_lop_mon.Size = new System.Drawing.Size(25, 13);
            this.m_lbl_lop_mon.TabIndex = 1;
            this.m_lbl_lop_mon.Text = "Lớp";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.TEN_LOP,
            this.NAM,
            this.QUY,
            this.THANG,
            this.NGAY,
            this.TIEN});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(913, 369);
            this.pivotGridControl1.TabIndex = 2;
            this.pivotGridControl1.FieldValueDisplayText += new DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(this.pivotGridControl1_FieldValueDisplayText);
            this.pivotGridControl1.CellDoubleClick += new DevExpress.XtraPivotGrid.PivotCellEventHandler(this.pivotGridControl1_CellDoubleClick);
            // 
            // TEN_LOP
            // 
            this.TEN_LOP.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.TEN_LOP.AreaIndex = 0;
            this.TEN_LOP.Caption = "Lớp";
            this.TEN_LOP.FieldName = "TEN_LOP_MON";
            this.TEN_LOP.Name = "TEN_LOP";
            // 
            // NAM
            // 
            this.NAM.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.NAM.AreaIndex = 0;
            this.NAM.Caption = "Năm";
            this.NAM.FieldName = "NGAY_THU";
            this.NAM.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.NAM.Name = "NAM";
            this.NAM.UnboundFieldName = "NAM";
            // 
            // QUY
            // 
            this.QUY.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.QUY.AreaIndex = 1;
            this.QUY.Caption = "Quý";
            this.QUY.FieldName = "NGAY_THU";
            this.QUY.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.QUY.Name = "QUY";
            this.QUY.UnboundFieldName = "QUY";
            // 
            // THANG
            // 
            this.THANG.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.THANG.AreaIndex = 2;
            this.THANG.Caption = "Tháng";
            this.THANG.FieldName = "NGAY_THU";
            this.THANG.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.THANG.Name = "THANG";
            this.THANG.UnboundFieldName = "THANG";
            // 
            // NGAY
            // 
            this.NGAY.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.NGAY.AreaIndex = 3;
            this.NGAY.Caption = "Ngày";
            this.NGAY.FieldName = "NGAY_THU";
            this.NGAY.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date;
            this.NGAY.Name = "NGAY";
            this.NGAY.UnboundFieldName = "NGAY";
            // 
            // TIEN
            // 
            this.TIEN.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.TIEN.AreaIndex = 0;
            this.TIEN.Caption = "Số tiền";
            this.TIEN.CellFormat.FormatString = "{0:#,##}";
            this.TIEN.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.TIEN.FieldName = "SO_TIEN";
            this.TIEN.Name = "TIEN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_pnl_out_place_dm);
            this.panel2.Controls.Add(this.pivotGridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 369);
            this.panel2.TabIndex = 3;
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.simpleButton1);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 333);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(913, 36);
            this.m_pnl_out_place_dm.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(4, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 28);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // f530_bao_cao_tinh_hinh_tai_chinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f530_bao_cao_tinh_hinh_tai_chinh";
            this.Text = "F530 - TỔNG báo cáo thực thu";
            this.Load += new System.EventHandler(this.f530_bao_cao_tinh_hinh_tai_chinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_lop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker m_dat_den_ngay;
        private System.Windows.Forms.Label m_lbl_den_ngay;
        private System.Windows.Forms.DateTimePicker m_dat_tu_ngay;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_lop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label m_lbl_header;
        private System.Windows.Forms.Label m_lbl_lop_mon;
        internal System.Windows.Forms.ImageList ImageList;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField TEN_LOP;
        private DevExpress.XtraPivotGrid.PivotGridField NAM;
        private DevExpress.XtraPivotGrid.PivotGridField QUY;
        private DevExpress.XtraPivotGrid.PivotGridField THANG;
        private DevExpress.XtraPivotGrid.PivotGridField NGAY;
        private DevExpress.XtraPivotGrid.PivotGridField TIEN;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}