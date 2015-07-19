using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPData;
using IP.Core.IPUserService;
using BKI_QLTTQuocAnh.DS.CDBNames;
using System.Collections;

namespace BKI_QLTTQuocAnh.NghiepVu
{
    public partial class f370_chuyen_lop_cho_hoc_vien : Form
    {
        public f370_chuyen_lop_cho_hoc_vien()
        {
            InitializeComponent();
            format_controls();
        }

        #region Data Structure
        private enum e_col_Number
        {
            HO_TEN_PH = 7
,
            SO_PHIEU = 3
                ,
            NGAY_THU = 1
                ,
            TEN_LOAI_PHIEU_THU = 2
                ,
            TIEN_THUC_THU = 11
                ,
            TIEN_GIAM_TRU = 10
                ,
            MA_HOC_SINH = 5
                ,
            NOI_DUNG = 4
                ,
            TIEN_CON_PHAI_THU = 12
                ,
            TEN_NGUOI_THU = 8
                ,
            TIEN_PHAI_THU = 9
                , HO_TEN_HS = 6

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU m_ds = new DS_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU();
        US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU m_us = new US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU();
        DS_DM_LOP_MON m_ds_dm_lop_mon = new DS_DM_LOP_MON();
        DS_V_GD_HOC m_ds_v_gd_hoc = new DS_V_GD_HOC();
        DS_DM_HOC_SINH m_ds_hs = new DS_DM_HOC_SINH();
        DS_GD_PHIEU_THU m_ds_phieu_thu = new DS_GD_PHIEU_THU();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);//Xuat excel
            CGridUtils.AddSearch_Handlers(m_fg);//Ctrl F dc

            m_fg.Tree.Column = (int)e_col_Number.NGAY_THU;
            m_fg.Tree.Style = TreeStyleFlags.SimpleLeaf;
            m_fg.Cols[(int)e_col_Number.TIEN_CON_PHAI_THU].Visible = false;
            m_fg.Cols[(int)e_col_Number.TIEN_GIAM_TRU].Visible = false;
            m_fg.Cols[(int)e_col_Number.TIEN_PHAI_THU].Visible = false;

            m_cmd_update.Visible = false;
            m_cmd_delete.Visible = false;

