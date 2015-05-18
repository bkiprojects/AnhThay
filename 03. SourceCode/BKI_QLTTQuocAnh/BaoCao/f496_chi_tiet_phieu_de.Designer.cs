namespace BKI_QLTTQuocAnh.BaoCao {
    partial class f496_chi_tiet_phieu_de {
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
            this.TEN_LOAI_PHIEU_THU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_THU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_PHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_DOI_TUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_TIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOI_DUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_NGUOI_NHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_NGUOI_THU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl1.Size = new System.Drawing.Size(859, 300);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TEN_LOAI_PHIEU_THU,
            this.NGAY_THU,
            this.SO_PHIEU,
            this.MA_DOI_TUONG,
            this.HO_TEN,
            this.SO_TIEN,
            this.NOI_DUNG,
            this.TEN_NGUOI_NHAP,
            this.TEN_NGUOI_THU,
            this.TEN});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, null, this.SO_TIEN, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // TEN_LOAI_PHIEU_THU
            // 
            this.TEN_LOAI_PHIEU_THU.Caption = "Loại phiếu";
            this.TEN_LOAI_PHIEU_THU.FieldName = "TEN_LOAI_PHIEU_THU";
            this.TEN_LOAI_PHIEU_THU.Name = "TEN_LOAI_PHIEU_THU";
            this.TEN_LOAI_PHIEU_THU.Visible = true;
            this.TEN_LOAI_PHIEU_THU.VisibleIndex = 0;
            this.TEN_LOAI_PHIEU_THU.Width = 80;
            // 
            // NGAY_THU
            // 
            this.NGAY_THU.Caption = "Ngày thu";
            this.NGAY_THU.FieldName = "NGAY_THU";
            this.NGAY_THU.Name = "NGAY_THU";
            this.NGAY_THU.Visible = true;
            this.NGAY_THU.VisibleIndex = 1;
            this.NGAY_THU.Width = 86;
            // 
            // SO_PHIEU
            // 
            this.SO_PHIEU.Caption = "Số phiếu";
            this.SO_PHIEU.FieldName = "SO_PHIEU";
            this.SO_PHIEU.Name = "SO_PHIEU";
            this.SO_PHIEU.Visible = true;
            this.SO_PHIEU.VisibleIndex = 2;
            this.SO_PHIEU.Width = 81;
            // 
            // MA_DOI_TUONG
            // 
            this.MA_DOI_TUONG.Caption = "Mã HV";
            this.MA_DOI_TUONG.FieldName = "MA_DOI_TUONG";
            this.MA_DOI_TUONG.Name = "MA_DOI_TUONG";
            this.MA_DOI_TUONG.Visible = true;
            this.MA_DOI_TUONG.VisibleIndex = 3;
            this.MA_DOI_TUONG.Width = 63;
            // 
            // HO_TEN
            // 
            this.HO_TEN.Caption = "Họ tên";
            this.HO_TEN.FieldName = "HO_TEN";
            this.HO_TEN.Name = "HO_TEN";
            this.HO_TEN.Visible = true;
            this.HO_TEN.VisibleIndex = 4;
            this.HO_TEN.Width = 109;
            // 
            // SO_TIEN
            // 
            this.SO_TIEN.Caption = "Số tiền";
            this.SO_TIEN.FieldName = "SO_TIEN";
            this.SO_TIEN.Name = "SO_TIEN";
            this.SO_TIEN.Visible = true;
            this.SO_TIEN.VisibleIndex = 5;
            this.SO_TIEN.Width = 72;
            // 
            // NOI_DUNG
            // 
            this.NOI_DUNG.Caption = "Nội dung";
            this.NOI_DUNG.FieldName = "NOI_DUNG";
            this.NOI_DUNG.Name = "NOI_DUNG";
            this.NOI_DUNG.Visible = true;
            this.NOI_DUNG.VisibleIndex = 6;
            this.NOI_DUNG.Width = 102;
            // 
            // TEN_NGUOI_NHAP
            // 
            this.TEN_NGUOI_NHAP.Caption = "Tên người nhập";
            this.TEN_NGUOI_NHAP.FieldName = "TEN_NGUOI_NHAP";
            this.TEN_NGUOI_NHAP.Name = "TEN_NGUOI_NHAP";
            this.TEN_NGUOI_NHAP.Visible = true;
            this.TEN_NGUOI_NHAP.VisibleIndex = 7;
            this.TEN_NGUOI_NHAP.Width = 86;
            // 
            // TEN_NGUOI_THU
            // 
            this.TEN_NGUOI_THU.Caption = "Tên người thu";
            this.TEN_NGUOI_THU.FieldName = "TEN_NGUOI_THU";
            this.TEN_NGUOI_THU.Name = "TEN_NGUOI_THU";
            this.TEN_NGUOI_THU.Visible = true;
            this.TEN_NGUOI_THU.VisibleIndex = 8;
            this.TEN_NGUOI_THU.Width = 77;
            // 
            // TEN
            // 
            this.TEN.Caption = "Trạng thái";
            this.TEN.FieldName = "TEN";
            this.TEN.Name = "TEN";
            this.TEN.Visible = true;
            this.TEN.VisibleIndex = 9;
            this.TEN.Width = 85;
            // 
            // f496_chi_tiet_phieu_de
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 300);
            this.Controls.Add(this.gridControl1);
            this.Name = "f496_chi_tiet_phieu_de";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách chi tiết phiếu";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_LOAI_PHIEU_THU;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_THU;
        private DevExpress.XtraGrid.Columns.GridColumn SO_PHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn MA_DOI_TUONG;
        private DevExpress.XtraGrid.Columns.GridColumn HO_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn SO_TIEN;
        private DevExpress.XtraGrid.Columns.GridColumn NOI_DUNG;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_NGUOI_NHAP;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_NGUOI_THU;
        private DevExpress.XtraGrid.Columns.GridColumn TEN;
    }
}