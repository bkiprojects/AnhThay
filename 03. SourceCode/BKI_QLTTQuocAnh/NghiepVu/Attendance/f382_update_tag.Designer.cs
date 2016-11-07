namespace BKI_QLTTQuocAnh.NghiepVu.Attendance
{
    partial class f382_update_tag
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_save = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_exit = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.m_txt_note = new DevExpress.XtraEditors.MemoEdit();
            this.m_le_tag = new DevExpress.XtraEditors.LookUpEdit();
            this.m_sle_lop = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_sle_ma_hv = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PrefixName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SuffixName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StudentCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BirthDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_lbl_ma_hoc_sinh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_note.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_le_tag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_lop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_ma_hv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_cmd_save);
            this.panelControl1.Controls.Add(this.m_cmd_exit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 249);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(428, 38);
            this.panelControl1.TabIndex = 0;
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_save.Location = new System.Drawing.Point(276, 2);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(75, 34);
            this.m_cmd_save.TabIndex = 0;
            this.m_cmd_save.Text = "Lưu";
            this.m_cmd_save.Click += new System.EventHandler(this.m_cmd_save_Click);
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.Location = new System.Drawing.Point(351, 2);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(75, 34);
            this.m_cmd_exit.TabIndex = 1;
            this.m_cmd_exit.Text = "Thoát";
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.m_txt_note);
            this.panelControl2.Controls.Add(this.m_le_tag);
            this.panelControl2.Controls.Add(this.m_sle_lop);
            this.panelControl2.Controls.Add(this.m_sle_ma_hv);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.m_lbl_ma_hoc_sinh);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(428, 249);
            this.panelControl2.TabIndex = 1;
            // 
            // m_txt_note
            // 
            this.m_txt_note.Location = new System.Drawing.Point(141, 129);
            this.m_txt_note.Name = "m_txt_note";
            this.m_txt_note.Size = new System.Drawing.Size(263, 96);
            this.m_txt_note.TabIndex = 17;
            // 
            // m_le_tag
            // 
            this.m_le_tag.Location = new System.Drawing.Point(141, 89);
            this.m_le_tag.Name = "m_le_tag";
            this.m_le_tag.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_le_tag.Properties.DisplayMember = "TagName";
            this.m_le_tag.Properties.NullText = "--Chọn tag--";
            this.m_le_tag.Properties.ValueMember = "TagId";
            this.m_le_tag.Size = new System.Drawing.Size(263, 20);
            this.m_le_tag.TabIndex = 16;
            // 
            // m_sle_lop
            // 
            this.m_sle_lop.EditValue = "";
            this.m_sle_lop.Location = new System.Drawing.Point(141, 24);
            this.m_sle_lop.Name = "m_sle_lop";
            this.m_sle_lop.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.m_sle_lop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_lop.Properties.NullText = "Chọn lớp";
            this.m_sle_lop.Properties.View = this.gridView1;
            this.m_sle_lop.Size = new System.Drawing.Size(263, 20);
            this.m_sle_lop.TabIndex = 13;
            this.m_sle_lop.EditValueChanged += new System.EventHandler(this.m_sle_lop_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // m_sle_ma_hv
            // 
            this.m_sle_ma_hv.EditValue = "";
            this.m_sle_ma_hv.Location = new System.Drawing.Point(141, 54);
            this.m_sle_ma_hv.Name = "m_sle_ma_hv";
            this.m_sle_ma_hv.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.m_sle_ma_hv.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_ma_hv.Properties.DisplayMember = "StudentName";
            this.m_sle_ma_hv.Properties.NullText = "Chọn HV";
            this.m_sle_ma_hv.Properties.ValueMember = "StudentId";
            this.m_sle_ma_hv.Properties.View = this.searchLookUpEdit1View;
            this.m_sle_ma_hv.Size = new System.Drawing.Size(263, 20);
            this.m_sle_ma_hv.TabIndex = 15;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PrefixName,
            this.SuffixName,
            this.StudentCode,
            this.BirthDay});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // PrefixName
            // 
            this.PrefixName.Caption = "Họ";
            this.PrefixName.FieldName = "PrefixName";
            this.PrefixName.Name = "PrefixName";
            this.PrefixName.Visible = true;
            this.PrefixName.VisibleIndex = 1;
            this.PrefixName.Width = 124;
            // 
            // SuffixName
            // 
            this.SuffixName.Caption = "Tên";
            this.SuffixName.FieldName = "SuffixName";
            this.SuffixName.Name = "SuffixName";
            this.SuffixName.Visible = true;
            this.SuffixName.VisibleIndex = 2;
            this.SuffixName.Width = 177;
            // 
            // StudentCode
            // 
            this.StudentCode.Caption = "Mã học viên";
            this.StudentCode.FieldName = "StudentCode";
            this.StudentCode.Name = "StudentCode";
            this.StudentCode.Visible = true;
            this.StudentCode.VisibleIndex = 0;
            this.StudentCode.Width = 97;
            // 
            // BirthDay
            // 
            this.BirthDay.Caption = "Ngày sinh";
            this.BirthDay.FieldName = "BirthDay";
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Visible = true;
            this.BirthDay.VisibleIndex = 3;
            this.BirthDay.Width = 298;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tag(*)";
            // 
            // m_lbl_ma_hoc_sinh
            // 
            this.m_lbl_ma_hoc_sinh.AutoSize = true;
            this.m_lbl_ma_hoc_sinh.Location = new System.Drawing.Point(20, 57);
            this.m_lbl_ma_hoc_sinh.Name = "m_lbl_ma_hoc_sinh";
            this.m_lbl_ma_hoc_sinh.Size = new System.Drawing.Size(50, 13);
            this.m_lbl_ma_hoc_sinh.TabIndex = 14;
            this.m_lbl_ma_hoc_sinh.Text = "Mã HV(*)";
            // 
            // f382_update_tag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 287);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "f382_update_tag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F382 - Thêm/Sửa tag";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_note.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_le_tag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_lop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_ma_hv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_save;
        private DevExpress.XtraEditors.SimpleButton m_cmd_exit;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LookUpEdit m_le_tag;
        public DevExpress.XtraEditors.SearchLookUpEdit m_sle_lop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraEditors.SearchLookUpEdit m_sle_ma_hv;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label m_lbl_ma_hoc_sinh;
        private DevExpress.XtraEditors.MemoEdit m_txt_note;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn PrefixName;
        private DevExpress.XtraGrid.Columns.GridColumn SuffixName;
        private DevExpress.XtraGrid.Columns.GridColumn StudentCode;
        private DevExpress.XtraGrid.Columns.GridColumn BirthDay;
    }
}