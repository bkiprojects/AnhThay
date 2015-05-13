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

namespace BKI_QLTTQuocAnh.NghiepVu {
    public partial class F350_lap_phieu_thu : Form {
        public F350_lap_phieu_thu() {
            InitializeComponent();
            format_controls();
        }

        #region Public Methods

        #endregion

        #region Data Structure

        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        DS_DM_HOC_SINH m_ds_hs = new DS_DM_HOC_SINH();
        DS_GD_PHIEU_THU m_ds_phieu_thu = new DS_GD_PHIEU_THU();
        DS_V_GD_HOC m_ds_v_gd_hoc = new DS_V_GD_HOC();
        
        #endregion

        #region Private Methods
        private void format_controls() {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_header_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));

            set_define_events();
            this.KeyPreview = true;
        }

        private void load_data_2_cbo_lop() {
            US_DM_LOP_MON v_us = new US_DM_LOP_MON();
            DS_DM_LOP_MON v_ds = new DS_DM_LOP_MON();

            v_us.FillDataset(v_ds, "where TRANG_THAI_LOP_MON = " + CONST_TRANG_THAI_LOP_MON.DANG_HOAT_DONG);

            DataRow v_dr = v_ds.DM_LOP_MON.NewRow();
            v_dr[DM_LOP_MON.ID] = -1;
            v_dr[DM_LOP_MON.MA_LOP_MON] = "--Chưa chọn--";
            v_dr[DM_LOP_MON.MO_TA] = "--Chưa chọn--";
            v_dr[DM_LOP_MON.TRANG_THAI_LOP_MON] = -1;
            v_dr[DM_LOP_MON.DON_GIA_BUOI_HOC] = 0;
            v_ds.DM_LOP_MON.Rows.InsertAt(v_dr, 0);

            m_cbo_lop.Properties.DataSource = v_ds.DM_LOP_MON;
            m_cbo_lop.Properties.DisplayMember = DM_LOP_MON.MO_TA;
            m_cbo_lop.Properties.ValueMember = DM_LOP_MON.ID;
            m_cbo_lop.ItemIndex = 0;
            this.m_cbo_lop.Properties.PopulateColumns();
            m_cbo_lop.Properties.Columns[DM_LOP_MON.ID].Visible = false;
            m_cbo_lop.Properties.Columns[DM_LOP_MON.ID_LOP].Visible = false;
            m_cbo_lop.Properties.Columns[DM_LOP_MON.ID_MON].Visible = false;
            m_cbo_lop.Properties.Columns[DM_LOP_MON.TRANG_THAI_LOP_MON].Visible = false;
            m_cbo_lop.Properties.Columns[DM_LOP_MON.MA_LOP_MON].Visible = false;
            m_cbo_lop.Properties.Columns[DM_LOP_MON.DON_GIA_BUOI_HOC].Visible = false;
            m_cbo_lop.Properties.Columns[DM_LOP_MON.MO_TA].Caption = "Chọn tên lớp";
            m_cbo_lop.Properties.AutoSearchColumnIndex = 3;
        }
        private void load_data_2_so_phieu_thu() {
            DS_DM_SO_PHIEU_THU v_ds = new DS_DM_SO_PHIEU_THU();
            US_DM_SO_PHIEU_THU v_us = new US_DM_SO_PHIEU_THU();
            v_us.FillDataset(v_ds, "where IS_ACTIVE = 'Y' and IS_DELETED = 'N'");

            DataRow v_dr = v_ds.DM_SO_PHIEU_THU.NewRow();
            v_dr["TEN_SO"] = "-Chưa chọn sổ-";
            v_dr["ID"] = -1;
            v_ds.DM_SO_PHIEU_THU.Rows.InsertAt(v_dr,0);

            m_cbo_so_phieu_thu.DataSource = v_ds.DM_SO_PHIEU_THU;
            m_cbo_so_phieu_thu.DisplayMember = DM_SO_PHIEU_THU.TEN_SO;
            m_cbo_so_phieu_thu.ValueMember = DM_SO_PHIEU_THU.ID;
            
        }
        private void load_data_2_cbo() {
            load_data_2_cbo_lop();
            load_data_2_so_phieu_thu();
        }
        private void load_data_2_grid() {

        }
        private void load_data_to_ds_obj(){
            //Đẩy dữ liệu vào DS_DM_HS
            US_DM_HOC_SINH v_us_hs = new US_DM_HOC_SINH();
            m_ds_hs.Clear();
            m_ds_hs.EnforceConstraints = false;
            v_us_hs.FillDataset(m_ds_hs, "where id_loai_doi_tuong = " + CONST_ID_LOAI_DOI_TUONG.ID_HOC_SINH);
            //Đẩy dữ liệu vào DS_GD_PHIEU_THU
            US_GD_PHIEU_THU v_us_phieu_thu = new US_GD_PHIEU_THU();
            m_ds_phieu_thu.Clear();
            m_ds_phieu_thu.EnforceConstraints = false;
            v_us_phieu_thu.FillDataset(m_ds_phieu_thu);
            //Đẩy dữ liệu vào DS_V_GD_HOC
            US_V_GD_HOC v_us_v_gd_hoc = new US_V_GD_HOC();
            m_ds_v_gd_hoc.Clear();
            m_ds_v_gd_hoc.EnforceConstraints = false;
            v_us_v_gd_hoc.FillDataset(m_ds_v_gd_hoc);
        }


        private void set_initial_form_load() {
            load_data_2_cbo();
            load_data_2_grid();

            //Load cac thong tin ban dau
            m_dat_ngay_nhap.EditValue = DateTime.Now.Date;
            m_lbl_nv_nhap.Text = CAppContext_201.getCurrentUser().ToString();
            m_lbl_nv_thu.Text = CAppContext_201.getCurrentUser().ToString();
            m_dat_tu_ngay.EditValue = DateTime.Now.Date.AddDays(-DateTime.Now.Date.Day + 1).Date;
            m_dat_den_ngay.EditValue = DateTime.Now.Date;
            m_dat_ngay_thu.EditValue = DateTime.Now.Date;

            //Set mot so thuoc tinh ban dau
            m_lbl_check_so_phieu.Visible = false;
            m_lbl_ten_hs.Visible = false;

            //load du lieu vao cac ds
            load_data_to_ds_obj();
            
            //
            m_cbo_lop.Properties.EditValueChanged += Properties_EditValueChanged;
        }


        
        private bool check_data_ma_hv() {
            m_lbl_ten_hs.Visible = true;
            if(m_cbo_lop.ItemIndex == 0) {
                m_lbl_ten_hs.Text = "Bạn chọn lớp trước nhé";
                m_txt_ma_hv.BackColor = Color.Bisque;
                return false;
            }
            DataRow[] v_dr = m_ds_v_gd_hoc.V_GD_HOC.Select("MA_DOI_TUONG = '" + m_txt_ma_hv.Text.Trim() + "' and id_lop_mon = '" + CIPConvert.ToDecimal(m_cbo_lop.EditValue) + "'");

            if(v_dr.Count() == 0) {
                //XtraMessageBox.Show("Mã học sinh chưa có trong dữ liệu phần mềm. Bạn có muốn nhập mới học sinh này","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                m_txt_ma_hv.BackColor = Color.Bisque;
                m_lbl_ten_hs.Text = "Không có mã học viên này trong lớp " + m_cbo_lop.Text.ToString();
                return false;
            }
            else {
                m_lbl_ten_hs.Text = v_dr[0]["HO_TEN"].ToString();
                m_txt_ma_hv.BackColor = Color.White;
                return true;
            }
        }
        private bool check_data_so_phieu() {
            m_lbl_check_so_phieu.Visible = true;
            if(CIPConvert.ToDecimal(m_cbo_so_phieu_thu.SelectedValue) == 0) {
                m_lbl_check_so_phieu.Text = "Bạn chọn Sổ phiếu thu trước nhé";
                m_txt_so_phieu.BackColor = Color.Bisque;
                return false;
            }
            DataRow[] v_dr = m_ds_phieu_thu.GD_PHIEU_THU.Select("SO_PHIEU = '" + m_txt_so_phieu.Text.Trim() + "' and id_so_phieu_thu = '" + m_cbo_so_phieu_thu.SelectedValue +"'");
            if(v_dr.Count() != 0) {
                //XtraMessageBox.Show("Mã học sinh chưa có trong dữ liệu phần mềm. Bạn có muốn nhập mới học sinh này","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                m_lbl_check_so_phieu.Visible = true;
                m_txt_ma_hv.BackColor = Color.Bisque;
                m_lbl_check_so_phieu.Text = "Đã có số phiếu rồi...";
                return true;
            }
            else {
                m_txt_so_phieu.BackColor = Color.White;
                m_lbl_check_so_phieu.Visible = false;
                return false;
            }
        }
        private bool check_data_form_db() {
            if(!check_data_ma_hv() || check_data_so_phieu()) {
                return false;
            }
            return true;
        }


        private bool is_check_validate_ok() {
            
            if(m_txt_so_phieu.Text.CompareTo("") == 0) {
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

            if(!check_data_form_db()) {
                return false;
            }
            if(m_txt_so_phieu.Text.CompareTo("") == 0 || m_txt_so_tien.Text.CompareTo("") == 0 || m_txt_noi_dung.Text.CompareTo("") == 0) {
                return false;
            }

            return true;
        }
        private decimal find_id_gd_hoc(decimal ip_dc_id_lop, string ip_str_ma_hv) {
            try {
                DataRow[] v_dr = m_ds_v_gd_hoc.V_GD_HOC.Select("ma_doi_tuong = '" + ip_str_ma_hv + "' and id_lop_mon = '" + ip_dc_id_lop+"'");
                if(v_dr.Count() == 0) {
                    return 0;
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
                ip_us.strSO_PHIEU = m_txt_so_phieu.Text.Trim();
                ip_us.datNGAY_THU = m_dat_ngay_thu.DateTime.Date;
                ip_us.dcID_GD_HOC = find_id_gd_hoc(CIPConvert.ToDecimal(m_cbo_lop.EditValue), m_txt_ma_hv.Text.Trim());
                ip_us.dcLAN_THU = CIPConvert.ToDecimal(m_txt_lan_thu.Text);
                ip_us.dcSO_TIEN = CIPConvert.ToDecimal(m_txt_so_tien.Text.Trim());
                ip_us.strNOI_DUNG = m_txt_noi_dung.Text.Trim();
                ip_us.dcID_NGUOI_THU = CAppContext_201.getCurrentUserID();
                ip_us.dcID_NGUOI_NHAP = CAppContext_201.getCurrentUserID();
                ip_us.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_BAN_GIAO.CHUA_BAN_GIAO;
                ip_us.datNGAY_NHAP = m_dat_ngay_nhap.DateTime.Date;
                ip_us.dcID_SO_PHIEU_THU = CIPConvert.ToDecimal(m_cbo_so_phieu_thu.SelectedValue);
                //Loai phieu thu tam thoi
                ip_us.dcID_LOAI_PHIEU_THU = CONST_ID_LOAI_PHIEU_THU.PHIEU_PHAI_THU;


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
                        break;

                    case DataEntryFormMode.ViewDataState:
                        break;

                    default:
                        break;
                }
            }
            catch(Exception v_e) {
                throw v_e;
            }
        }
        #endregion

        //////
        ////////Events
        //////
        private void set_define_events() {
            this.Load += F350_lap_phieu_thu_Load;
            m_cmd_them_hv.Click += m_cmd_them_hv_Click;
            m_cmd_search_hv.Click += m_cmd_search_hv_Click;
            m_txt_ma_hv.EditValueChanged += m_txt_ma_hv_EditValueChanged;
            m_txt_so_tien.EditValueChanged += m_txt_so_tien_EditValueChanged;
            m_txt_so_phieu.EditValueChanged += m_txt_so_phieu_EditValueChanged;
            m_cmd_insert.Click += m_cmd_insert_Click;
        }


        void Properties_EditValueChanged(object sender, EventArgs e) {
            try {
                check_data_form_db();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_txt_so_phieu_EditValueChanged(object sender, EventArgs e) {
            try {
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
            }
            catch(Exception v_e) {
                XtraMessageBox.Show("Bạn nhập không đúng kiểu số", "Thông báo lỗi người dùng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_txt_ma_hv_EditValueChanged(object sender, EventArgs e) {
            try {
                check_data_form_db();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_search_hv_Click(object sender, EventArgs e) {
            try {
                F310_dm_hv v_frm = new F310_dm_hv(CIPConvert.ToDecimal(m_cbo_lop.EditValue));
                v_frm.ShowDialog();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_them_hv_Click(object sender, EventArgs e) {
            try {

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
