using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.DS.CDBNames;
using BKI_QLTTQuocAnh.US;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_QLTTQuocAnh.DanhMuc;

namespace BKI_QLTTQuocAnh.NghiepVu {
    public partial class F350_lap_phieu_thu : Form {


        #region Public Methods
        public F350_lap_phieu_thu(string ip_str_type_frm) {
            InitializeComponent();
            format_controls();
            m_str_frm_type = ip_str_type_frm;
            this.Name = ip_str_type_frm;
        }
        public F350_lap_phieu_thu(string ip_str_type_frm, US_V_GD_PHIEU_THU ip_us_pt) {
            InitializeComponent();
            format_controls();
            m_str_frm_type = ip_str_type_frm;
            m_us_v_pt = ip_us_pt;
            m_is_from_f430 = true;
        }
        #endregion

        #region Data Structure

        #endregion

        #region Members
        public DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        DS_DM_HOC_SINH m_ds_hs = new DS_DM_HOC_SINH();
        DS_GD_PHIEU_THU m_ds_phieu_thu = new DS_GD_PHIEU_THU();
        DS_V_GD_HOC m_ds_v_gd_hoc = new DS_V_GD_HOC();
        DS_DM_LOP_MON m_ds_dm_lop_mon = new DS_DM_LOP_MON();

        US_GD_PHIEU_THU m_us_gd_phieu_thu = new US_GD_PHIEU_THU();
        string m_str_frm_type;
        US_V_GD_PHIEU_THU m_us_v_pt;
        bool m_is_from_f430;
        #endregion

        #region Private Methods
        private void format_controls() {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_header_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));

