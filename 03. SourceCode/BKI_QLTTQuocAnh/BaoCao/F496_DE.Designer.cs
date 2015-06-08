namespace BKI_QLTTQuocAnh.BaoCao {
    partial class F496_DE {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F496_DE));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LOAI_PHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_SO_QUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_PHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_THU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_HOC_SINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO_TEN_HS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_NGUOI_THU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_TIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.LAN_THU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.NGAY_NHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 54);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1103, 432);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LOAI_PHIEU,
            this.MA_SO_QUYEN,
            this.SO_PHIEU,
            this.NGAY_THU,
            this.MA_HOC_SINH,
            this.HO_TEN_HS,
            this.TEN_NGUOI_THU,
            this.SO_TIEN,
            this.LAN_THU,
            this.NGAY_NHAP});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.LOAI_PHIEU, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // LOAI_PHIEU
            // 
            this.LOAI_PHIEU.Caption = "Loại phiếu";
            this.LOAI_PHIEU.FieldName = "TEN_LOAI_PHIEU_THU";
            this.LOAI_PHIEU.Name = "LOAI_PHIEU";
            this.LOAI_PHIEU.Visible = true;
            this.LOAI_PHIEU.VisibleIndex = 0;
            // 
            // MA_SO_QUYEN
            // 
            this.MA_SO_QUYEN.Caption = "Quyển số";
            this.MA_SO_QUYEN.FieldName = "MA_SO_QUYEN";
            this.MA_SO_QUYEN.Name = "MA_SO_QUYEN";
            this.MA_SO_QUYEN.Visible = true;
            this.MA_SO_QUYEN.VisibleIndex = 0;
            // 
            // SO_PHIEU
            // 
            this.SO_PHIEU.Caption = "Số phiếu";
            this.SO_PHIEU.FieldName = "SO_PHIEU";
            this.SO_PHIEU.Name = "SO_PHIEU";
            this.SO_PHIEU.Visible = true;
            this.SO_PHIEU.VisibleIndex = 1;
            // 
            // NGAY_THU
            // 
            this.NGAY_THU.Caption = "Ngày thu";
            this.NGAY_THU.FieldName = "NGAY_THU";
            this.NGAY_THU.Name = "NGAY_THU";
            this.NGAY_THU.Visible = true;
            this.NGAY_THU.VisibleIndex = 2;
            // 
            // MA_HOC_SINH
            // 
            this.MA_HOC_SINH.Caption = "Mã học sinh";
            this.MA_HOC_SINH.FieldName = "MA_DOI_TUONG";
            this.MA_HOC_SINH.Name = "MA_HOC_SINH";
            this.MA_HOC_SINH.Visible = true;
            this.MA_HOC_SINH.VisibleIndex = 7;
            // 
            // HO_TEN_HS
            // 
            this.HO_TEN_HS.Caption = "Họ tên";
            this.HO_TEN_HS.FieldName = "HO_TEN";
            this.HO_TEN_HS.Name = "HO_TEN_HS";
            this.HO_TEN_HS.Visible = true;
            this.HO_TEN_HS.VisibleIndex = 3;
            // 
            // TEN_NGUOI_THU
            // 
            this.TEN_NGUOI_THU.Caption = "Người thu";
            this.TEN_NGUOI_THU.FieldName = "TEN_NGUOI_THU";
            this.TEN_NGUOI_THU.Name = "TEN_NGUOI_THU";
            this.TEN_NGUOI_THU.Visible = true;
            this.TEN_NGUOI_THU.VisibleIndex = 5;
            // 
            // SO_TIEN
            // 
            this.SO_TIEN.Caption = "Số tiền";
            this.SO_TIEN.ColumnEdit = this.repositoryItemTextEdit1;
            this.SO_TIEN.FieldName = "SO_TIEN";
            this.SO_TIEN.Name = "SO_TIEN";
            this.SO_TIEN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN", "{0:n0}")});
            this.SO_TIEN.Visible = true;
            this.SO_TIEN.VisibleIndex = 4;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // LAN_THU
            // 
            this.LAN_THU.Caption = "Lần thứ";
            this.LAN_THU.FieldName = "LAN_THU";
            this.LAN_THU.Name = "LAN_THU";
            this.LAN_THU.Visible = true;
            this.LAN_THU.VisibleIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 54);
            this.panel1.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton2.Location = new System.Drawing.Point(0, 0);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 54);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            this.imageList1.Images.SetKeyName(18, "");
            this.imageList1.Images.SetKeyName(19, "");
            this.imageList1.Images.SetKeyName(20, "");
            this.imageList1.Images.SetKeyName(21, "");
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
            // NGAY_NHAP
            // 
            this.NGAY_NHAP.Caption = "Ngày lập";
            this.NGAY_NHAP.FieldName = "NGAY_NHAP";
            this.NGAY_NHAP.Name = "NGAY_NHAP";
            this.NGAY_NHAP.Visible = true;
            this.NGAY_NHAP.VisibleIndex = 8;
            // 
            // F496_DE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControl1);
            this.Name = "F496_DE";
            this.Text = "Danh sách phiếu";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn LOAI_PHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn SO_PHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_THU;
        private DevExpress.XtraGrid.Columns.GridColumn MA_HOC_SINH;
        private DevExpress.XtraGrid.Columns.GridColumn HO_TEN_HS;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_NGUOI_THU;
        private DevExpress.XtraGrid.Columns.GridColumn SO_TIEN;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn MA_SO_QUYEN;
        private DevExpress.XtraGrid.Columns.GridColumn LAN_THU;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_NHAP;
    }
}