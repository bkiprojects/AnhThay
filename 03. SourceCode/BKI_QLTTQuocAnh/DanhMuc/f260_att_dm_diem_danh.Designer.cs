namespace BKI_QLTTQuocAnh.DanhMuc
{
    partial class f260_att_dm_diem_danh
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AttendanceTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AttendanceShortName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AttendanceLongName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ShortcutKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Notes = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl1.Size = new System.Drawing.Size(516, 396);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.AttendanceTypeId,
            this.AttendanceShortName,
            this.AttendanceLongName,
            this.ShortcutKey,
            this.Notes});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // AttendanceTypeId
            // 
            this.AttendanceTypeId.Caption = "AttendanceTypeId";
            this.AttendanceTypeId.FieldName = "AttendanceTypeId";
            this.AttendanceTypeId.Name = "AttendanceTypeId";
            // 
            // AttendanceShortName
            // 
            this.AttendanceShortName.Caption = "Tên ngắn";
            this.AttendanceShortName.FieldName = "AttendanceShortName";
            this.AttendanceShortName.Name = "AttendanceShortName";
            this.AttendanceShortName.Visible = true;
            this.AttendanceShortName.VisibleIndex = 1;
            this.AttendanceShortName.Width = 120;
            // 
            // AttendanceLongName
            // 
            this.AttendanceLongName.Caption = "Tên dài";
            this.AttendanceLongName.FieldName = "AttendanceLongName";
            this.AttendanceLongName.Name = "AttendanceLongName";
            this.AttendanceLongName.Visible = true;
            this.AttendanceLongName.VisibleIndex = 2;
            this.AttendanceLongName.Width = 172;
            // 
            // ShortcutKey
            // 
            this.ShortcutKey.Caption = "Kí tự điểm danh";
            this.ShortcutKey.FieldName = "ShortcutKey";
            this.ShortcutKey.Name = "ShortcutKey";
            this.ShortcutKey.Visible = true;
            this.ShortcutKey.VisibleIndex = 0;
            this.ShortcutKey.Width = 101;
            // 
            // Notes
            // 
            this.Notes.Caption = "Ghi chú";
            this.Notes.FieldName = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.Visible = true;
            this.Notes.VisibleIndex = 3;
            this.Notes.Width = 105;
            // 
            // f260_att_dm_diem_danh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 396);
            this.Controls.Add(this.gridControl1);
            this.Name = "f260_att_dm_diem_danh";
            this.Text = "F260 - Danh mục điểm danh";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn AttendanceTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn AttendanceShortName;
        private DevExpress.XtraGrid.Columns.GridColumn AttendanceLongName;
        private DevExpress.XtraGrid.Columns.GridColumn ShortcutKey;
        private DevExpress.XtraGrid.Columns.GridColumn Notes;
    }
}