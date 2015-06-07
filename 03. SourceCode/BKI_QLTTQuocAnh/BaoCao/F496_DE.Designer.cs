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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LOAI_PHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_PHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_THU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_HOC_SINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO_TEN_HS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_NGUOI_THU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_TIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_SO_QUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LAN_THU = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1103, 486);
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
            this.LAN_THU});
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
            this.SO_TIEN.FieldName = "SO_TIEN";
            this.SO_TIEN.Name = "SO_TIEN";
            this.SO_TIEN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN", "{0:n0}")});
            this.SO_TIEN.Visible = true;
            this.SO_TIEN.VisibleIndex = 4;
            // 
            // MA_SO_QUYEN
            // 
            this.MA_SO_QUYEN.Caption = "Quyển số";
            this.MA_SO_QUYEN.FieldName = "MA_SO_QUYEN";
            this.MA_SO_QUYEN.Name = "MA_SO_QUYEN";
            this.MA_SO_QUYEN.Visible = true;
            this.MA_SO_QUYEN.VisibleIndex = 0;
            // 
            // LAN_THU
            // 
            this.LAN_THU.Caption = "Lần thứ";
            this.LAN_THU.FieldName = "LAN_THU";
            this.LAN_THU.Name = "LAN_THU";
            this.LAN_THU.Visible = true;
            this.LAN_THU.VisibleIndex = 6;
            // 
            // F496_DE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 486);
            this.Controls.Add(this.gridControl1);
            this.Name = "F496_DE";
            this.Text = "Danh sách phiếu";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
    }
}