namespace BKI_QLTTQuocAnh.NghiepVu
{
    partial class f380_update_student_info
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
            this.m_cmd_load_hoc_vien = new DevExpress.XtraEditors.SimpleButton();
            this.m_sle_lop = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_save = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_import = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_export_excel = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.StudentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StudentCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Facebook = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Birthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CurrentWorkplace = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_lop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // m_cmd_load_hoc_vien
            // 
            this.m_cmd_load_hoc_vien.Location = new System.Drawing.Point(18, 42);
            this.m_cmd_load_hoc_vien.Name = "m_cmd_load_hoc_vien";
            this.m_cmd_load_hoc_vien.Size = new System.Drawing.Size(80, 23);
            this.m_cmd_load_hoc_vien.TabIndex = 6;
            this.m_cmd_load_hoc_vien.Text = "Lấy danh sách";
            this.m_cmd_load_hoc_vien.Click += new System.EventHandler(this.m_cmd_load_hoc_vien_Click);
            // 
            // m_sle_lop
            // 
            this.m_sle_lop.Location = new System.Drawing.Point(45, 16);
            this.m_sle_lop.Name = "m_sle_lop";
            this.m_sle_lop.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.m_sle_lop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_lop.Properties.NullText = "Chọn lớp";
            this.m_sle_lop.Properties.View = this.gridView1;
            this.m_sle_lop.Size = new System.Drawing.Size(346, 20);
            this.m_sle_lop.TabIndex = 8;
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
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lớp";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_sle_lop);
            this.panel1.Controls.Add(this.m_cmd_save);
            this.panel1.Controls.Add(this.m_cmd_import);
            this.panel1.Controls.Add(this.m_cmd_export_excel);
            this.panel1.Controls.Add(this.m_cmd_load_hoc_vien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 77);
            this.panel1.TabIndex = 9;
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.Location = new System.Drawing.Point(297, 42);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(94, 23);
            this.m_cmd_save.TabIndex = 6;
            this.m_cmd_save.Text = "Lưu";
            this.m_cmd_save.Click += new System.EventHandler(this.m_cmd_save_Click);
            // 
            // m_cmd_import
            // 
            this.m_cmd_import.Location = new System.Drawing.Point(197, 42);
            this.m_cmd_import.Name = "m_cmd_import";
            this.m_cmd_import.Size = new System.Drawing.Size(94, 23);
            this.m_cmd_import.TabIndex = 6;
            this.m_cmd_import.Text = "Import danh sách";
            this.m_cmd_import.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // m_cmd_export_excel
            // 
            this.m_cmd_export_excel.Location = new System.Drawing.Point(104, 42);
            this.m_cmd_export_excel.Name = "m_cmd_export_excel";
            this.m_cmd_export_excel.Size = new System.Drawing.Size(87, 23);
            this.m_cmd_export_excel.TabIndex = 6;
            this.m_cmd_export_excel.Text = "Xuất danh sách";
            this.m_cmd_export_excel.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl
            // 
            this.gridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 77);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit});
            this.gridControl.Size = new System.Drawing.Size(825, 464);
            this.gridControl.TabIndex = 10;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.StudentId,
            this.StudentCode,
            this.FirstName,
            this.LastName,
            this.PhoneNumber,
            this.Email,
            this.Facebook,
            this.Birthday,
            this.CurrentWorkplace});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // StudentId
            // 
            this.StudentId.Caption = "StudentId";
            this.StudentId.FieldName = "StudentId";
            this.StudentId.Name = "StudentId";
            // 
            // StudentCode
            // 
            this.StudentCode.Caption = "StudentCode";
            this.StudentCode.FieldName = "StudentCode";
            this.StudentCode.Name = "StudentCode";
            this.StudentCode.Visible = true;
            this.StudentCode.VisibleIndex = 0;
            // 
            // FirstName
            // 
            this.FirstName.Caption = "FirstName";
            this.FirstName.FieldName = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.Visible = true;
            this.FirstName.VisibleIndex = 1;
            // 
            // LastName
            // 
            this.LastName.Caption = "LastName";
            this.LastName.FieldName = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.Visible = true;
            this.LastName.VisibleIndex = 2;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Caption = "PhoneNumber";
            this.PhoneNumber.FieldName = "PhoneNumber";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Visible = true;
            this.PhoneNumber.VisibleIndex = 3;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 4;
            // 
            // Facebook
            // 
            this.Facebook.Caption = "Facebook";
            this.Facebook.FieldName = "Facebook";
            this.Facebook.Name = "Facebook";
            this.Facebook.Visible = true;
            this.Facebook.VisibleIndex = 5;
            // 
            // Birthday
            // 
            this.Birthday.Caption = "Birthday";
            this.Birthday.FieldName = "Birthday";
            this.Birthday.Name = "Birthday";
            this.Birthday.Visible = true;
            this.Birthday.VisibleIndex = 6;
            // 
            // CurrentWorkplace
            // 
            this.CurrentWorkplace.Caption = "CurrentWorkplace";
            this.CurrentWorkplace.FieldName = "CurrentWorkplace";
            this.CurrentWorkplace.Name = "CurrentWorkplace";
            this.CurrentWorkplace.Visible = true;
            this.CurrentWorkplace.VisibleIndex = 7;
            // 
            // repositoryItemCheckEdit
            // 
            this.repositoryItemCheckEdit.AutoHeight = false;
            this.repositoryItemCheckEdit.Caption = "Check";
            this.repositoryItemCheckEdit.Name = "repositoryItemCheckEdit";
            this.repositoryItemCheckEdit.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // f380_update_student_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 541);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panel1);
            this.Name = "f380_update_student_info";
            this.Text = "F380 - Cập nhật thông tin học viên";
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_lop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton m_cmd_load_hoc_vien;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_lop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_save;
        private DevExpress.XtraEditors.SimpleButton m_cmd_import;
        private DevExpress.XtraEditors.SimpleButton m_cmd_export_excel;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn StudentId;
        private DevExpress.XtraGrid.Columns.GridColumn StudentCode;
        private DevExpress.XtraGrid.Columns.GridColumn FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn LastName;
        private DevExpress.XtraGrid.Columns.GridColumn PhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn Facebook;
        private DevExpress.XtraGrid.Columns.GridColumn Birthday;
        private DevExpress.XtraGrid.Columns.GridColumn CurrentWorkplace;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit;
    }
}