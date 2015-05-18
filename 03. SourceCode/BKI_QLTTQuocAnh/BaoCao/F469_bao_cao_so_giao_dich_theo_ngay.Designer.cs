namespace BKI_QLTTQuocAnh.BaoCao {
    partial class F469_bao_cao_so_giao_dich_theo_ngay {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F469_bao_cao_so_giao_dich_theo_ngay));
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_txt_tong_tien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_dat_tai_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_tu_ngay = new System.Windows.Forms.Label();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Location = new System.Drawing.Point(12, 12);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(932, 78);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_fg);
            this.panel1.Controls.Add(this.m_txt_tong_tien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_lbl_header);
            this.panel1.Controls.Add(this.m_dat_tai_ngay);
            this.panel1.Controls.Add(this.m_lbl_tu_ngay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 108);
            this.panel1.TabIndex = 4;
            // 
            // m_txt_tong_tien
            // 
            this.m_txt_tong_tien.BackColor = System.Drawing.SystemColors.Info;
            this.m_txt_tong_tien.ForeColor = System.Drawing.Color.Maroon;
            this.m_txt_tong_tien.Location = new System.Drawing.Point(558, 70);
            this.m_txt_tong_tien.Name = "m_txt_tong_tien";
            this.m_txt_tong_tien.ReadOnly = true;
            this.m_txt_tong_tien.Size = new System.Drawing.Size(157, 20);
            this.m_txt_tong_tien.TabIndex = 19;
            this.m_txt_tong_tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tổng tiền";
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(1176, 45);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "BÁO CÁO SỔ GIAO DỊCH THEO NGÀY";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_dat_tai_ngay
            // 
            this.m_dat_tai_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dat_tai_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_tai_ngay.Location = new System.Drawing.Point(104, 70);
            this.m_dat_tai_ngay.Name = "m_dat_tai_ngay";
            this.m_dat_tai_ngay.Size = new System.Drawing.Size(196, 20);
            this.m_dat_tai_ngay.TabIndex = 4;
            // 
            // m_lbl_tu_ngay
            // 
            this.m_lbl_tu_ngay.AutoSize = true;
            this.m_lbl_tu_ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tu_ngay.Location = new System.Drawing.Point(3, 68);
            this.m_lbl_tu_ngay.Name = "m_lbl_tu_ngay";
            this.m_lbl_tu_ngay.Size = new System.Drawing.Size(95, 25);
            this.m_lbl_tu_ngay.TabIndex = 3;
            this.m_lbl_tu_ngay.Text = "Tại ngày";
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 108);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1176, 340);
            this.gridControl.TabIndex = 5;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            // 
            // F469_bao_cao_so_giao_dich_theo_ngay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 448);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panel1);
            this.Name = "F469_bao_cao_so_giao_dich_theo_ngay";
            this.Text = "F469_bao_cao_so_giao_dich_theo_ngay";
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label m_lbl_header;
        private System.Windows.Forms.DateTimePicker m_dat_tai_ngay;
        private System.Windows.Forms.Label m_lbl_tu_ngay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txt_tong_tien;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
    }
}