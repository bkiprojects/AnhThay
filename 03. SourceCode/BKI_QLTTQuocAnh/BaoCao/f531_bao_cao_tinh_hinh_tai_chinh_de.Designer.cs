namespace BKI_QLTTQuocAnh.BaoCao
{
    partial class f531_bao_cao_tinh_hinh_tai_chinh_de
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f531_bao_cao_tinh_hinh_tai_chinh_de));
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_dat_den_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_den_ngay = new System.Windows.Forms.Label();
            this.m_dat_tu_ngay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_LOP_MON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_PHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_TIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_NGUOI_THU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_THU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_dat_den_ngay);
            this.panel1.Controls.Add(this.m_lbl_den_ngay);
            this.panel1.Controls.Add(this.m_dat_tu_ngay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_lbl_header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 88);
            this.panel1.TabIndex = 2;
            // 
            // m_dat_den_ngay
            // 
            this.m_dat_den_ngay.Enabled = false;
            this.m_dat_den_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_dat_den_ngay.Location = new System.Drawing.Point(321, 47);
            this.m_dat_den_ngay.Name = "m_dat_den_ngay";
            this.m_dat_den_ngay.Size = new System.Drawing.Size(109, 20);
            this.m_dat_den_ngay.TabIndex = 11;
            // 
            // m_lbl_den_ngay
            // 
            this.m_lbl_den_ngay.AutoSize = true;
            this.m_lbl_den_ngay.Location = new System.Drawing.Point(254, 50);
            this.m_lbl_den_ngay.Name = "m_lbl_den_ngay";
            this.m_lbl_den_ngay.Size = new System.Drawing.Size(53, 13);
            this.m_lbl_den_ngay.TabIndex = 10;
            this.m_lbl_den_ngay.Text = "Đến ngày";
            // 
            // m_dat_tu_ngay
            // 
            this.m_dat_tu_ngay.Enabled = false;
            this.m_dat_tu_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_dat_tu_ngay.Location = new System.Drawing.Point(92, 47);
            this.m_dat_tu_ngay.Name = "m_dat_tu_ngay";
            this.m_dat_tu_ngay.Size = new System.Drawing.Size(109, 20);
            this.m_dat_tu_ngay.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Từ ngày";
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(900, 44);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "BÁO CÁO TÌNH HÌNH THỰC THU THEO LỚP";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(900, 356);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.TEN_LOP_MON,
            this.SO_PHIEU,
            this.HO_TEN,
            this.SO_TIEN,
            this.TEN_NGUOI_THU,
            this.NGAY_THU});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 38;
            // 
            // TEN_LOP_MON
            // 
            this.TEN_LOP_MON.Caption = "Lớp";
            this.TEN_LOP_MON.FieldName = "TEN_LOP_MON";
            this.TEN_LOP_MON.Name = "TEN_LOP_MON";
            this.TEN_LOP_MON.Visible = true;
            this.TEN_LOP_MON.VisibleIndex = 0;
            this.TEN_LOP_MON.Width = 210;
            // 
            // SO_PHIEU
            // 
            this.SO_PHIEU.Caption = "Số phiếu";
            this.SO_PHIEU.FieldName = "SO_PHIEU";
            this.SO_PHIEU.Name = "SO_PHIEU";
            this.SO_PHIEU.Visible = true;
            this.SO_PHIEU.VisibleIndex = 1;
            this.SO_PHIEU.Width = 210;
            // 
            // HO_TEN
            // 
            this.HO_TEN.Caption = "Họ tên";
            this.HO_TEN.FieldName = "HO_TEN";
            this.HO_TEN.Name = "HO_TEN";
            this.HO_TEN.Visible = true;
            this.HO_TEN.VisibleIndex = 2;
            this.HO_TEN.Width = 210;
            // 
            // SO_TIEN
            // 
            this.SO_TIEN.Caption = "Số tiền";
            this.SO_TIEN.DisplayFormat.FormatString = "{0:#,##}";
            this.SO_TIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.SO_TIEN.FieldName = "SO_TIEN";
            this.SO_TIEN.Name = "SO_TIEN";
            this.SO_TIEN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SO_TIEN", "{0:n0}")});
            this.SO_TIEN.Visible = true;
            this.SO_TIEN.VisibleIndex = 3;
            this.SO_TIEN.Width = 214;
            // 
            // TEN_NGUOI_THU
            // 
            this.TEN_NGUOI_THU.Caption = "Người thu";
            this.TEN_NGUOI_THU.FieldName = "TEN_NGUOI_THU";
            this.TEN_NGUOI_THU.Name = "TEN_NGUOI_THU";
            this.TEN_NGUOI_THU.Visible = true;
            this.TEN_NGUOI_THU.VisibleIndex = 4;
            // 
            // NGAY_THU
            // 
            this.NGAY_THU.Caption = "Ngày thu";
            this.NGAY_THU.FieldName = "NGAY_THU";
            this.NGAY_THU.Name = "NGAY_THU";
            this.NGAY_THU.Visible = true;
            this.NGAY_THU.VisibleIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_pnl_out_place_dm);
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 404);
            this.panel2.TabIndex = 4;
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.simpleButton1);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 358);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(900, 46);
            this.m_pnl_out_place_dm.TabIndex = 4;
            this.m_pnl_out_place_dm.UseWaitCursor = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(4, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 38);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.UseWaitCursor = true;
            // 
            // f531_bao_cao_tinh_hinh_tai_chinh_de
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 492);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f531_bao_cao_tinh_hinh_tai_chinh_de";
            this.Text = "F351 - Báo cáo tình hình thực thu theo lớp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label m_lbl_header;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_LOP_MON;
        private DevExpress.XtraGrid.Columns.GridColumn SO_PHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn HO_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn SO_TIEN;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_NGUOI_THU;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_THU;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DateTimePicker m_dat_den_ngay;
        private System.Windows.Forms.Label m_lbl_den_ngay;
        private System.Windows.Forms.DateTimePicker m_dat_tu_ngay;
        private System.Windows.Forms.Label label1;
    }
}