            m_fg.Styles[CellStyleEnum.Normal].WordWrap = true;
            // m_fg.AllowResizing = AllowResizingEnum.Rows;
            m_fg.AutoSizeRows();

            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_ten_hs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_buoc_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_buoc_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_tong_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_txt_tong_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            set_define_events();
            this.KeyPreview = true;
        }
        private void wrap_text_cell()
        {
            m_fg.Styles[CellStyleEnum.Normal].WordWrap = true;
            m_fg.AllowResizing = AllowResizingEnum.Rows;
            m_fg.AutoSizeRows();
        }
        private void grid2us_object(US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.HO_TEN_PH, e_col_Number.HO_TEN_PH);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.SO_PHIEU, e_col_Number.SO_PHIEU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.NGAY_THU, e_col_Number.NGAY_THU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TEN_LOAI_PHIEU_THU, e_col_Number.TEN_LOAI_PHIEU_THU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TIEN_THUC_THU, e_col_Number.TIEN_THUC_THU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TIEN_GIAM_TRU, e_col_Number.TIEN_GIAM_TRU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.MA_HOC_SINH, e_col_Number.MA_HOC_SINH);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.NOI_DUNG, e_col_Number.NOI_DUNG);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TIEN_CON_PHAI_THU, e_col_Number.TIEN_CON_PHAI_THU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TEN_NGUOI_THU, e_col_Number.TEN_NGUOI_THU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TIEN_PHAI_THU, e_col_Number.TIEN_PHAI_THU);
            v_htb.Add(V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.HO_TEN_HS, e_col_Number.HO_TEN_HS);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.NewRow());
            return v_obj_trans;
        }
        private void create_tree_2grid()
        {
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);

            m_fg.Subtotal(AggregateEnum.Sum
                , 0
                , -1
                , (int)e_col_Number.TIEN_PHAI_THU
                , "Tổng cộng");
            m_fg.Subtotal(AggregateEnum.Sum
                , 0
                , -1
                , (int)e_col_Number.TIEN_GIAM_TRU
                , "Tổng cộng");
            m_fg.Subtotal(AggregateEnum.Sum
                , 0
                , -1
                , (int)e_col_Number.TIEN_THUC_THU
                , "Tổng cộng");
            m_fg.Subtotal(AggregateEnum.Sum
             , 0
             , -1
             , (int)e_col_Number.TIEN_CON_PHAI_THU
             , "Tổng cộng");

            m_fg.Redraw = true;
        }

        private void load_data_2_ds_gd_phieu_thu()
        {
            //Đẩy dữ liệu vào DS_GD_PHIEU_THU
            US_GD_PHIEU_THU v_us_phieu_thu = new US_GD_PHIEU_THU();
            m_ds_phieu_thu.Clear();
            m_ds_phieu_thu.EnforceConstraints = false;
            v_us_phieu_thu.FillDataset(m_ds_phieu_thu);
        }

        private DS_DM_LOP_MON load_data_2_ds_dm_lop()
        {
            DS_DM_LOP_MON v_ds = new DS_DM_LOP_MON();
            US_DM_LOP_MON v_us = new US_DM_LOP_MON();
            string v_str_filter = "where TRANG_THAI_LOP_MON = " + CONST_TRANG_THAI_LOP_MON.DANG_HOAT_DONG;
            v_ds.Clear();
            v_ds.EnforceConstraints = false;
            v_us.FillDataset(v_ds, v_str_filter);

            return v_ds;
        }

        private void load_data_to_sle_lop()
        {
            //Chinh hien thi nguoi dung
            m_sle_lop.Properties.DataSource = load_data_2_ds_dm_lop().DM_LOP_MON;
            m_sle_lop.Properties.DisplayMember = DM_LOP_MON.MO_TA;
            m_sle_lop.Properties.ValueMember = DM_LOP_MON.ID;

            m_sle_lop.Properties.PopulateViewColumns();
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.ID].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.ID_LOP].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.ID_MON].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.TRANG_THAI_LOP_MON].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.DON_GIA_BUOI_HOC].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.TONG_TIEN_KHOA_HOC].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.TONG_SO_BUOI_HOC].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.THOI_GIAN_HOC_TO_DATE].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.THOI_GIAN_HOC_FROM_DATE].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.GHI_CHU].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.ID_TRO_GIANG].Visible = false;

            m_sle_lop.Properties.View.Columns[DM_LOP_MON.MO_TA].Width = 300;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.MA_LOP_MON].Width = 150;

            m_sle_lop.Properties.View.Columns[DM_LOP_MON.MA_LOP_MON].Caption = "Mã lớp";
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.MO_TA].Caption = "Chọn tên lớp";

            m_sle_lop.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_lop.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_to_sle_lop_2()
        {
            //Chinh hien thi nguoi dung
            m_sle_lop_2.Properties.DataSource = load_data_2_ds_dm_lop().DM_LOP_MON;
            m_sle_lop_2.Properties.DisplayMember = DM_LOP_MON.MO_TA;
            m_sle_lop_2.Properties.ValueMember = DM_LOP_MON.ID;

            m_sle_lop_2.Properties.PopulateViewColumns();
            m_sle_lop_2.Properties.View.Columns[DM_LOP_MON.ID].Visible = false;
            m_sle_lop_2.Properties.View.Columns[DM_LOP_MON.ID_LOP].Visible = false;
            m_sle_lop_2.Properties.View.Columns[DM_LOP_MON.ID_MON].Visible = false;
            m_sle_lop_2.Properties.View.Columns[DM_LOP_MON.TRANG_THAI_LOP_MON].Visible = false;
            m_sle_lop_2.Properties.View.Columns[DM_LOP_MON.DON_GIA_BUOI_HOC].Visible = false;
            m_sle_lop_2.Properties.View.Columns[DM_LOP_MON.TONG_TIEN_KHOA_HOC].Visible = false;
            m_sle_lop_2.Properties.View.Columns[DM_LOP_MON.TONG_SO_BUOI_HOC].Visible = false;
            m_sle_lop_2.Properties.View.Columns[DM_LOP_MON.THOI_GIAN_HOC_TO_DATE].Visible = false;
            m_sle_lop_2.Properties.View.Columns[DM_LOP_MON.THOI_GIAN_HOC_FROM_DATE].Visible = false;
            m_sle_lop_2.Properties.View.Columns[DM_LOP_MON.GHI_CHU].Visible = false;
            m_sle_lop_2.Properties.View.Columns[DM_LOP_MON.ID_TRO_GIANG].Visible = false;

            m_sle_lop_2.Properties.View.Columns[DM_LOP_MON.MO_TA].Width = 300;
            m_sle_lop_2.Properties.View.Columns[DM_LOP_MON.MA_LOP_MON].Width = 150;

            m_sle_lop_2.Properties.View.Columns[DM_LOP_MON.MA_LOP_MON].Caption = "Mã lớp";
            m_sle_lop_2.Properties.View.Columns[DM_LOP_MON.MO_TA].Caption = "Chọn tên lớp";

            m_sle_lop_2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_lop_2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }


        private void load_data_2_ds_dm_hoc_sinh()
        {
            //Đẩy dữ liệu vào DS_DM_HS
            US_DM_HOC_SINH v_us_hs = new US_DM_HOC_SINH();
            m_ds_hs.Clear();
            m_ds_hs.EnforceConstraints = false;
            v_us_hs.FillDataset(m_ds_hs, "where id_loai_doi_tuong = " + CONST_ID_LOAI_DOI_TUONG.ID_HOC_SINH);
        }

        //private void load_data_2_ds_dm_lop()
        //{
        //    US_DM_LOP_MON v_us = new US_DM_LOP_MON();
        //    string v_str_filter = "where TRANG_THAI_LOP_MON = " + CONST_TRANG_THAI_LOP_MON.DANG_HOAT_DONG;
        //    m_ds_dm_lop_mon.Clear();
        //    m_ds_dm_lop_mon.EnforceConstraints = false;
        //    v_us.FillDataset(m_ds_dm_lop_mon, v_str_filter);
        //}

        //private void load_data_to_sle_lop()
        //{
        //    load_data_2_ds_dm_lop();

        //    //Chinh hien thi nguoi dung
        //    m_sle_lop.Properties.DataSource = m_ds_dm_lop_mon.DM_LOP_MON;
        //    m_sle_lop.Properties.DisplayMember = DM_LOP_MON.MO_TA;
        //    m_sle_lop.Properties.ValueMember = DM_LOP_MON.ID;

        //    m_sle_lop.Properties.PopulateViewColumns();
        //    m_sle_lop.Properties.View.Columns[DM_LOP_MON.ID].Visible = false;
        //    m_sle_lop.Properties.View.Columns[DM_LOP_MON.ID_LOP].Visible = false;
        //    m_sle_lop.Properties.View.Columns[DM_LOP_MON.ID_MON].Visible = false;
        //    m_sle_lop.Properties.View.Columns[DM_LOP_MON.TRANG_THAI_LOP_MON].Visible = false;
        //    m_sle_lop.Properties.View.Columns[DM_LOP_MON.MA_LOP_MON].Visible = false;
        //    m_sle_lop.Properties.View.Columns[DM_LOP_MON.DON_GIA_BUOI_HOC].Visible = false;

        //    m_sle_lop.Properties.View.Columns[DM_LOP_MON.MO_TA].Width = 300;
        //    m_sle_lop.Properties.View.Columns[DM_LOP_MON.MA_LOP_MON].Width = 150;

        //    m_sle_lop.Properties.View.Columns[DM_LOP_MON.MA_LOP_MON].Caption = "Mã lớp";
        //    m_sle_lop.Properties.View.Columns[DM_LOP_MON.MO_TA].Caption = "Chọn tên lớp";

        //    m_sle_lop.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        //    m_sle_lop.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        //}



        private void load_data_2_ds_v_gd_hoc()
        {
            try
            {
                m_ds_v_gd_hoc.Clear();
                m_ds_v_gd_hoc.EnforceConstraints = false;
                US_V_GD_HOC v_us_v_gd_hoc = new US_V_GD_HOC();
                if (m_sle_lop.EditValue != "" && m_sle_lop.EditValue != null)
                {
                    string v_str_filter = "where id_lop_mon = " + CIPConvert.ToDecimal(m_sle_lop.EditValue) + " and TRANG_THAI_YN = 'Y'";
                    v_us_v_gd_hoc.FillDataset(m_ds_v_gd_hoc, v_str_filter);
                }
            }
            catch (Exception v_e)
            {
                throw v_e;
            }
            //Đẩy dữ liệu vào DS_V_GD_HOC
        }

        private void load_data_to_sle_ma_hv()
        {
            load_data_2_ds_v_gd_hoc();

            //Gan datasource, display, value member
            m_sle_ma_hv.Properties.DataSource = m_ds_v_gd_hoc.V_GD_HOC;
            m_sle_ma_hv.Properties.ValueMember = V_GD_HOC.ID_HOC_SINH;
            m_sle_ma_hv.Properties.DisplayMember = V_GD_HOC.MA_DOI_TUONG;

            //Chinh hien thi nguoi dung
            m_sle_ma_hv.Properties.PopulateViewColumns();
            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.ID].Visible = false;
            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.ID_HOC_SINH].Visible = false;
            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.ID_LOP_MON].Visible = false;
            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.MO_TA].Visible = false;
            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.NGAY_BAT_DAU].Visible = false;
            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.TEN_LOP].Visible = false;
            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.TRANG_THAI_HOC].Visible = false;
            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.TRANG_THAI_YN].Visible = false;
            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.NGAY_KET_THUC].Visible = false;
            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.HO].Visible = false;
            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.TEN].Visible = false;
            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.NGAY_SINH].Visible = false;
            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.TRUONG_DANG_HOC].Visible = false;
            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.FACEBOOK].Visible = false;
            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.DIA_CHI].Visible = false;


            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.MA_DOI_TUONG].Caption = "Mã HV";
            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.MA_DOI_TUONG].Width = 200;
            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.HO_TEN].Caption = "Họ tên";
            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.HO_TEN].Width = 300;
            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.SDT_HS].Caption = "SĐT";
            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.SDT_HS].Width = 200;
            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.EMAIL_HS].Caption = "Email";
            m_sle_ma_hv.Properties.View.Columns[V_GD_HOC.EMAIL_HS].Width = 350;

            m_sle_ma_hv.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            m_sle_ma_hv.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void load_data_2_grid()
        {
            m_ds = new DS_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU();
            m_ds.Clear();
            m_ds.EnforceConstraints = false;
            m_us.FillDataset_by_hs_lm(m_ds, CIPConvert.ToDecimal(m_sle_lop.EditValue), CIPConvert.ToDecimal(m_sle_ma_hv.EditValue));

            m_fg.Redraw = true;
            //create_tree_2grid();
            //CGridUtils.MakeSoTT(0, m_fg);
            wrap_text_cell();

            gridControl.DataSource = m_ds.V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU;
            //gridView.Columns[V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.HO_TEN_PH].Visible = false;
            //gridView.Columns[V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.ID].Visible = false;
            //gridView.Columns[V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.ID_LOAI_PHIEU_THU].Visible = false;
            //gridView.Columns[V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.ID_LOP_MON].Visible = false;
            //gridView.Columns[V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.ID_NGUOI_THU].Visible = false;
            //gridView.Columns[V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TEN_LOAI_PHIEU_THU].Visible = false;
            //gridView.Columns[V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.ID_HOC_SINH].Visible = false;
            //gridView.Columns[V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TIEN_GIAM_TRU].Visible = false;
            //gridView.Columns[V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TIEN_PHAI_THU].Visible = false;
            //gridView.Columns[V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TIEN_CON_PHAI_THU].Visible = false;

            //gridView.Columns[V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.HO_TEN_HS].Caption= "Họ tên HV";
            //gridView.Columns[V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.MA_HOC_SINH].Caption = "Mã HV";
            //gridView.Columns[V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.NGAY_THU].Caption = "Ngày thu";
            //gridView.Columns[V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.NOI_DUNG].Caption = "Nội dung";
            //gridView.Columns[V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.SO_PHIEU].Caption = "Số phiếu";
            //gridView.Columns[V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TEN_LOP_MON].Caption = "Lớp";
            //gridView.Columns[V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TEN_NGUOI_THU].Caption = "Người thu";
            //gridView.Columns[V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU.TIEN_THUC_THU].Caption = "Tiền thực thu";

            // gridView.OptionsBehavior.Editable = false;
            //gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
        }

        private void load_data_to_ds_obj()
        {
            load_data_2_ds_dm_hoc_sinh();
            load_data_2_ds_gd_phieu_thu();
            load_data_2_ds_v_gd_hoc();
        }

        private void set_initial_form_load()
        {
            //m_obj_trans = get_trans_object(m_fg);
            ////CCommon.load_data_2_cbo_nhan_vien(CAppContext_201.getCurrentUserID(),m_cbo_nhan_vien_thu);
            ////load_data_2_cbo_nhan_vien();
            //load_data_2_grid();


            load_data_to_sle_lop();
            load_data_to_sle_lop_2();
            load_data_to_ds_obj();
            //dinh nghia su kien thay doi gia tri edit Value lop
            m_sle_lop.EditValueChanged += m_sle_lop_EditValueChanged;
            m_sle_lop_2.EditValueChanged += m_sle_lop_2_EditValueChanged;
            //load_data_2_grid();
            //Load cac thong tin ban dau

            //Set mot so thuoc tinh ban dau
            m_lbl_ten_hs.Visible = false;

            //load du lieu vao cac ds
            //load_data_to_ds_obj();

            //
            //m_sle_lop.Properties.EditValueChanged += Properties_EditValueChanged;

        }

        private void chuyen_lop_cho_hoc_vien()
        {
            US_GD_HOC v_us_gd_hoc = new US_GD_HOC();

            v_us_gd_hoc.Update_gd_hoc_by_Proc(CIPConvert.ToDecimal(m_sle_lop.EditValue), CIPConvert.ToDecimal(m_sle_ma_hv.EditValue), CIPConvert.ToDecimal(m_sle_lop_2.EditValue));

            MessageBox.Show("Bạn đã cho học viên chuyển lớp thành công!");
        }


        private bool check_validate_data_is_OK()
        {
            if (m_sle_lop.EditValue == null || m_sle_lop.EditValue == "")
            {
                MessageBox.Show("Bạn phải chọn lớp môn!");
                return false;
            }
            if (m_sle_ma_hv.EditValue == null || m_sle_ma_hv.EditValue == "")
            {
                MessageBox.Show("Bạn phải chọn học viên!");
                return false;
            }
            return true;
        }

        //private void cap_nhat_ban_giao()
        //{
        //    //if(m_fg.Rows.Count == 1) {
        //    //    return;
        //    //}
        //    //for(int v_i_cur_row = m_fg.Rows.Fixed + 1; v_i_cur_row < m_fg.Rows.Count; v_i_cur_row++) {
        //    //    US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU v_us_v_rpt = new US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU();
        //    //    grid2us_object(v_us_v_rpt, v_i_cur_row);

        //    //    US_GD_PHIEU_THU v_us_gd_pt = new US_GD_PHIEU_THU(v_us_v_rpt.dcID);
        //    //    v_us_gd_pt.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_BAN_GIAO.BAN_GIAO_THU_QUY;
        //    //    v_us_gd_pt.Update();
        //    //}
        //    //load_data_2_grid();
        //    //m_txt_tong_tien.Clear();
        //    //BaseMessages.MsgBox_Infor("Đã bàn giao tiền!");
        //    US_GD_PHIEU_THU v_us_trans = new US_GD_PHIEU_THU();
        //    try
        //    {

        //        v_us_trans.BeginTransaction();

        //        foreach (var rowHandle in gridView.GetSelectedRows())
        //        {
        //            DataRow v_dr = gridView.GetDataRow(rowHandle);
        //            decimal v_id_pt = CIPConvert.ToDecimal(v_dr["ID"].ToString());
        //            US_GD_PHIEU_THU v_us_gd_pt = new US_GD_PHIEU_THU(v_id_pt);
        //            v_us_gd_pt.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_BAN_GIAO.DA_BAN_GIAO;
        //            v_us_gd_pt.UseTransOfUSObject(v_us_trans);
        //            v_us_gd_pt.Update();

        //            v_us_gd_pt.ClearAllFields();
        //        }
        //        v_us_trans.CommitTransaction();
        //        MessageBox.Show("Đã nhận bàn giao các phiếu đã chọn!");
        //    }
        //    catch (Exception v_e)
        //    {
        //        if (v_us_trans.is_having_transaction())
        //        {
        //            v_us_trans.Rollback();
        //        }
        //        throw v_e;
        //    }
        //}
        #endregion

        //
        //Events
        //
        private void set_define_events()
        {
            this.Load += f370_chuyen_lop_cho_hoc_vien_Load;
            m_cmd_search.Click += m_cmd_search_Click;
            m_cmd_insert.Click += m_cmd_insert_Click;
            this.KeyDown += f370_chuyen_lop_cho_hoc_vien_KeyDown;
            m_fg.DoubleClick += m_fg_DoubleClick;
            m_sle_lop.EditValueChanged += m_sle_lop_EditValueChanged;
            m_sle_ma_hv.EditValueChanged += m_sle_ma_hv_EditValueChanged;
            m_sle_lop_2.EditValueChanged += m_sle_lop_2_EditValueChanged;
        }


        void m_fg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU v_us = new US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU();
                if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
                if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
                grid2us_object(v_us, m_fg.Row);

                //if (!check_ban_giao_is_da_thu_or_admin(v_us)) {
                //    BaseMessages.MsgBox_Infor("Phiếu này đã bàn giao, không được quyền sửa!");
                //    return;
                //}

                US_GD_PHIEU_THU v_us_gd_pt = new US_GD_PHIEU_THU(v_us.dcID);

                //f340_lap_phieu_thu v_frm = new f340_lap_phieu_thu();
                //v_frm.display(v_us, v_us_gd_pt.dcID_LOAI_PHIEU_THU, v_us_gd_pt.dcID_NGUOI_NHAP);
                //load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f370_chuyen_lop_cho_hoc_vien_KeyDown(object sender, KeyEventArgs e)
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

        void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_lop_2.EditValue == null || m_sle_lop_2.EditValue == "")
                {
                    MessageBox.Show("Bạn phải chọn lớp mới cho học viên!");
                    return;
                }
                if (CIPConvert.ToDecimal(m_sle_lop_2.EditValue) == CIPConvert.ToDecimal(m_sle_lop.EditValue))
                {
                    MessageBox.Show("Lớp để chuyển đến không được giống lớp chuyển đi");
                }
                else
                {
                    chuyen_lop_cho_hoc_vien();
                }
                m_lbl_ten_hs.Visible = false;
                load_data_to_sle_lop();
                load_data_to_sle_ma_hv();
                load_data_2_grid();
                load_data_to_sle_lop_2();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_validate_data_is_OK())
                {
                    load_data_2_grid();
                    if (m_fg.Rows.Count > 1)
                    {
                        m_txt_tong_tien.Text = String.Format("{0:#,###0}", m_fg.Rows[m_fg.Rows.Fixed][(int)e_col_Number.TIEN_THUC_THU]);
                    }
                }
                else return;

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f370_chuyen_lop_cho_hoc_vien_Load(object sender, EventArgs e)
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

        void m_sle_lop_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_to_sle_ma_hv();
                m_sle_lop.BackColor = Color.White;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_ma_hv_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                m_sle_ma_hv.BackColor = Color.White;
                if (m_sle_ma_hv.EditValue == "" || m_sle_ma_hv.EditValue == null || m_sle_lop.EditValue == null || m_sle_lop.EditValue == "")
                {
                    m_lbl_ten_hs.Visible = false;
                    return;
                }
                //load_lan_thu_phieu_thu(CIPConvert.ToDecimal(m_sle_ma_hv.EditValue), CIPConvert.ToDecimal(m_sle_lop.EditValue));
                m_lbl_ten_hs.Visible = true;
                string filter = "id = " + m_sle_ma_hv.EditValue;
                DataRow[] v_dr = m_ds_hs.DM_HOC_SINH.Select(filter);
                m_lbl_ten_hs.Text = v_dr[0]["HO"].ToString() + " " + v_dr[0]["TEN"].ToString();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_lop_2_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //load_data_to_sle_ma_hv();
                m_sle_lop.BackColor = Color.White;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}
