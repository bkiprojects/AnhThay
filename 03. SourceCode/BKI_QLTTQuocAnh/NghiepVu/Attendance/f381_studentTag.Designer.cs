namespace BKI_QLTTQuocAnh.BaoCao {
    partial class f381_studentTag
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f381_studentTag));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.gridControlTag = new DevExpress.XtraGrid.GridControl();
            this.gridViewTag = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StudentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StudentCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PrefixName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SuffixName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StudentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Notes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemLookUpEditTag = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_sle_lop = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_lbl_header = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditTag)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_lop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            // gridControlTag
            // 
            this.gridControlTag.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTag.Location = new System.Drawing.Point(0, 117);
            this.gridControlTag.MainView = this.gridViewTag;
            this.gridControlTag.Name = "gridControlTag";
            this.gridControlTag.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemLookUpEditTag});
            this.gridControlTag.Size = new System.Drawing.Size(917, 465);
            this.gridControlTag.TabIndex = 2;
            this.gridControlTag.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTag});
            // 
            // gridViewTag
            // 
            this.gridViewTag.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.StudentId,
            this.STT,
            this.StudentCode,
            this.PrefixName,
            this.SuffixName,
            this.StudentName,
            this.Tag,
            this.Notes});
            this.gridViewTag.GridControl = this.gridControlTag;
            this.gridViewTag.GroupCount = 1;
            this.gridViewTag.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID_HOC_SINH", null, "(SL = {0:n0})")});
            this.gridViewTag.Name = "gridViewTag";
            this.gridViewTag.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewTag.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridViewTag.OptionsFind.AlwaysVisible = true;
            this.gridViewTag.OptionsFind.FindDelay = 100;
            this.gridViewTag.OptionsFind.FindNullPrompt = "Tìm kiếm...";
            this.gridViewTag.OptionsFind.ShowClearButton = false;
            this.gridViewTag.OptionsFind.ShowCloseButton = false;
            this.gridViewTag.OptionsView.ShowFooter = true;
            this.gridViewTag.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Tag, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewTag.DoubleClick += new System.EventHandler(this.gridView2_DoubleClick);
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
            this.StudentCode.Width = 98;
            // 
            // PrefixName
            // 
            this.PrefixName.Caption = "Họ";
            this.PrefixName.FieldName = "PrefixName";
            this.PrefixName.Name = "PrefixName";
            this.PrefixName.Visible = true;
            this.PrefixName.VisibleIndex = 2;
            this.PrefixName.Width = 84;
            // 
            // SuffixName
            // 
            this.SuffixName.Caption = "Tên";
            this.SuffixName.FieldName = "SuffixName";
            this.SuffixName.Name = "SuffixName";
            this.SuffixName.Visible = true;
            this.SuffixName.VisibleIndex = 3;
            this.SuffixName.Width = 142;
            // 
            // StudentName
            // 
            this.StudentName.Caption = "Họ tên";
            this.StudentName.FieldName = "StudentName";
            this.StudentName.Name = "StudentName";
            // 
            // Tag
            // 
            this.Tag.Caption = "Tag";
            this.Tag.FieldName = "TagName";
            this.Tag.Name = "Tag";
            this.Tag.Visible = true;
            this.Tag.VisibleIndex = 4;
            this.Tag.Width = 141;
            // 
            // Notes
            // 
            this.Notes.Caption = "Notes";
            this.Notes.FieldName = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.Visible = true;
            this.Notes.VisibleIndex = 4;
            this.Notes.Width = 395;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemLookUpEditTag
            // 
            this.repositoryItemLookUpEditTag.AutoHeight = false;
            this.repositoryItemLookUpEditTag.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditTag.DropDownRows = 5;
            this.repositoryItemLookUpEditTag.Name = "repositoryItemLookUpEditTag";
            this.repositoryItemLookUpEditTag.NullText = "";
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
            this.panel1.Controls.Add(this.m_cmd_delete);
            this.panel1.Controls.Add(this.m_cmd_update);
            this.panel1.Controls.Add(this.m_sle_lop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_cmd_insert);
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.m_lbl_header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 117);
            this.panel1.TabIndex = 3;
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 5;
            this.m_cmd_delete.Location = new System.Drawing.Point(128, 83);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(52, 28);
            this.m_cmd_delete.TabIndex = 5;
            this.m_cmd_delete.Text = "Xóa";
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_update.ImageIndex = 5;
            this.m_cmd_update.Location = new System.Drawing.Point(70, 83);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(52, 28);
            this.m_cmd_update.TabIndex = 4;
            this.m_cmd_update.Text = "Sửa";
            // 
            // m_sle_lop
            // 
            this.m_sle_lop.Location = new System.Drawing.Point(43, 53);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lớp";
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 5;
            this.m_cmd_insert.Location = new System.Drawing.Point(12, 83);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(52, 28);
            this.m_cmd_insert.TabIndex = 3;
            this.m_cmd_insert.Text = "Thêm";
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.imageList1;
            this.m_cmd_search.Location = new System.Drawing.Point(286, 48);
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
            this.m_lbl_header.Size = new System.Drawing.Size(917, 45);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "Ghi chú học viên";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // f381_studentTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 582);
            this.Controls.Add(this.gridControlTag);
            this.Controls.Add(this.panel1);
            this.Name = "f381_studentTag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F381 - Ghi chú học viên";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditTag)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_lop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList ImageList;
        private DevExpress.XtraGrid.GridControl gridControlTag;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTag;
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
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn StudentCode;
        private DevExpress.XtraGrid.Columns.GridColumn Tag;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditTag;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        private DevExpress.XtraGrid.Columns.GridColumn Notes;
    }
}