            set_define_events();
            this.KeyPreview = true;
        }

        private void load_data_to_sle_lop() {
            load_data_2_ds_dm_lop();

            //Chinh hien thi nguoi dung
            m_sle_lop.Properties.DataSource = m_ds_dm_lop_mon.DM_LOP_MON;
            m_sle_lop.Properties.DisplayMember = DM_LOP_MON.MO_TA;
            m_sle_lop.Properties.ValueMember = DM_LOP_MON.ID;

            m_sle_lop.Properties.PopulateViewColumns();
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.ID].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.ID_LOP].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.ID_MON].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.TRANG_THAI_LOP_MON].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.MA_LOP_MON].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.DON_GIA_BUOI_HOC].Visible = false;

            m_sle_lop.Properties.View.Columns[DM_LOP_MON.MO_TA].Caption = "Chọn tên lớp";

            m_sle_lop.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_lop.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            if (m_is_from_f430) m_sle_lop.Enabled = false;
        }
        private void load_data_to_sle_so_phieu_thu() {
            DS_DM_SO_PHIEU_THU v_ds = new DS_DM_SO_PHIEU_THU();
            US_DM_SO_PHIEU_THU v_us = new US_DM_SO_PHIEU_THU();
            string v_str_filter = "where IS_ACTIVE = 'Y' and IS_DELETED = 'N'";
            v_us.FillDataset(v_ds, v_str_filter);

            m_sle_so_phieu_thu.Properties.DataSource = v_ds.DM_SO_PHIEU_THU;
            m_sle_so_phieu_thu.Properties.DisplayMember = DM_SO_PHIEU_THU.TEN_SO;
            m_sle_so_phieu_thu.Properties.ValueMember = DM_SO_PHIEU_THU.ID;

            m_sle_so_phieu_thu.Properties.PopulateViewColumns();
            m_sle_so_phieu_thu.Properties.View.Columns[DM_SO_PHIEU_THU.ID].Visible = false;
            m_sle_so_phieu_thu.Properties.View.Columns[DM_SO_PHIEU_THU.IS_ACTIVE].Visible = false;
            m_sle_so_phieu_thu.Properties.View.Columns[DM_SO_PHIEU_THU.IS_DELETED].Visible = false;
            m_sle_so_phieu_thu.Properties.View.Columns[DM_SO_PHIEU_THU.MA_SO_QUYEN].Visible = false;
            m_sle_so_phieu_thu.Properties.View.Columns[DM_SO_PHIEU_THU.GHI_CHU].Visible = false;
            m_sle_so_phieu_thu.Properties.View.Columns[DM_SO_PHIEU_THU.THOI_GIAN_KET_THUC_SD].Visible = false;

            m_sle_so_phieu_thu.Properties.View.Columns[DM_SO_PHIEU_THU.DEN_SO].Caption = "Đến số";
            m_sle_so_phieu_thu.Properties.View.Columns[DM_SO_PHIEU_THU.DEN_SO].Width = 100;
            m_sle_so_phieu_thu.Properties.View.Columns[DM_SO_PHIEU_THU.MA_SO_QUYEN].Caption = "Mã số quyển";
            m_sle_so_phieu_thu.Properties.View.Columns[DM_SO_PHIEU_THU.MA_SO_QUYEN].Width = 100;
            m_sle_so_phieu_thu.Properties.View.Columns[DM_SO_PHIEU_THU.MO_TA].Caption = "Mô tả";
            m_sle_so_phieu_thu.Properties.View.Columns[DM_SO_PHIEU_THU.MO_TA].Width = 200;
            m_sle_so_phieu_thu.Properties.View.Columns[DM_SO_PHIEU_THU.TEN_SO].Caption = "Tên sổ";
            m_sle_so_phieu_thu.Properties.View.Columns[DM_SO_PHIEU_THU.TEN_SO].Width = 150;
            m_sle_so_phieu_thu.Properties.View.Columns[DM_SO_PHIEU_THU.THOI_GIAN_BAT_DAU_SU_DUNG].Caption = "Thời gian bắt đầu sử dụng";
            m_sle_so_phieu_thu.Properties.View.Columns[DM_SO_PHIEU_THU.THOI_GIAN_BAT_DAU_SU_DUNG].Width = 200;
            m_sle_so_phieu_thu.Properties.View.Columns[DM_SO_PHIEU_THU.TU_SO].Caption = "Từ số";
            m_sle_so_phieu_thu.Properties.View.Columns[DM_SO_PHIEU_THU.TU_SO].Width = 100;

            m_sle_ma_hv.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_so_phieu_thu.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }
        private void load_data_to_sle_ma_hv() {
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
            if (m_is_from_f430) m_sle_ma_hv.Enabled = false;
        }

        private void load_data_2_ds_gd_phieu_thu() {
            //Đẩy dữ liệu vào DS_GD_PHIEU_THU
            US_GD_PHIEU_THU v_us_phieu_thu = new US_GD_PHIEU_THU();
            m_ds_phieu_thu.Clear();
            m_ds_phieu_thu.EnforceConstraints = false;
            v_us_phieu_thu.FillDataset(m_ds_phieu_thu);
        }
        private void load_data_2_ds_dm_hoc_sinh() {
            //Đẩy dữ liệu vào DS_DM_HS
            US_DM_HOC_SINH v_us_hs = new US_DM_HOC_SINH();
            m_ds_hs.Clear();
            m_ds_hs.EnforceConstraints = false;
            v_us_hs.FillDataset(m_ds_hs, "where id_loai_doi_tuong = " + CONST_ID_LOAI_DOI_TUONG.ID_HOC_SINH);
        }
        private void load_data_2_ds_v_gd_hoc() {
            try {
                m_ds_v_gd_hoc.Clear();
                m_ds_v_gd_hoc.EnforceConstraints = false;
                US_V_GD_HOC v_us_v_gd_hoc = new US_V_GD_HOC();
                if(m_sle_lop.EditValue != "" && m_sle_lop.EditValue != null) {
                    string v_str_filter = "where id_lop_mon = " + CIPConvert.ToDecimal(m_sle_lop.EditValue) + " and TRANG_THAI_YN = 'Y'";
                    v_us_v_gd_hoc.FillDataset(m_ds_v_gd_hoc, v_str_filter);
                }
            }
            catch(Exception v_e) {
                throw v_e;
            }
            //Đẩy dữ liệu vào DS_V_GD_HOC
        }
        private void load_data_2_ds_dm_lop() {
            US_DM_LOP_MON v_us = new US_DM_LOP_MON();
            string v_str_filter = "where TRANG_THAI_LOP_MON = " + CONST_TRANG_THAI_LOP_MON.DANG_HOAT_DONG;
            m_ds_dm_lop_mon.Clear();
            m_ds_dm_lop_mon.EnforceConstraints = false;
            v_us.FillDataset(m_ds_dm_lop_mon, v_str_filter);
        }
        private void load_data_to_ds_obj() {
            load_data_2_ds_dm_hoc_sinh();
            load_data_2_ds_gd_phieu_thu();
            load_data_2_ds_v_gd_hoc();
        }



        private void load_data_2_grid() {

        }
        private void set_initial_form_load() {
            load_data_to_sle_so_phieu_thu();
            load_data_to_sle_lop();
            load_data_to_ds_obj();
            //dinh nghia su kien thay doi gia tri edit Value lop
            m_sle_lop.EditValueChanged += m_sle_lop_EditValueChanged;
            load_data_2_grid();
            //Load cac thong tin ban dau
            m_dat_ngay_nhap.EditValue = DateTime.Now.Date;
            m_lbl_nv_nhap.Text = CAppContext_201.getCurrentUser().ToString();
            m_lbl_nv_thu.Text = CAppContext_201.getCurrentUser().ToString();
            m_dat_ngay_thu.EditValue = DateTime.Now.Date;

            //Set mot so thuoc tinh ban dau
            m_lbl_check_so_phieu.Visible = false;
            m_lbl_ten_hs.Visible = false;

            //load du lieu vao cac ds
            //load_data_to_ds_obj();

            //
            //m_sle_lop.Properties.EditValueChanged += Properties_EditValueChanged;
            if(m_str_frm_type == "SUA_PHIEU") {
                FactoryPhieu v_fac = new FactoryPhieu(this, m_str_frm_type, m_us_v_pt);
            }
            else {
                FactoryPhieu v_fac = new FactoryPhieu(this, m_str_frm_type);
            }

        }


        private bool check_data_so_phieu() {

            if((m_sle_so_phieu_thu.EditValue == "" || m_sle_so_phieu_thu.EditValue == null) && m_str_frm_type == "PHIEU_THUC_THU") {
                m_lbl_check_so_phieu.Text = "Bạn chọn Sổ phiếu thu trước nhé";
                m_txt_so_phieu.BackColor = Color.Bisque;
                m_sle_so_phieu_thu.BackColor = Color.Bisque;
                return false;
            }
            if(m_str_frm_type == "PHIEU_THUC_THU") {
                m_lbl_check_so_phieu.Visible = true;
                string v_str_filter;
                v_str_filter = "SO_PHIEU = '" + m_txt_so_phieu.Text.Trim() + "'";

                DataRow[] v_dr = m_ds_phieu_thu.GD_PHIEU_THU.Select(v_str_filter);
                if(v_dr.Count() != 0) {
                    //XtraMessageBox.Show("Mã học sinh chưa có trong dữ liệu phần mềm. Bạn có muốn nhập mới học sinh này","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    m_lbl_check_so_phieu.Visible = true;
                    m_sle_so_phieu_thu.BackColor = Color.White;
                    m_txt_so_phieu.BackColor = Color.Bisque;
                    m_lbl_check_so_phieu.Text = "Đã có số phiếu rồi...";
                    return true;
                }
                else {
                    m_txt_so_phieu.BackColor = Color.White;
                    m_sle_so_phieu_thu.BackColor = Color.White;
                    m_lbl_check_so_phieu.Visible = false;
                    return false;
                }
            }
            else {
                return false;
            }
        }

        private void load_lan_thu_phieu_thu(decimal ip_dc_id_hoc_sinh, decimal ip_dc_id_lop) {
            if(m_str_frm_type == "PHIEU_GIAM_TRU" || m_str_frm_type == "PHIEU_PHAI_THU") {
                m_txt_lan_thu.Text = "0";
                return;
            }

            decimal v_id_gd_hoc = find_id_gd_hoc(ip_dc_id_lop, ip_dc_id_hoc_sinh);
            string filter = "id_gd_hoc = " + v_id_gd_hoc + " and id_loai_phieu_thu = " + CONST_ID_LOAI_PHIEU_THU.PHIEU_THUC_THU;

            DataRow[] v_dr = m_ds_phieu_thu.GD_PHIEU_THU.Select(filter);
            if(v_dr.Length <= 2) {
                if(v_dr.Length == 0) {
                    m_txt_lan_thu.Text = "1";
                }
                else if(v_dr.Length == 1) {
                    m_txt_lan_thu.Text = "2";
                }
                else if((v_dr.Length == 2)) {
                    m_txt_lan_thu.Text = "3";
                }
            }
            else {
                MessageBox.Show("Số lần thu vượt quá 3 lần! Xem lại nhé");
            }
        }


        private bool is_check_validate_ok() {

            if(m_txt_so_phieu.Text.CompareTo("") == 0 && m_str_frm_type == "PHIEU_THUC_THU") {
                m_txt_so_phieu.BackColor = Color.Bisque;
            }
            else {
                m_txt_so_phieu.BackColor = Color.White;
            }

            if(m_txt_so_tien.Text.CompareTo("") == 0) {
                m_txt_so_tien.BackColor = Color.Bisque;
            }
            else {
                m_txt_so_tien.BackColor = Color.White;
            }

            if(m_txt_noi_dung.Text.CompareTo("") == 0) {
                m_txt_noi_dung.BackColor = Color.Bisque;
            }
            else {
                m_txt_noi_dung.BackColor = Color.White;
            }

            if(m_sle_ma_hv.EditValue == "") {
                m_sle_ma_hv.BackColor = Color.Bisque;
            }
            else {
                m_sle_ma_hv.BackColor = Color.White;
            }

            if((m_sle_so_phieu_thu.EditValue == "" || m_sle_so_phieu_thu.EditValue == null) && m_str_frm_type == "PHIEU_THUC_THU") {
                m_sle_so_phieu_thu.BackColor = Color.Bisque;
            }
            else {
                m_sle_so_phieu_thu.BackColor = Color.White;
            }

            if(m_sle_lop.EditValue == "") {
                m_sle_lop.BackColor = Color.Bisque;
            }
            else {
                m_sle_lop.BackColor = Color.White;
            }

            if(m_txt_lan_thu.Text == "" && m_str_frm_type != "PHIEU_PHAI_THU") {
                m_txt_lan_thu.BackColor = Color.Bisque;
            }
            else {
                m_txt_lan_thu.BackColor = Color.White;
            }


            if(check_data_so_phieu()) {
                return false;
            }

            if((m_txt_so_phieu.Text.CompareTo("") == 0 && m_str_frm_type == "PHIEU_THUC_THU") || m_txt_so_tien.Text.CompareTo("") == 0 || m_txt_noi_dung.Text.CompareTo("") == 0) {
                return false;
            }
            string filter = "id_gd_hoc = " + find_id_gd_hoc(CIPConvert.ToDecimal(m_sle_lop.EditValue), CIPConvert.ToDecimal(m_sle_ma_hv.EditValue)) + " and lan_thu = '" + m_txt_lan_thu.Text + "'";
            DataRow[] v_dr = m_ds_phieu_thu.GD_PHIEU_THU.Select(filter);
            if(v_dr.Length > 0 && m_str_frm_type != "SUA_PHIEU") {
                MessageBox.Show("Bạn đã nhập phiếu này rồi");
                return false;
            }

            return true;
        }
        private decimal find_id_gd_hoc(decimal ip_dc_id_lop, decimal ip_dc_id_hv) {
            try {
                string v_str_filter = "id_hoc_sinh = '" + ip_dc_id_hv + "' and id_lop_mon = '" + ip_dc_id_lop + "'";
                DataRow[] v_dr = m_ds_v_gd_hoc.V_GD_HOC.Select(v_str_filter);
                if(v_dr.Count() == 0) {
                    return -1;
                }
                else {
                    return CIPConvert.ToDecimal(v_dr.First()["ID"].ToString());
                }
            }
            catch(Exception v_e) {

                throw v_e;
            }

        }
        private void form_to_us_gd_phieu_thu(US_GD_PHIEU_THU ip_us) {
            try {
                decimal v_id_gd_hoc = find_id_gd_hoc(CIPConvert.ToDecimal(m_sle_lop.EditValue), CIPConvert.ToDecimal(m_sle_ma_hv.EditValue));

                if(m_e_form_mode == DataEntryFormMode.UpdateDataState) {
                    ip_us.dcID = m_us_v_pt.dcID;
                }

                ip_us.strSO_PHIEU = m_txt_so_phieu.Text.Trim();
                ip_us.datNGAY_THU = m_dat_ngay_thu.DateTime.Date;
                ip_us.dcID_GD_HOC = v_id_gd_hoc;

                ip_us.dcSO_TIEN = CIPConvert.ToDecimal(m_txt_so_tien.Text.Trim());
                ip_us.strNOI_DUNG = m_txt_noi_dung.Text.Trim();
                ip_us.dcID_NGUOI_THU = CAppContext_201.getCurrentUserID();
                ip_us.dcID_NGUOI_NHAP = CAppContext_201.getCurrentUserID();
                ip_us.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_BAN_GIAO.CHUA_BAN_GIAO;
                ip_us.datNGAY_NHAP = m_dat_ngay_nhap.DateTime.Date;

                //Loai phieu thu tam thoi
                if(m_us_v_pt == null) {
                    if(m_str_frm_type == "PHIEU_PHAI_THU") {
                        ip_us.dcID_LOAI_PHIEU_THU = CONST_ID_LOAI_PHIEU_THU.PHIEU_PHAI_THU;
                        ip_us.dcLAN_THU = 0;
                    }
                    else if(m_str_frm_type == "PHIEU_THUC_THU") {
                        ip_us.dcID_LOAI_PHIEU_THU = CONST_ID_LOAI_PHIEU_THU.PHIEU_THUC_THU;
                        ip_us.dcID_SO_PHIEU_THU = CIPConvert.ToDecimal(m_sle_so_phieu_thu.EditValue);
                        ip_us.dcLAN_THU = CIPConvert.ToDecimal(m_txt_lan_thu.Text);

                    }
                    else if(m_str_frm_type == "PHIEU_GIAM_TRU") {
                        ip_us.dcID_LOAI_PHIEU_THU = CONST_ID_LOAI_PHIEU_THU.PHIEU_GIAM_TRU;
                        ip_us.dcLAN_THU = 0;
                    }
                }
                else {
                    if(m_str_frm_type == "PHIEU_PHAI_THU" || m_us_v_pt.dcID_LOAI_PHIEU_THU == CONST_ID_LOAI_PHIEU_THU.PHIEU_PHAI_THU) {
                        ip_us.dcID_LOAI_PHIEU_THU = CONST_ID_LOAI_PHIEU_THU.PHIEU_PHAI_THU;
                        ip_us.dcLAN_THU = 0;
                    }
                    else if(m_str_frm_type == "PHIEU_THUC_THU" || m_us_v_pt.dcID_LOAI_PHIEU_THU == CONST_ID_LOAI_PHIEU_THU.PHIEU_THUC_THU) {
                        ip_us.dcID_LOAI_PHIEU_THU = CONST_ID_LOAI_PHIEU_THU.PHIEU_THUC_THU;
                        ip_us.dcID_SO_PHIEU_THU = CIPConvert.ToDecimal(m_sle_so_phieu_thu.EditValue);
                        ip_us.dcLAN_THU = CIPConvert.ToDecimal(m_txt_lan_thu.Text);

                    }
                    else if(m_str_frm_type == "PHIEU_GIAM_TRU" || m_us_v_pt.dcID_LOAI_PHIEU_THU == CONST_ID_LOAI_PHIEU_THU.PHIEU_GIAM_TRU) {
                        ip_us.dcID_LOAI_PHIEU_THU = CONST_ID_LOAI_PHIEU_THU.PHIEU_GIAM_TRU;
                        ip_us.dcLAN_THU = 0;
                    }
                }
               
            }
            catch(Exception v_e) {
                throw v_e;
            }
        }
        private void save_data() {
            if(!is_check_validate_ok()) {
                XtraMessageBox.Show("Bạn điền đầy đủ thông tin trước nhé", "Lỗi người dùng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            /*Buoc 2:  */
            US_GD_PHIEU_THU v_us_gd_phieu_thu = new US_GD_PHIEU_THU();
            form_to_us_gd_phieu_thu(v_us_gd_phieu_thu);
            try {
                switch(m_e_form_mode) {
                    case DataEntryFormMode.InsertDataState:
                    v_us_gd_phieu_thu.Insert();
                    break;

                    case DataEntryFormMode.SelectDataState:
                    break;

                    case DataEntryFormMode.UpdateDataState:
                    v_us_gd_phieu_thu.Update();
                    break;

                    case DataEntryFormMode.ViewDataState:
                    break;

                    default:
                    break;
                }
                load_data_to_ds_obj();
                MessageBox.Show("Đã lưu phiếu thành công");
                if(m_is_from_f430)
                this.Close();
            }
            catch(Exception v_e) {
                throw v_e;
            }
        }
        #endregion

        //////
        ////////Events

        private void set_define_events() {
            this.Load += F350_lap_phieu_thu_Load;
            m_cmd_them_hv.Click += m_cmd_them_hv_Click;
            m_txt_so_tien.EditValueChanged += m_txt_so_tien_EditValueChanged;
            m_txt_so_phieu.EditValueChanged += m_txt_so_phieu_EditValueChanged;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_sle_so_phieu_thu.EditValueChanged += m_sle_so_phieu_thu_EditValueChanged;
            m_sle_lop.EditValueChanged += m_sle_lop_EditValueChanged;
            m_sle_ma_hv.EditValueChanged += m_sle_ma_hv_EditValueChanged;
            m_txt_noi_dung.EditValueChanged += m_txt_noi_dung_EditValueChanged;
            m_txt_lan_thu.EditValueChanged += m_txt_lan_thu_EditValueChanged;
        }

        void m_txt_lan_thu_EditValueChanged(object sender, EventArgs e) {
            try {
                m_txt_lan_thu.BackColor = Color.White;
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_txt_noi_dung_EditValueChanged(object sender, EventArgs e) {
            try {
                m_txt_noi_dung.BackColor = Color.White;
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_ma_hv_EditValueChanged(object sender, EventArgs e) {
            try {
                m_sle_ma_hv.BackColor = Color.White;
                if(m_sle_ma_hv.EditValue == "" || m_sle_ma_hv.EditValue == null || m_sle_lop.EditValue == null || m_sle_lop.EditValue == "") {
                    m_lbl_ten_hs.Visible = false;
                    return;
                }
                load_lan_thu_phieu_thu(CIPConvert.ToDecimal(m_sle_ma_hv.EditValue), CIPConvert.ToDecimal(m_sle_lop.EditValue));
                m_lbl_ten_hs.Visible = true;
                string filter = "id = " + m_sle_ma_hv.EditValue;
                DataRow[] v_dr = m_ds_hs.DM_HOC_SINH.Select(filter);
                m_lbl_ten_hs.Text = v_dr[0]["HO"].ToString() + " " + v_dr[0]["TEN"].ToString();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_so_phieu_thu_EditValueChanged(object sender, EventArgs e) {
            try {
                m_sle_so_phieu_thu.BackColor = Color.White;
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_lop_EditValueChanged(object sender, EventArgs e) {
            try {
                load_data_to_sle_ma_hv();
                m_sle_lop.BackColor = Color.White;
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_txt_so_phieu_EditValueChanged(object sender, EventArgs e) {
            try {
                if(m_e_form_mode == DataEntryFormMode.UpdateDataState) {
                    return;
                }
                check_data_so_phieu();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_insert_Click(object sender, EventArgs e) {
            try {
                //Buoc 1
                save_data();
                //Buoc 2: Load lai DS_DM_HOC SINH va DS_GD_PHIEU_THU
                load_data_to_ds_obj();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_txt_so_tien_EditValueChanged(object sender, EventArgs e) {
            try {
                m_txt_so_tien.Text = String.Format("{0:#,##0}", double.Parse(m_txt_so_tien.Text));
                m_txt_so_tien.BackColor = Color.White;
            }
            catch(Exception v_e) {
                if(m_txt_so_tien.Text.CompareTo("") != 0) {
                    XtraMessageBox.Show("Bạn nhập không đúng kiểu số", "Thông báo lỗi người dùng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_them_hv_Click(object sender, EventArgs e) {
            try {
                DialogResult v_dlg = new System.Windows.Forms.DialogResult();

                F251_dm_hs_theo_lop_de v_frm = new F251_dm_hs_theo_lop_de();
                v_dlg = v_frm.ShowDialog();

                if(v_dlg == System.Windows.Forms.DialogResult.OK) {
                    
                }
                else {
                    return;
                }
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void F350_lap_phieu_thu_Load(object sender, EventArgs e) {
            try {
                set_initial_form_load();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }





    }
}
