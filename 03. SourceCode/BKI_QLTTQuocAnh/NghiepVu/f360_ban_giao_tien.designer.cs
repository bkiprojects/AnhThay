namespace BKI_QLTTQuocAnh.NghiepVu
{
    partial class f360_ban_giao_tien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f360_ban_giao_tien));
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_dat_tu_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_tu_ngay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.m_txt_tong_tien = new System.Windows.Forms.TextBox();
            this.m_lbl_tong_tien = new System.Windows.Forms.Label();
            this.m_cbo_nhan_vien_thu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_lbl_den_ngay = new System.Windows.Forms.Label();
            this.m_dat_den_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NGAY_THU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_PHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOI_DUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_HOC_SINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_HOC_VIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGUOI_THU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_LOP_MON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIEN_THUC_THU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.MA_SO_QUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(1175, 44);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "BÀN GIAO TIỀN";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_dat_tu_ngay
            // 
            this.m_dat_tu_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dat_tu_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_tu_ngay.Location = new System.Drawing.Point(87, 3);
            this.m_dat_tu_ngay.Name = "m_dat_tu_ngay";
            this.m_dat_tu_ngay.Size = new System.Drawing.Size(121, 20);
            this.m_dat_tu_ngay.TabIndex = 1;
            // 
            // m_lbl_tu_ngay
            // 
            this.m_lbl_tu_ngay.AutoSize = true;
            this.m_lbl_tu_ngay.Location = new System.Drawing.Point(8, 5);
            this.m_lbl_tu_ngay.Name = "m_lbl_tu_ngay";
            this.m_lbl_tu_ngay.Size = new System.Drawing.Size(46, 13);
            this.m_lbl_tu_ngay.TabIndex = 0;
            this.m_lbl_tu_ngay.Text = "Từ ngày";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_fg);
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.m_txt_tong_tien);
            this.panel1.Controls.Add(this.m_lbl_tong_tien);
            this.panel1.Controls.Add(this.m_cbo_nhan_vien_thu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_lbl_den_ngay);
            this.panel1.Controls.Add(this.m_dat_den_ngay);
            this.panel1.Controls.Add(this.m_dat_tu_ngay);
            this.panel1.Controls.Add(this.m_lbl_tu_ngay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 106);
            this.panel1.TabIndex = 1;
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Location = new System.Drawing.Point(664, 5);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(481, 89);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 21;
            this.m_fg.Visible = false;
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(236, 30);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 6;
            this.m_cmd_search.Text = "&Lọc phiếu";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(450, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "(VNĐ)";
            // 
            // m_txt_tong_tien
            // 
            this.m_txt_tong_tien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_txt_tong_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_txt_tong_tien.ForeColor = System.Drawing.Color.Maroon;
            this.m_txt_tong_tien.Location = new System.Drawing.Point(229, 67);
            this.m_txt_tong_tien.Name = "m_txt_tong_tien";
            this.m_txt_tong_tien.ReadOnly = true;
            this.m_txt_tong_tien.Size = new System.Drawing.Size(215, 29);
            this.m_txt_tong_tien.TabIndex = 8;
            this.m_txt_tong_tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_lbl_tong_tien
            // 
            this.m_lbl_tong_tien.AutoSize = true;
            this.m_lbl_tong_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_tong_tien.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_tong_tien.Location = new System.Drawing.Point(8, 70);
            this.m_lbl_tong_tien.Name = "m_lbl_tong_tien";
            this.m_lbl_tong_tien.Size = new System.Drawing.Size(188, 24);
            this.m_lbl_tong_tien.TabIndex = 7;
            this.m_lbl_tong_tien.Text = "TỔNG TIỀN ĐÃ THU";
            // 
            // m_cbo_nhan_vien_thu
            // 
            this.m_cbo_nhan_vien_thu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_nhan_vien_thu.FormattingEnabled = true;
            this.m_cbo_nhan_vien_thu.Location = new System.Drawing.Point(87, 35);
            this.m_cbo_nhan_vien_thu.Name = "m_cbo_nhan_vien_thu";
            this.m_cbo_nhan_vien_thu.Size = new System.Drawing.Size(143, 21);
            this.m_cbo_nhan_vien_thu.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhân viên";
            // 
            // m_lbl_den_ngay
            // 
            this.m_lbl_den_ngay.AutoSize = true;
            this.m_lbl_den_ngay.Location = new System.Drawing.Point(232, 7);
            this.m_lbl_den_ngay.Name = "m_lbl_den_ngay";
            this.m_lbl_den_ngay.Size = new System.Drawing.Size(53, 13);
            this.m_lbl_den_ngay.TabIndex = 2;
            this.m_lbl_den_ngay.Text = "Đến ngày";
            // 
            // m_dat_den_ngay
            // 
            this.m_dat_den_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dat_den_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_den_ngay.Location = new System.Drawing.Point(304, 5);
            this.m_dat_den_ngay.Name = "m_dat_den_ngay";
            this.m_dat_den_ngay.Size = new System.Drawing.Size(128, 20);
            this.m_dat_den_ngay.TabIndex = 3;
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 358);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(1175, 79);
            this.m_pnl_out_place_dm.TabIndex = 3;
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(403, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 71);
            this.m_cmd_exit.TabIndex = 4;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_xuat_excel.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_xuat_excel.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xuat_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_xuat_excel.ImageIndex = 19;
            this.m_cmd_xuat_excel.ImageList = this.ImageList;
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(315, 4);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(88, 71);
            this.m_cmd_xuat_excel.TabIndex = 3;
            this.m_cmd_xuat_excel.Text = "Xuất Excel";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 4;
            this.m_cmd_delete.ImageList = this.ImageList;
            this.m_cmd_delete.Location = new System.Drawing.Point(227, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 71);
            this.m_cmd_delete.TabIndex = 2;
            this.m_cmd_delete.Text = "&Xoá";
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_update.ImageIndex = 3;
            this.m_cmd_update.ImageList = this.ImageList;
            this.m_cmd_update.Location = new System.Drawing.Point(139, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 71);
            this.m_cmd_update.TabIndex = 1;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 13;
            this.m_cmd_insert.ImageList = this.ImageList;
            this.m_cmd_insert.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(135, 71);
            this.m_cmd_insert.TabIndex = 0;
            this.m_cmd_insert.Text = "&Bàn giao";
            // 
            // gridControl
            // 
            this.gridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 150);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit,
            this.repositoryItemTextEdit1});
            this.gridControl.Size = new System.Drawing.Size(1175, 208);
            this.gridControl.TabIndex = 4;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MA_SO_QUYEN,
            this.NGAY_THU,
            this.SO_PHIEU,
            this.NOI_DUNG,
            this.MA_HOC_SINH,
            this.TEN_HOC_VIEN,
            this.NGUOI_THU,
            this.TEN_LOP_MON,
            this.TIEN_THUC_THU,
            this.ID});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsSelection.MultiSelect = true;
            this.gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // NGAY_THU
            // 
            this.NGAY_THU.Caption = "Ngày thu";
            this.NGAY_THU.FieldName = "NGAY_THU";
            this.NGAY_THU.Name = "NGAY_THU";
            this.NGAY_THU.OptionsColumn.AllowEdit = false;
            this.NGAY_THU.Visible = true;
            this.NGAY_THU.VisibleIndex = 2;
            this.NGAY_THU.Width = 123;
            // 
            // SO_PHIEU
            // 
            this.SO_PHIEU.Caption = "Số phiếu";
            this.SO_PHIEU.FieldName = "SO_PHIEU";
            this.SO_PHIEU.Name = "SO_PHIEU";
            this.SO_PHIEU.OptionsColumn.AllowEdit = false;
            this.SO_PHIEU.Visible = true;
            this.SO_PHIEU.VisibleIndex = 3;
            this.SO_PHIEU.Width = 76;
            // 
            // NOI_DUNG
            // 
            this.NOI_DUNG.Caption = "Nội dung";
            this.NOI_DUNG.FieldName = "NOI_DUNG";
            this.NOI_DUNG.Name = "NOI_DUNG";
            this.NOI_DUNG.OptionsColumn.AllowEdit = false;
            this.NOI_DUNG.Visible = true;
            this.NOI_DUNG.VisibleIndex = 4;
            this.NOI_DUNG.Width = 160;
            // 
            // MA_HOC_SINH
            // 
            this.MA_HOC_SINH.Caption = "Mã HV";
            this.MA_HOC_SINH.FieldName = "MA_HOC_SINH";
            this.MA_HOC_SINH.Name = "MA_HOC_SINH";
            this.MA_HOC_SINH.OptionsColumn.AllowEdit = false;
            this.MA_HOC_SINH.Visible = true;
            this.MA_HOC_SINH.VisibleIndex = 5;
            this.MA_HOC_SINH.Width = 55;
            // 
            // TEN_HOC_VIEN
            // 
            this.TEN_HOC_VIEN.Caption = "Tên HV";
            this.TEN_HOC_VIEN.FieldName = "HO_TEN_HS";
            this.TEN_HOC_VIEN.Name = "TEN_HOC_VIEN";
            this.TEN_HOC_VIEN.OptionsColumn.AllowEdit = false;
            this.TEN_HOC_VIEN.Visible = true;
            this.TEN_HOC_VIEN.VisibleIndex = 6;
            this.TEN_HOC_VIEN.Width = 132;
            // 
            // NGUOI_THU
            // 
            this.NGUOI_THU.Caption = "Người thu";
            this.NGUOI_THU.FieldName = "TEN_NGUOI_THU";
            this.NGUOI_THU.Name = "NGUOI_THU";
            this.NGUOI_THU.OptionsColumn.AllowEdit = false;
            this.NGUOI_THU.Visible = true;
            this.NGUOI_THU.VisibleIndex = 7;
            this.NGUOI_THU.Width = 178;
            // 
            // TEN_LOP_MON
            // 
            this.TEN_LOP_MON.Caption = "Lớp";
            this.TEN_LOP_MON.FieldName = "TEN_LOP_MON";
            this.TEN_LOP_MON.Name = "TEN_LOP_MON";
            this.TEN_LOP_MON.OptionsColumn.AllowEdit = false;
            this.TEN_LOP_MON.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.TEN_LOP_MON.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.TEN_LOP_MON.Visible = true;
            this.TEN_LOP_MON.VisibleIndex = 8;
            this.TEN_LOP_MON.Width = 178;
            // 
            // TIEN_THUC_THU
            // 
            this.TIEN_THUC_THU.Caption = "Tiền thực thu";
            this.TIEN_THUC_THU.ColumnEdit = this.repositoryItemTextEdit1;
            this.TIEN_THUC_THU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TIEN_THUC_THU.FieldName = "TIEN_THUC_THU";
            this.TIEN_THUC_THU.Name = "TIEN_THUC_THU";
            this.TIEN_THUC_THU.OptionsColumn.AllowEdit = false;
            this.TIEN_THUC_THU.Visible = true;
            this.TIEN_THUC_THU.VisibleIndex = 9;
            this.TIEN_THUC_THU.Width = 215;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // repositoryItemCheckEdit
            // 
            this.repositoryItemCheckEdit.AutoHeight = false;
            this.repositoryItemCheckEdit.Caption = "Check";
            this.repositoryItemCheckEdit.Name = "repositoryItemCheckEdit";
            this.repositoryItemCheckEdit.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // MA_SO_QUYEN
            // 
            this.MA_SO_QUYEN.Caption = "Quyển số";
            this.MA_SO_QUYEN.FieldName = "MA_SO_QUYEN";
            this.MA_SO_QUYEN.Name = "MA_SO_QUYEN";
            this.MA_SO_QUYEN.Visible = true;
            this.MA_SO_QUYEN.VisibleIndex = 1;
            // 
            // f360_ban_giao_tien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 437);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_lbl_header);
            this.Name = "f360_ban_giao_tien";
            this.Text = "F360 - Bàn giao tiền";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label m_lbl_header;
        private System.Windows.Forms.DateTimePicker m_dat_tu_ngay;
        private System.Windows.Forms.Label m_lbl_tu_ngay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label m_lbl_den_ngay;
        private System.Windows.Forms.DateTimePicker m_dat_den_ngay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox m_cbo_nhan_vien_thu;
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private System.Windows.Forms.Label m_lbl_tong_tien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_txt_tong_tien;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_THU;
        private DevExpress.XtraGrid.Columns.GridColumn SO_PHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn NOI_DUNG;
        private DevExpress.XtraGrid.Columns.GridColumn MA_HOC_SINH;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_HOC_VIEN;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit;
        private DevExpress.XtraGrid.Columns.GridColumn NGUOI_THU;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_LOP_MON;
        private DevExpress.XtraGrid.Columns.GridColumn TIEN_THUC_THU;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn MA_SO_QUYEN;
    }
}