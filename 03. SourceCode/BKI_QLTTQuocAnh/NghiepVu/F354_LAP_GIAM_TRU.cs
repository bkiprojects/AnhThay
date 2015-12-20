using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.DS.CDBNames;
using BKI_QLTTQuocAnh.US;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_QLTTQuocAnh.NghiepVu {
    public partial class F354_LAP_GIAM_TRU : Form {
        public F354_LAP_GIAM_TRU() {
            InitializeComponent();
            format_controls();
            load_default_data_form();
        }

        public void display_for_update(US_V_GD_PHIEU_THU ip_us_v_gd_phieu_thu) {
            load_data_2_ds_obj();
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_gd_phieu_thu.dcID = ip_us_v_gd_phieu_thu.dcID;
            m_us_gd_phieu_thu.dcID = ip_us_v_gd_phieu_thu.dcID;
            m_sle_lop.EditValue = ip_us_v_gd_phieu_thu.dcID_LOP_MON;
            m_sle_ma_hv.EditValue = ip_us_v_gd_phieu_thu.dcID_HOC_SINH;
            m_txt_so_tien.Text = ip_us_v_gd_phieu_thu.dcSO_TIEN.ToString();
            m_txt_noi_dung.Text = ip_us_v_gd_phieu_thu.strNOI_DUNG;
            m_dat_ngay_nhap.EditValue = ip_us_v_gd_phieu_thu.datNGAY_NHAP;
            m_dat_ngay_thu.EditValue = ip_us_v_gd_phieu_thu.datNGAY_THU;
            m_txt_lan_thu.Text = ip_us_v_gd_phieu_thu.dcLAN_THU.ToString();
            m_lbl_header_left.Text = "CẬP NHẬT GIẢM TRỪ";
            this.Text = "F354 - Cập nhật giảm trừ";
            m_cmd_insert.Text = "Cập nhật";
            m_us_gd_phieu_thu.dcID_NGUOI_NHAP = ip_us_v_gd_phieu_thu.dcID_NGUOI_NHAP;
            m_us_gd_phieu_thu.dcID_NGUOI_THU = ip_us_v_gd_phieu_thu.dcID_NGUOI_THU;
            m_lbl_nv_thu.Text = ip_us_v_gd_phieu_thu.strTEN_NGUOI_THU;
            m_lbl_nv_nhap.Text = ip_us_v_gd_phieu_thu.strTEN_NGUOI_THU;
            m_txt_ghi_chu.Text = ip_us_v_gd_phieu_thu.strGHI_CHU;
            load_ten_hs();
            this.ShowDialog();
        }
        ///Members
        ///
        /*----------------------------------*/
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        DS_DM_LOP_MON m_ds_dm_lop_mon = new DS_DM_LOP_MON();
        DS_DM_HOC_SINH m_ds_dm_hs = new DS_DM_HOC_SINH();
        DS_V_GD_HOC m_ds_v_gd_hoc = new DS_V_GD_HOC();
        DS_GD_PHIEU_THU m_ds_gd_phieu_thu = new DS_GD_PHIEU_THU();

        US_GD_PHIEU_THU m_us_gd_phieu_thu = new US_GD_PHIEU_THU();



        ///Private Methods
        ///
        private void load_ten_hs() {
            string filter = "id = " + m_sle_ma_hv.EditValue;
            DataRow[] v_dr = m_ds_dm_hs.DM_HOC_SINH.Select(filter);
            m_lbl_ten_hs.Text = v_dr[0]["HO"].ToString() + " " + v_dr[0]["TEN"].ToString();
        }
        private void load_default_data_form() {
            m_dat_ngay_nhap.EditValue = DateTime.Now.Date;
            m_dat_ngay_thu.EditValue = DateTime.Now.Date;
            m_lbl_ten_hs.Text = "";
            m_lbl_nv_nhap.Text = CAppContext_201.getCurrentUser();
            m_lbl_nv_thu.Text = CAppContext_201.getCurrentUser();
        }
        private void format_controls() {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_header_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));

            set_define_events();
            this.KeyPreview = true;
        }

        private void set_init_form_load() {
            m_sle_ma_hv.EditValueChanged += m_sle_ma_hv_EditValueChanged;
            load_data_2_ds_obj();
            load_data_to_sle_so_phieu_thu();
            load_data_to_sle_lop();
            m_txt_so_phieu.EditValueChanged += m_txt_so_phieu_EditValueChanged;
        }

        private void load_lan_thu_phieu_thu(decimal ip_dc_id_hoc_sinh, decimal ip_dc_id_lop) {
            decimal v_id_gd_hoc = find_id_gd_hoc(ip_dc_id_lop, ip_dc_id_hoc_sinh);
            string filter = "id_gd_hoc = " + v_id_gd_hoc + " and id_loai_phieu_thu = " + CONST_ID_LOAI_PHIEU_THU.PHIEU_GIAM_TRU;

            DataRow[] v_dr = m_ds_gd_phieu_thu.GD_PHIEU_THU.Select(filter);
                m_txt_lan_thu.Text = (v_dr.Length + 1).ToString();
        }

        private void load_data_2_ds_obj() {
            load_data_2_ds_dm_hoc_sinh();
            load_data_2_ds_gd_phieu_thu();
            load_data_2_ds_v_gd_hoc();
            load_data_2_ds_so_phieu_thu();
        }

        private void load_data_2_ds_so_phieu_thu()
        {
            DS_DM_SO_PHIEU_THU v_ds = new DS_DM_SO_PHIEU_THU();
            US_DM_SO_PHIEU_THU v_us = new US_DM_SO_PHIEU_THU();
            v_ds.Clear();
            v_ds.EnforceConstraints = false;
            v_us.FillDataset(v_ds, "where is_deleted = 'N' and is_active = 'Y'");
        }
        private void load_data_2_ds_dm_lop() {
            US_DM_LOP_MON v_us = new US_DM_LOP_MON();
            string v_str_filter = "where TRANG_THAI_LOP_MON = " + CONST_TRANG_THAI_LOP_MON.DANG_HOAT_DONG;
            m_ds_dm_lop_mon.Clear();
            m_ds_dm_lop_mon.EnforceConstraints = false;
            v_us.FillDataset(m_ds_dm_lop_mon, v_str_filter);
        }
        private void load_data_2_ds_gd_phieu_thu() {
            //Đẩy dữ liệu vào DS_GD_PHIEU_THU
            US_GD_PHIEU_THU v_us_phieu_thu = new US_GD_PHIEU_THU();
            m_ds_gd_phieu_thu.Clear();
            m_ds_gd_phieu_thu.EnforceConstraints = false;
            v_us_phieu_thu.FillDataset(m_ds_gd_phieu_thu);
        }
        private void load_data_2_ds_dm_hoc_sinh() {
            //Đẩy dữ liệu vào DS_DM_HS
            US_DM_HOC_SINH v_us_hs = new US_DM_HOC_SINH();
            m_ds_dm_hs.Clear();
            m_ds_dm_hs.EnforceConstraints = false;
            v_us_hs.FillDataset(m_ds_dm_hs, "where id_loai_doi_tuong = " + CONST_ID_LOAI_DOI_TUONG.ID_HOC_SINH);
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


        private void load_data_to_sle_so_phieu_thu()
        {
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
        private void load_data_to_sle_hv() {
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

        private void check_so_phieu()
        {
            string v_str_filter = "";
            if (m_sle_so_phieu_thu.EditValue != null)
            {
                v_str_filter = "SO_PHIEU = '" + m_txt_so_phieu.Text + "' and ID_SO_PHIEU_THU = " + m_sle_so_phieu_thu.EditValue.ToString();
                DataRow[] v_dr = m_ds_gd_phieu_thu.GD_PHIEU_THU.Select(v_str_filter);

                if (v_dr.Count() != 0)
                {
                    m_txt_so_phieu.BackColor = Color.Bisque;
                    m_lbl_check_so_phieu.Visible = true;
                    m_lbl_check_so_phieu.Text = "Đã có số phiếu rồi...";
                }
                else
                {
                    m_txt_so_phieu.BackColor = Color.White;
                    m_lbl_check_so_phieu.Visible = false;
                }
            }
            else
            {
                m_txt_so_phieu.BackColor = Color.White;
                m_lbl_check_so_phieu.Visible = false;
            }

        }

        private void clear_data_phieu() {
            m_sle_so_phieu_thu.EditValue = null;
            m_txt_so_phieu.Text = "";
            m_sle_lop.EditValue = null;
            m_sle_ma_hv.EditValue = null;
            m_txt_noi_dung.Text = "";
            m_txt_so_tien.Text = "";
            m_txt_lan_thu.Text = "";
            m_txt_ghi_chu.Text = "";
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

        private bool is_null_lop() {
            if(m_sle_lop.Text == "" || m_sle_lop.EditValue == null) {
                m_sle_lop.BackColor = Color.Bisque;
                return true;
            }
            m_sle_lop.BackColor = Color.White;
            return false;
        }
        private bool is_null_hv() {
            if(m_sle_ma_hv.Text == "" || m_sle_ma_hv.EditValue == null) {
                m_sle_ma_hv.BackColor = Color.Bisque;
                return true;
            }
            m_sle_ma_hv.BackColor = Color.White;
            return false;
        }
        private bool is_null_so_tien() {
            if(m_txt_so_tien.Text == "") {
                m_txt_so_tien.BackColor = Color.Bisque;
                return true;
            }
            m_txt_so_tien.BackColor = Color.White;
            return false;
        }
        private bool is_valid_ok() {
            if(is_null_lop() || is_null_hv() || is_null_so_tien()) {

                return false;
            }
            return true;
        }

        private void form_2_us_gd_phieu_thu(US_GD_PHIEU_THU ip_us) {
            try {
                //m_us_gd_phieu_thu.ClearAllFields();

                decimal v_id_gd_hoc = find_id_gd_hoc(CIPConvert.ToDecimal(m_sle_lop.EditValue), CIPConvert.ToDecimal(m_sle_ma_hv.EditValue));

                ip_us.dcLAN_THU = CIPConvert.ToDecimal(m_txt_lan_thu.Text);
                ip_us.dcID_LOAI_PHIEU_THU = CONST_ID_LOAI_PHIEU_THU.PHIEU_GIAM_TRU;
                ip_us.dcID_GD_HOC = v_id_gd_hoc;
                ip_us.dcSO_TIEN = CIPConvert.ToDecimal(m_txt_so_tien.Text.Trim());

                if(m_e_form_mode == DataEntryFormMode.UpdateDataState) {
                    ip_us.dcID_NGUOI_THU = m_us_gd_phieu_thu.dcID_NGUOI_NHAP;
                    ip_us.dcID_NGUOI_NHAP = m_us_gd_phieu_thu.dcID_NGUOI_THU;
                }
                else if(m_e_form_mode == DataEntryFormMode.InsertDataState) {
                    ip_us.dcID_NGUOI_THU = CAppContext_201.getCurrentUserID();
                    ip_us.dcID_NGUOI_NHAP = CAppContext_201.getCurrentUserID();
                }
                ip_us.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_BAN_GIAO.CHUA_BAN_GIAO;

                ip_us.datNGAY_NHAP = m_dat_ngay_nhap.DateTime.Date;
                ip_us.datNGAY_THU = m_dat_ngay_thu.DateTime.Date;

                ip_us.strNOI_DUNG = m_txt_noi_dung.Text.Trim();
                ip_us.strSO_PHIEU = m_txt_so_phieu.Text.Trim();
                ip_us.strGHI_CHU = m_txt_ghi_chu.Text.Trim();
                if (m_sle_so_phieu_thu.EditValue == null || m_sle_so_phieu_thu.EditValue == "")
                {
                    return;
                }
                else
                {
                    ip_us.dcID_SO_PHIEU_THU = CIPConvert.ToDecimal(m_sle_so_phieu_thu.EditValue);
                }
                
            }
            catch(Exception v_e) {
                throw v_e;
            }
        }
        private void save_data() {
            if(!is_valid_ok()) {
                XtraMessageBox.Show("Bạn điền đầy đủ thông tin trước nhé", "Lỗi người dùng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            form_2_us_gd_phieu_thu(m_us_gd_phieu_thu);
            try {
                switch(m_e_form_mode) {
                    case DataEntryFormMode.InsertDataState:
                    m_us_gd_phieu_thu.BeginTransaction();
                    m_us_gd_phieu_thu.Insert();
                    m_us_gd_phieu_thu.CommitTransaction();
                    DialogResult v_dlg = XtraMessageBox.Show("Bạn có muốn lập giảm trừ mới?", "THÀNH CÔNG", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if(v_dlg == System.Windows.Forms.DialogResult.Yes) {
                        clear_data_phieu();
                    }
                    else if(v_dlg == System.Windows.Forms.DialogResult.No) {
                        this.Close();
                    }
                    break;

                    case DataEntryFormMode.SelectDataState:

                    break;

                    case DataEntryFormMode.UpdateDataState:
                    m_us_gd_phieu_thu.Update();
                    XtraMessageBox.Show("Cập nhật thành công!", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                    break;

                    case DataEntryFormMode.ViewDataState:
                    break;

                    default:
                    break;
                }
            }
            catch(Exception v_e) {
                if(m_us_gd_phieu_thu.is_having_transaction()) {
                    m_us_gd_phieu_thu.Rollback();
                }
                throw v_e;
            }
        }

        ///Events
        /// 
        private void set_define_events() {
            this.Load += F352_LAP_GIAM_TRU_Load;

            m_sle_lop.EditValueChanged += m_sle_lop_EditValueChanged;
            m_txt_so_tien.EditValueChanged += m_txt_so_tien_EditValueChanged;
            
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_sle_so_phieu_thu.EditValueChanged += m_sle_so_phieu_thu_EditValueChanged;
        }

        void m_cmd_insert_Click(object sender, EventArgs e) {
            try {
                save_data();
                load_data_2_ds_obj();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_so_phieu_thu_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                check_so_phieu();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_txt_so_phieu_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                check_so_phieu();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_ma_hv_EditValueChanged(object sender, EventArgs e) {
            try {

                if(m_sle_ma_hv.EditValue != null) {
                    string filter = "id = " + m_sle_ma_hv.EditValue;
                    DataRow[] v_dr = m_ds_dm_hs.DM_HOC_SINH.Select(filter);
                    m_lbl_ten_hs.Text = v_dr[0]["HO"].ToString() + " " + v_dr[0]["TEN"].ToString();

                    load_lan_thu_phieu_thu(CIPConvert.ToDecimal(m_sle_ma_hv.EditValue), CIPConvert.ToDecimal(m_sle_lop.EditValue));
                }
                else {
                    m_lbl_ten_hs.Text = "";
                }
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_txt_so_tien_EditValueChanged(object sender, EventArgs e) {
            try {
                //m_txt_so_tien.Text = String.Format("{0:#,##0}", double.Parse(m_txt_so_tien.Text));
                m_txt_so_tien.BackColor = Color.White;
            }
            catch(Exception v_e) {
                if(m_txt_so_tien.Text.CompareTo("") != 0) {
                    XtraMessageBox.Show("Bạn nhập không đúng kiểu số", "Thông báo lỗi người dùng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        void m_sle_lop_EditValueChanged(object sender, EventArgs e) {
            try {
                load_data_to_sle_hv();
                
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void F352_LAP_GIAM_TRU_Load(object sender, EventArgs e) {
            try {
                set_init_form_load();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
