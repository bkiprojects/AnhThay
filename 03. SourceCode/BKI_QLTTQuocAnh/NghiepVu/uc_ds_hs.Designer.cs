namespace BKI_QLTTQuocAnh.NghiepVu {
    partial class uc_ds_hs {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_DOI_TUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDT_HS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EMAIL_HS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.m_cbo_lop = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_search = new DevExpress.XtraEditors.SimpleButton();
            this.m_txt_search = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_search.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 101);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(563, 223);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.MA_DOI_TUONG,
            this.HO_TEN,
            this.SDT_HS,
            this.EMAIL_HS});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 51;
            // 
            // MA_DOI_TUONG
            // 
            this.MA_DOI_TUONG.Caption = "Mã HV";
            this.MA_DOI_TUONG.FieldName = "MA_DOI_TUONG";
            this.MA_DOI_TUONG.Name = "MA_DOI_TUONG";
            this.MA_DOI_TUONG.Visible = true;
            this.MA_DOI_TUONG.VisibleIndex = 0;
            this.MA_DOI_TUONG.Width = 37;
            // 
            // HO_TEN
            // 
            this.HO_TEN.Caption = "Họ tên";
            this.HO_TEN.FieldName = "HO_TEN";
            this.HO_TEN.Name = "HO_TEN";
            this.HO_TEN.Visible = true;
            this.HO_TEN.VisibleIndex = 1;
            this.HO_TEN.Width = 121;
            // 
            // SDT_HS
            // 
            this.SDT_HS.Caption = "SĐT";
            this.SDT_HS.FieldName = "SDT_HS";
            this.SDT_HS.Name = "SDT_HS";
            this.SDT_HS.Visible = true;
            this.SDT_HS.VisibleIndex = 2;
            this.SDT_HS.Width = 110;
            // 
            // EMAIL_HS
            // 
            this.EMAIL_HS.Caption = "Email";
            this.EMAIL_HS.FieldName = "EMAIL_HS";
            this.EMAIL_HS.Name = "EMAIL_HS";
            this.EMAIL_HS.Visible = true;
            this.EMAIL_HS.VisibleIndex = 3;
            this.EMAIL_HS.Width = 226;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lớp";
            // 
            // m_cbo_lop
            // 
            this.m_cbo_lop.BackColor = System.Drawing.SystemColors.Window;
            this.m_cbo_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_lop.FormattingEnabled = true;
            this.m_cbo_lop.Location = new System.Drawing.Point(110, 14);
            this.m_cbo_lop.Name = "m_cbo_lop";
            this.m_cbo_lop.Size = new System.Drawing.Size(121, 21);
            this.m_cbo_lop.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.m_txt_search);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_cbo_lop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 101);
            this.panel1.TabIndex = 3;
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.Location = new System.Drawing.Point(310, 47);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(59, 23);
            this.m_cmd_search.TabIndex = 6;
            this.m_cmd_search.Text = "Lọc";
            // 
            // m_txt_search
            // 
            this.m_txt_search.Location = new System.Drawing.Point(110, 48);
            this.m_txt_search.Name = "m_txt_search";
            this.m_txt_search.Size = new System.Drawing.Size(183, 20);
            this.m_txt_search.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm kiếm";
            // 
            // uc_ds_hs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panel1);
            this.Name = "uc_ds_hs";
            this.Size = new System.Drawing.Size(563, 324);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_search.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn MA_DOI_TUONG;
        private DevExpress.XtraGrid.Columns.GridColumn HO_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn SDT_HS;
        private DevExpress.XtraGrid.Columns.GridColumn EMAIL_HS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox m_cbo_lop;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_search;
        private DevExpress.XtraEditors.TextEdit m_txt_search;
        private System.Windows.Forms.Label label2;
    }
}
