namespace BKI_QLTTQuocAnh.NghiepVu.Attendance
{
    partial class f380_att_session_history
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f380_att_session_history));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_le_trang_thai_lop = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.gridControlDiemDanh = new DevExpress.XtraGrid.GridControl();
            this.gridViewDiemDanh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ClassId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClassCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClassDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CurrentSession = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Attendance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonAttendance = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_le_trang_thai_lop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDiemDanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiemDanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_le_trang_thai_lop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.m_lbl_header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 71);
            this.panel1.TabIndex = 4;
            // 
            // m_le_trang_thai_lop
            // 
            this.m_le_trang_thai_lop.Location = new System.Drawing.Point(92, 42);
            this.m_le_trang_thai_lop.Name = "m_le_trang_thai_lop";
            this.m_le_trang_thai_lop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_le_trang_thai_lop.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LongName", "Trạng thái"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DicionaryId", "ClassStatusId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.m_le_trang_thai_lop.Properties.DisplayMember = "LongName";
            this.m_le_trang_thai_lop.Properties.DropDownRows = 3;
            this.m_le_trang_thai_lop.Properties.NullText = "--Chọn trạng thái--";
            this.m_le_trang_thai_lop.Properties.ValueMember = "DictionaryId";
            this.m_le_trang_thai_lop.Size = new System.Drawing.Size(192, 20);
            this.m_le_trang_thai_lop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trạng thái lớp";
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.Location = new System.Drawing.Point(328, 37);
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
            this.m_lbl_header.Size = new System.Drawing.Size(821, 26);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "Quản lý điểm danh";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridControlDiemDanh
            // 
            this.gridControlDiemDanh.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlDiemDanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDiemDanh.Location = new System.Drawing.Point(0, 71);
            this.gridControlDiemDanh.MainView = this.gridViewDiemDanh;
            this.gridControlDiemDanh.Name = "gridControlDiemDanh";
            this.gridControlDiemDanh.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemButtonAttendance});
            this.gridControlDiemDanh.Size = new System.Drawing.Size(821, 413);
            this.gridControlDiemDanh.TabIndex = 7;
            this.gridControlDiemDanh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDiemDanh});
            // 
            // gridViewDiemDanh
            // 
            this.gridViewDiemDanh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ClassId,
            this.ClassCode,
            this.ClassDescription,
            this.CurrentSession,
            this.Attendance});
            this.gridViewDiemDanh.GridControl = this.gridControlDiemDanh;
            this.gridViewDiemDanh.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID_HOC_SINH", null, "(SL = {0:n0})")});
            this.gridViewDiemDanh.Name = "gridViewDiemDanh";
            this.gridViewDiemDanh.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewDiemDanh.OptionsFind.AlwaysVisible = true;
            this.gridViewDiemDanh.OptionsFind.FindDelay = 100;
            this.gridViewDiemDanh.OptionsFind.FindNullPrompt = "Tìm kiếm...";
            this.gridViewDiemDanh.OptionsFind.ShowClearButton = false;
            this.gridViewDiemDanh.OptionsFind.ShowCloseButton = false;
            this.gridViewDiemDanh.OptionsView.ShowFooter = true;
            // 
            // ClassId
            // 
            this.ClassId.Caption = "ClassId";
            this.ClassId.FieldName = "ClassId";
            this.ClassId.Name = "ClassId";
            // 
            // ClassCode
            // 
            this.ClassCode.Caption = "Mã lớp";
            this.ClassCode.FieldName = "ClassCode";
            this.ClassCode.Name = "ClassCode";
            this.ClassCode.Visible = true;
            this.ClassCode.VisibleIndex = 0;
            this.ClassCode.Width = 81;
            // 
            // ClassDescription
            // 
            this.ClassDescription.Caption = "Mô tả";
            this.ClassDescription.FieldName = "ClassDescription";
            this.ClassDescription.Name = "ClassDescription";
            this.ClassDescription.Visible = true;
            this.ClassDescription.VisibleIndex = 1;
            this.ClassDescription.Width = 153;
            // 
            // CurrentSession
            // 
            this.CurrentSession.Caption = "Buổi hiện tại";
            this.CurrentSession.FieldName = "CurrentSession";
            this.CurrentSession.Name = "CurrentSession";
            this.CurrentSession.Visible = true;
            this.CurrentSession.VisibleIndex = 2;
            this.CurrentSession.Width = 455;
            // 
            // Attendance
            // 
            this.Attendance.Caption = "Điểm danh";
            this.Attendance.ColumnEdit = this.repositoryItemButtonAttendance;
            this.Attendance.Name = "Attendance";
            this.Attendance.Visible = true;
            this.Attendance.VisibleIndex = 3;
            // 
            // repositoryItemButtonAttendance
            // 
            this.repositoryItemButtonAttendance.AutoHeight = false;
            this.repositoryItemButtonAttendance.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonAttendance.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonAttendance.Name = "repositoryItemButtonAttendance";
            this.repositoryItemButtonAttendance.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 484);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 38);
            this.panel2.TabIndex = 8;
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
            // 
            // f380_att_session_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 522);
            this.Controls.Add(this.gridControlDiemDanh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f380_att_session_history";
            this.Text = "F380 - Quản lý điểm danh";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_le_trang_thai_lop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDiemDanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiemDanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private System.Windows.Forms.Label m_lbl_header;
        private DevExpress.XtraEditors.LookUpEdit m_le_trang_thai_lop;
        private DevExpress.XtraGrid.GridControl gridControlDiemDanh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDiemDanh;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Columns.GridColumn ClassId;
        private DevExpress.XtraGrid.Columns.GridColumn ClassCode;
        private DevExpress.XtraGrid.Columns.GridColumn ClassDescription;
        private DevExpress.XtraGrid.Columns.GridColumn CurrentSession;
        private DevExpress.XtraGrid.Columns.GridColumn Attendance;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonAttendance;
    }
}