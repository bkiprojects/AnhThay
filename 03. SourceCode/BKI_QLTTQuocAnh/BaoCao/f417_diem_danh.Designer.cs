namespace BKI_QLTTQuocAnh.BaoCao {
    partial class f417_diem_danh {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f417_diem_danh));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.gridControlDiemDanh = new DevExpress.XtraGrid.GridControl();
            this.gridViewDiemDanh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StudentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StudentCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PrefixName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SuffixName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StudentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ShortcutKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_txt_buoi = new DevExpress.XtraEditors.TextEdit();
            this.m_sle_lop = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cmd_diem_danh = new SIS.Controls.Button.SiSButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDiemDanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiemDanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_buoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_lop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // gridControlDiemDanh
            // 
            this.gridControlDiemDanh.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlDiemDanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDiemDanh.Location = new System.Drawing.Point(0, 85);
            this.gridControlDiemDanh.MainView = this.gridViewDiemDanh;
            this.gridControlDiemDanh.Name = "gridControlDiemDanh";
            this.gridControlDiemDanh.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControlDiemDanh.Size = new System.Drawing.Size(802, 447);
            this.gridControlDiemDanh.TabIndex = 2;
            this.gridControlDiemDanh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDiemDanh});
            // 
            // gridViewDiemDanh
            // 
            this.gridViewDiemDanh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.StudentId,
            this.STT,
            this.StudentCode,
            this.PrefixName,
            this.SuffixName,
            this.StudentName,
            this.ShortcutKey});
            this.gridViewDiemDanh.GridControl = this.gridControlDiemDanh;
            this.gridViewDiemDanh.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID_HOC_SINH", null, "(SL = {0:n0})")});
            this.gridViewDiemDanh.Name = "gridViewDiemDanh";
            this.gridViewDiemDanh.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewDiemDanh.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridViewDiemDanh.OptionsFind.AlwaysVisible = true;
            this.gridViewDiemDanh.OptionsFind.FindDelay = 100;
            this.gridViewDiemDanh.OptionsFind.FindNullPrompt = "Tìm kiếm...";
            this.gridViewDiemDanh.OptionsFind.ShowClearButton = false;
            this.gridViewDiemDanh.OptionsFind.ShowCloseButton = false;
            this.gridViewDiemDanh.OptionsView.ShowFooter = true;
            this.gridViewDiemDanh.DoubleClick += new System.EventHandler(this.gridView2_DoubleClick);
            // 
            // ID
            // 
            this.ID.Caption = "gridColumn1";
            this.ID.Name = "ID";
            // 
            // StudentId
            // 
            this.StudentId.Caption = "StudentId";
            this.StudentId.FieldName = "StudentId";
            this.StudentId.Name = "StudentId";
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 41;
            // 
            // StudentCode
            // 
            this.StudentCode.Caption = "Mã học viên";
            this.StudentCode.FieldName = "StudentCode";
            this.StudentCode.Name = "StudentCode";
            this.StudentCode.Visible = true;
            this.StudentCode.VisibleIndex = 1;
            // 
            // PrefixName
            // 
            this.PrefixName.Caption = "Họ";
            this.PrefixName.FieldName = "PrefixName";
            this.PrefixName.Name = "PrefixName";
            this.PrefixName.Visible = true;
            this.PrefixName.VisibleIndex = 2;
            this.PrefixName.Width = 100;
            // 
            // SuffixName
            // 
            this.SuffixName.Caption = "Tên";
            this.SuffixName.FieldName = "SuffixName";
            this.SuffixName.Name = "SuffixName";
            this.SuffixName.Visible = true;
            this.SuffixName.VisibleIndex = 3;
            this.SuffixName.Width = 80;
            // 
            // StudentName
            // 
            this.StudentName.Caption = "Họ tên";
            this.StudentName.FieldName = "StudentName";
            this.StudentName.Name = "StudentName";
            // 
            // ShortcutKey
            // 
            this.ShortcutKey.Caption = "Tick";
            this.ShortcutKey.FieldName = "ShortcutKey";
            this.ShortcutKey.Name = "ShortcutKey";
            this.ShortcutKey.Visible = true;
            this.ShortcutKey.VisibleIndex = 4;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.m_txt_buoi);
            this.panel1.Controls.Add(this.m_sle_lop);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.m_lbl_header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 85);
            this.panel1.TabIndex = 3;
            // 
            // m_txt_buoi
            // 
            this.m_txt_buoi.EditValue = 0;
            this.m_txt_buoi.Location = new System.Drawing.Point(337, 53);
            this.m_txt_buoi.Name = "m_txt_buoi";
            this.m_txt_buoi.Properties.Mask.EditMask = "n0";
            this.m_txt_buoi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.m_txt_buoi.Size = new System.Drawing.Size(100, 20);
            this.m_txt_buoi.TabIndex = 4;
            // 
            // m_sle_lop
            // 
            this.m_sle_lop.EditValue = "";
            this.m_sle_lop.Location = new System.Drawing.Point(59, 53);
            this.m_sle_lop.Name = "m_sle_lop";
            this.m_sle_lop.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.m_sle_lop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_lop.Properties.NullText = "Chọn lớp";
            this.m_sle_lop.Properties.View = this.gridView1;
            this.m_sle_lop.Size = new System.Drawing.Size(228, 20);
            this.m_sle_lop.TabIndex = 2;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(306, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buổi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lớp";
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.imageList1;
            this.m_cmd_search.Location = new System.Drawing.Point(465, 48);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 3;
            this.m_cmd_search.Text = "Lọc dữ liệu";
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(802, 45);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "ĐIỂM DANH";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton2.Location = new System.Drawing.Point(0, 0);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 38);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Visible = false;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_cmd_diem_danh);
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 532);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 38);
            this.panel2.TabIndex = 6;
            // 
            // m_cmd_diem_danh
            // 
            this.m_cmd_diem_danh.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_diem_danh.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_diem_danh.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_diem_danh.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_diem_danh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_diem_danh.ImageList = this.imageList1;
            this.m_cmd_diem_danh.Location = new System.Drawing.Point(75, 0);
            this.m_cmd_diem_danh.Name = "m_cmd_diem_danh";
            this.m_cmd_diem_danh.Size = new System.Drawing.Size(101, 38);
            this.m_cmd_diem_danh.TabIndex = 6;
            this.m_cmd_diem_danh.Text = "Điểm danh";
            // 
            // f417_diem_danh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 570);
            this.Controls.Add(this.gridControlDiemDanh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f417_diem_danh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F417 - Điểm danh theo lớp";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDiemDanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiemDanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_buoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_lop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList ImageList;
        private DevExpress.XtraGrid.GridControl gridControlDiemDanh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDiemDanh;
        internal System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_lop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private System.Windows.Forms.Label m_lbl_header;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn StudentId;
        private DevExpress.XtraGrid.Columns.GridColumn PrefixName;
        private DevExpress.XtraGrid.Columns.GridColumn SuffixName;
        private DevExpress.XtraGrid.Columns.GridColumn StudentName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn StudentCode;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit m_txt_buoi;
        internal SIS.Controls.Button.SiSButton m_cmd_diem_danh;
        private DevExpress.XtraGrid.Columns.GridColumn ShortcutKey;
    }
}