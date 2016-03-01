///************************************************
/// Generated by: Haihd
/// Date: 13/08/2015 06:26:13
/// Goal: Create Form for V_DM_LOP_MON
///************************************************


using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.DS.CDBNames;

using C1.Win.C1FlexGrid;

namespace BKI_QLTTQuocAnh.DanhMuc
{



    public class f210_dm_lop_mon2 : System.Windows.Forms.Form
    {
        #region Automatic ipcore
        internal System.Windows.Forms.ImageList ImageList;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        private Panel panel1;
        private Label m_lbl_trang_thai_lop;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private ComboBox m_cbo_trang_thai_lop;
        private Label m_lbl_header;
        internal Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_xoa_lop_mon;
        internal SIS.Controls.Button.SiSButton m_cmd_cho_lop_mon_hoat_dong;
        internal SIS.Controls.Button.SiSButton m_cmd_nghi_hoat_dong;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private System.ComponentModel.IContainer components;
        #endregion


        public f210_dm_lop_mon2()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            format_controls();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f210_dm_lop_mon2));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_lbl_trang_thai_lop = new System.Windows.Forms.Label();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_cbo_trang_thai_lop = new System.Windows.Forms.ComboBox();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_xoa_lop_mon = new SIS.Controls.Button.SiSButton();
            this.m_cmd_cho_lop_mon_hoat_dong = new SIS.Controls.Button.SiSButton();
            this.m_cmd_nghi_hoat_dong = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.panel1.SuspendLayout();
            this.m_pnl_out_place_dm.SuspendLayout();
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
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 98);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(934, 332);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_lbl_trang_thai_lop);
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.m_cbo_trang_thai_lop);
            this.panel1.Controls.Add(this.m_lbl_header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 98);
            this.panel1.TabIndex = 21;
            // 
            // m_lbl_trang_thai_lop
            // 
            this.m_lbl_trang_thai_lop.AutoSize = true;
            this.m_lbl_trang_thai_lop.Location = new System.Drawing.Point(12, 57);
            this.m_lbl_trang_thai_lop.Name = "m_lbl_trang_thai_lop";
            this.m_lbl_trang_thai_lop.Size = new System.Drawing.Size(72, 13);
            this.m_lbl_trang_thai_lop.TabIndex = 1;
            this.m_lbl_trang_thai_lop.Text = "Trạng thái lớp";
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(255, 49);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 3;
            this.m_cmd_search.Text = "Lọc dữ liệu";
            // 
            // m_cbo_trang_thai_lop
            // 
            this.m_cbo_trang_thai_lop.FormattingEnabled = true;
            this.m_cbo_trang_thai_lop.Location = new System.Drawing.Point(98, 54);
            this.m_cbo_trang_thai_lop.Name = "m_cbo_trang_thai_lop";
            this.m_cbo_trang_thai_lop.Size = new System.Drawing.Size(151, 21);
            this.m_cbo_trang_thai_lop.TabIndex = 2;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(934, 39);
            this.m_lbl_header.TabIndex = 0;
            this.m_lbl_header.Text = "DANH SÁCH LỚP";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xoa_lop_mon);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_cho_lop_mon_hoat_dong);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_nghi_hoat_dong);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 430);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(934, 52);
            this.m_pnl_out_place_dm.TabIndex = 22;
            // 
            // m_cmd_xoa_lop_mon
            // 
            this.m_cmd_xoa_lop_mon.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_xoa_lop_mon.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_xoa_lop_mon.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_xoa_lop_mon.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xoa_lop_mon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_xoa_lop_mon.ImageIndex = 4;
            this.m_cmd_xoa_lop_mon.ImageList = this.ImageList;
            this.m_cmd_xoa_lop_mon.Location = new System.Drawing.Point(555, 4);
            this.m_cmd_xoa_lop_mon.Name = "m_cmd_xoa_lop_mon";
            this.m_cmd_xoa_lop_mon.Size = new System.Drawing.Size(117, 44);
            this.m_cmd_xoa_lop_mon.TabIndex = 5;
            this.m_cmd_xoa_lop_mon.Text = "Xóa lớp";
            this.m_cmd_xoa_lop_mon.Visible = false;
            // 
            // m_cmd_cho_lop_mon_hoat_dong
            // 
            this.m_cmd_cho_lop_mon_hoat_dong.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_cho_lop_mon_hoat_dong.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_cho_lop_mon_hoat_dong.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_cho_lop_mon_hoat_dong.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_cho_lop_mon_hoat_dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_cho_lop_mon_hoat_dong.ImageIndex = 13;
            this.m_cmd_cho_lop_mon_hoat_dong.ImageList = this.ImageList;
            this.m_cmd_cho_lop_mon_hoat_dong.Location = new System.Drawing.Point(434, 4);
            this.m_cmd_cho_lop_mon_hoat_dong.Name = "m_cmd_cho_lop_mon_hoat_dong";
            this.m_cmd_cho_lop_mon_hoat_dong.Size = new System.Drawing.Size(121, 44);
            this.m_cmd_cho_lop_mon_hoat_dong.TabIndex = 4;
            this.m_cmd_cho_lop_mon_hoat_dong.Text = "&Cho lớp hoạt động";
            this.m_cmd_cho_lop_mon_hoat_dong.Visible = false;
            // 
            // m_cmd_nghi_hoat_dong
            // 
            this.m_cmd_nghi_hoat_dong.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_nghi_hoat_dong.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_nghi_hoat_dong.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_nghi_hoat_dong.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_nghi_hoat_dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_nghi_hoat_dong.ImageIndex = 11;
            this.m_cmd_nghi_hoat_dong.ImageList = this.ImageList;
            this.m_cmd_nghi_hoat_dong.Location = new System.Drawing.Point(313, 4);
            this.m_cmd_nghi_hoat_dong.Name = "m_cmd_nghi_hoat_dong";
            this.m_cmd_nghi_hoat_dong.Size = new System.Drawing.Size(121, 44);
            this.m_cmd_nghi_hoat_dong.TabIndex = 3;
            this.m_cmd_nghi_hoat_dong.Text = "&Nghỉ hoạt dộng";
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
            this.m_cmd_update.Location = new System.Drawing.Point(202, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(111, 44);
            this.m_cmd_update.TabIndex = 2;
            this.m_cmd_update.Text = "&Sửa lớp";
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 2;
            this.m_cmd_insert.ImageList = this.ImageList;
            this.m_cmd_insert.Location = new System.Drawing.Point(92, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(110, 44);
            this.m_cmd_insert.TabIndex = 1;
            this.m_cmd_insert.Text = "&Thêm lớp";
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
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(88, 44);
            this.m_cmd_xuat_excel.TabIndex = 0;
            this.m_cmd_xuat_excel.Text = "Xuất excel";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(842, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 44);
            this.m_cmd_exit.TabIndex = 6;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // f210_dm_lop_mon2
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(934, 482);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.panel1);
            this.Name = "f210_dm_lop_mon2";
            this.Text = "F210 - Danh sách lớp";
            this.Load += new System.EventHandler(this.f210_dm_lop_mon2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            MA_LOP_MON = 1
,
            MO_TA = 2
                ,
            THOI_GIAN_HOC_FROM_DATE = 4
                ,
            DON_GIA_BUOI_HOC = 3
                ,
            MOT_NAM_SAU_NGAY_KET_THUC = 6
                , THOI_GIAN_HOC_TO_DATE = 5

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_DM_LOP_MON m_ds = new DS_V_DM_LOP_MON();
        US_V_DM_LOP_MON m_us = new US_V_DM_LOP_MON();
        decimal m_op_dc_id_lop_mon = 0;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));

            set_define_events();
            m_cmd_xuat_excel.Visible = false;
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            CCommon.load_data_2_cbo_trang_thai_lop_mon(CONST_LOAI_TU_DIEN.TRANG_THAI_LOP_MON, m_cbo_trang_thai_lop);
            m_obj_trans = get_trans_object(m_fg);
            m_cbo_trang_thai_lop.SelectedIndexChanged += m_cbo_trang_thai_lop_SelectedIndexChanged;
            load_data_2_grid();
        }

        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_LOP_MON.MA_LOP_MON, e_col_Number.MA_LOP_MON);
            v_htb.Add(V_DM_LOP_MON.MO_TA, e_col_Number.MO_TA);
            v_htb.Add(V_DM_LOP_MON.THOI_GIAN_HOC_FROM_DATE, e_col_Number.THOI_GIAN_HOC_FROM_DATE);
            v_htb.Add(V_DM_LOP_MON.DON_GIA_BUOI_HOC, e_col_Number.DON_GIA_BUOI_HOC);
            v_htb.Add(V_DM_LOP_MON.MOT_NAM_SAU_NGAY_KET_THUC, e_col_Number.MOT_NAM_SAU_NGAY_KET_THUC);
            v_htb.Add(V_DM_LOP_MON.THOI_GIAN_HOC_TO_DATE, e_col_Number.THOI_GIAN_HOC_TO_DATE);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_DM_LOP_MON.NewRow());
            return v_obj_trans;
        }

        private void load_data_2_grid()
        {
            m_ds = new DS_V_DM_LOP_MON();
            m_us.FillDataset(m_ds, "Where TRANG_THAI_LOP_MON =" + CIPConvert.ToDecimal(m_cbo_trang_thai_lop.SelectedValue));
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_fg);
            m_fg.Redraw = true;
        }

        private void grid2us_object(US_V_DM_LOP_MON i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }

        private void us_object2grid(US_V_DM_LOP_MON i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }

        private void insert_v_dm_lop_mon()
        {
            f211_dm_lop_mon_de v_fDE = new f211_dm_lop_mon_de();
            v_fDE.display_4_insert();
            load_data_2_grid();
        }

        private void update_v_dm_lop_mon()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);

            US_DM_LOP_MON v_us = new US_DM_LOP_MON(m_op_dc_id_lop_mon);
            f211_dm_lop_mon_de v_fDE = new f211_dm_lop_mon_de();
            v_fDE.display_4_update(v_us);
            load_data_2_grid();
        }

        private void update_V_DM_LOP_MON_2_un_used()
        {
            //f211_V_DM_LOP_MON_de v_fDE = new f211_V_DM_LOP_MON_de();
            //v_fDE.display_4_update(m_us);
            if (DialogResult.Yes == BaseMessages.MsgBox_YES_NO_CANCEL("Bạn có chắc chắc muốn lớp này nghỉ hoạt động không?"))
            {
                US_V_DM_LOP_MON v_us_V_DM_LOP_MON = new US_V_DM_LOP_MON(m_op_dc_id_lop_mon);
                v_us_V_DM_LOP_MON.dcTRANG_THAI_LOP_MON = 89;
                v_us_V_DM_LOP_MON.Update();
                BaseMessages.MsgBox_Infor("Xong!!!");
                load_data_2_grid();
            }
        }

        private void update_V_DM_LOP_MON_2_used()
        {
            if (DialogResult.Yes == BaseMessages.MsgBox_YES_NO_CANCEL("Bạn có chắc chắc muốn lớp này hoạt động không?"))
            {
                US_V_DM_LOP_MON v_us_V_DM_LOP_MON = new US_V_DM_LOP_MON(m_op_dc_id_lop_mon);
                //try
                //{
                //    v_us_V_DM_LOP_MON.BeginTransaction();
                //    v_us_V_DM_LOP_MON.update_by_proc(v_us_V_DM_LOP_MON.strMA_LOP_MON);
                //    v_us_V_DM_LOP_MON.CommitTransaction();
                //    //m_fg.Rows.Remove(m_fg.Row);
                //}
                //catch (Exception v_e)
                //{
                //    v_us_V_DM_LOP_MON.Rollback();
                //    CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                //        new CDBClientDBExceptionInterpret());
                //    v_objErrHandler.showErrorMessage();
                //}
                v_us_V_DM_LOP_MON.dcTRANG_THAI_LOP_MON = 88;
                v_us_V_DM_LOP_MON.Update();
                BaseMessages.MsgBox_Infor("Xong!!!");
                load_data_2_grid();
            }
        }


        private void delete_v_dm_lop_mon()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_DM_LOP_MON v_us = new US_V_DM_LOP_MON();
            grid2us_object(v_us, m_fg.Row);
            try
            {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_fg.Rows.Remove(m_fg.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_v_dm_lop_mon()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	f210_dm_lop_mon2_DE v_fDE = new f210_dm_lop_mon2_DE();			
            //	v_fDE.display(m_us);
        }

        #endregion

        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_search.Click += new EventHandler(m_cmd_search_Click);
            m_cmd_nghi_hoat_dong.Click += m_cmd_nghi_hoat_dong_Click;
            m_cmd_cho_lop_mon_hoat_dong.Click += m_cmd_cho_lop_mon_hoat_dong_Click;
            this.KeyDown += f210_dm_lop_mon2_KeyDown;
            m_fg.Click += m_fg_Click;
        }

        private void f210_dm_lop_mon2_Load(object sender, System.EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                insert_v_dm_lop_mon();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                update_v_dm_lop_mon();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f210_dm_lop_mon2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    load_data_2_grid();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cbo_trang_thai_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
                if (CIPConvert.ToDecimal(m_cbo_trang_thai_lop.SelectedValue) == 89)
                {
                    m_cmd_nghi_hoat_dong.Visible = false;
                    m_cmd_cho_lop_mon_hoat_dong.Visible = true;
                }
                else
                {
                    m_cmd_nghi_hoat_dong.Visible = true;
                    m_cmd_cho_lop_mon_hoat_dong.Visible = false;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_fg_Click(object sender, EventArgs e)
        {
            try
            {
                US_V_DM_LOP_MON v_us = new US_V_DM_LOP_MON();

                if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
                if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;

                grid2us_object(v_us, m_fg.Row);

                m_op_dc_id_lop_mon = v_us.dcID;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nghi_hoat_dong_Click(object sender, EventArgs e)
        {
            try
            {
                update_V_DM_LOP_MON_2_un_used();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_cho_lop_mon_hoat_dong_Click(object sender, EventArgs e)
        {
            try
            {
                update_V_DM_LOP_MON_2_used();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}

