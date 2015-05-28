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
using BKI_QLTTQuocAnh.NghiepVu;
using C1.Win.C1FlexGrid;


namespace BKI_QLTTQuocAnh.DanhMuc {
    public partial class F251_dm_hs_theo_lop_de : Form {
        public F251_dm_hs_theo_lop_de()
        {
            InitializeComponent();

            format_control();
            load_data_to_cbo_lop();
        }

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }

        public void display_4_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display_4_update(US_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON v_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = v_us;
            us_2_form(m_us);
            this.m_txt_ma_doi_tuong.ReadOnly = true;
            //m_lbl_ten_lop.Visible = true;
            //m_lbl_ten_lop.Text = m_us.strTEN_LOP_MON;
            this.m_cbo_lop.Enabled = false;
            //m_cbo_lop.SelectedValue = m_us.dcID_LOP_MON;

            //this.m_cbo_lop.Visible = false;
            this.ShowDialog();
        }


        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        DS_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON m_ds = new DS_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON();
        US_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON m_us = new US_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON();
        DS_DM_HOC_SINH m_ds_dm_hs = new DS_DM_HOC_SINH();
        #endregion

        #region Private Method
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));

            set_define_events();
            this.KeyPreview = true;
        }
        private void load_data_2_ds_hs() {
            US_DM_HOC_SINH v_us = new US_DM_HOC_SINH();
            m_ds_dm_hs.Clear();
            m_ds_dm_hs.EnforceConstraints = false;
            v_us.FillDataset(m_ds_dm_hs);
        }
        private void set_initial_form_load()
        {
            
            load_data_2_ds_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON();
            load_data_2_ds_hs();
        }

        private void load_data_to_cbo_lop()
        {
            DS_DM_LOP_MON v_ds = new DS_DM_LOP_MON();
            US_DM_LOP_MON v_us = new US_DM_LOP_MON();
            v_us.FillDataset(v_ds,"where TRANG_THAI_LOP_MON = 88");

            m_cbo_lop.DataSource = v_ds.DM_LOP_MON;
            m_cbo_lop.DisplayMember = DM_LOP_MON.MO_TA;
            m_cbo_lop.ValueMember = DM_LOP_MON.ID;
            m_cbo_lop.SelectedIndex = 0;
        }

        private void load_data_2_ds_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON()
        {
            //Đẩy dữ liệu vào DS_GD_PHIEU_THU
            US_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON v_us = new US_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON();
            m_ds.Clear();
            m_ds.EnforceConstraints = false;
            v_us.FillDataset(m_ds);
        }

        private void us_2_form(US_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON v_us)
        {
            m_txt_ma_doi_tuong.Text = v_us.strMA_DOI_TUONG;
            m_txt_ho.Text = v_us.strHO;
            m_txt_ten.Text = v_us.strTEN;
            m_dat_ngay_sinh.Value = v_us.datNGAY_SINH;
            m_txt_email.Text = v_us.strEMAIL_HS;
            m_txt_sdt.Text = v_us.strSDT_HS;
            m_txt_dia_chi.Text = v_us.strDIA_CHI;
            m_txt_facebook.Text = v_us.strFACEBOOK;
            m_txt_truong_dang_hoc.Text = v_us.strTRUONG_DANG_HOC;
            m_cbo_lop.SelectedValue = v_us.dcID_LOP_MON;
            //m_txt_hoc_phi.Text = v_us.dcDON_GIA_BUOI_HOC.ToString();
            //m_dat_thoi_gian_start.Value = v_us.datTHOI_GIAN_HOC_FROM_DATE;
            //m_dat_thoi_gian_end.Value = v_us.datTHOI_GIAN_HOC_TO_DATE;
            //m_txt_ghi_chu.Text = v_us.strGHI_CHU;
        }

        private bool check_validate_data_is_OK()
        {
            if (!CValidateTextBox.IsValid(m_txt_ma_doi_tuong, DataType.StringType, allowNull.NO, false))
            {
                MessageBox.Show("Mã học viên không được để trống");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ho, DataType.StringType, allowNull.NO, false))
            {
                MessageBox.Show("Họ không được để trống");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ten, DataType.StringType, allowNull.NO, false))
            {
                MessageBox.Show("Tên không được để trống");
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_sdt, DataType.StringType, allowNull.NO, false))
            {
                MessageBox.Show("SĐT không được để trống");
                return false;
            }
            //if (!CValidateTextBox.IsValid(m_txt_hoc_phi, DataType.NumberType, allowNull.NO, false))
            //{
            //    MessageBox.Show("Học phí không được để trống và phải là số");
            //    return false;
            //}

            if (m_e_form_mode == DataEntryFormMode.InsertDataState)
            {
                if (check_data_ma_doi_tuong())
                {
                    MessageBox.Show("Không được nhập trùng mã đối tượng");
                    return false;
                }
            }

            return true;
        }

        private void form_2_us_object()
        {
            m_us.strMA_DOI_TUONG = m_txt_ma_doi_tuong.Text;
            m_us.strHO = m_txt_ho.Text;
            m_us.strTEN = m_txt_ten.Text;
            m_us.datNGAY_SINH = m_dat_ngay_sinh.Value;
            m_us.strEMAIL_HS = m_txt_email.Text;
            m_us.strSDT_HS = m_txt_sdt.Text;
            m_us.strDIA_CHI = m_txt_dia_chi.Text;
            m_us.strFACEBOOK = m_txt_facebook.Text;
            m_us.strTRUONG_DANG_HOC = m_txt_truong_dang_hoc.Text;
            m_us.dcID_LOP_MON = CIPConvert.ToDecimal(m_cbo_lop.SelectedValue);
            //m_us.dcDON_GIA_BUOI_HOC = CIPConvert.ToDecimal(m_txt_hoc_phi.Text);
            //m_us.dcTONG_SO_BUOI_HOC = CIPConvert.ToDecimal(m_txt_tong_so_buoi.Text);
            //m_us.dcTONG_TIEN_KHOA_HOC = CIPConvert.ToDecimal(m_txt_tong_tien.Text);
            //m_us.datTHOI_GIAN_HOC_FROM_DATE = m_dat_thoi_gian_start.Value;
            //m_us.datTHOI_GIAN_HOC_TO_DATE = m_dat_thoi_gian_end.Value;
            //m_us.strGHI_CHU = m_txt_ghi_chu.Text;
        }

        private void us_object_2_form()
        {
            m_txt_ma_doi_tuong.Text = m_us.strMA_DOI_TUONG;
            m_txt_ho.Text = m_us.strHO;
            m_txt_ten.Text = m_us.strTEN;
            m_dat_ngay_sinh.Value = m_us.datNGAY_SINH;
            m_txt_email.Text = m_us.strEMAIL_HS;
            m_txt_sdt.Text = m_us.strSDT_HS;
            m_txt_dia_chi.Text = m_us.strDIA_CHI;
            m_txt_facebook.Text = m_us.strFACEBOOK;
            m_txt_truong_dang_hoc.Text = m_us.strTRUONG_DANG_HOC;
            m_cbo_lop.SelectedValue = m_us.dcID_LOP_MON.ToString();
            //m_txt_hoc_phi.Text = m_us.dcDON_GIA_BUOI_HOC.ToString();
            //m_us.dcTONG_SO_BUOI_HOC = CIPConvert.ToDecimal(m_txt_tong_so_buoi.Text);
            //m_us.dcTONG_TIEN_KHOA_HOC = CIPConvert.ToDecimal(m_txt_tong_tien.Text);
            //m_dat_thoi_gian_start.Value = m_us.datTHOI_GIAN_HOC_FROM_DATE;
            //m_dat_thoi_gian_end.Value = m_us.datTHOI_GIAN_HOC_TO_DATE;
            //m_txt_ghi_chu.Text = m_us.strGHI_CHU;
        }

        private void save_data()
        {

            if (check_validate_data_is_OK() != true)
            {
                return;
            }

            form_2_us_object();

            switch (m_e_form_mode)
            {

                case DataEntryFormMode.InsertDataState:
                    //us.insert();
                    //form_2_us
                    //m_us.Insert()
                    m_us.insert_by_proc(m_txt_ma_doi_tuong.Text
                                        , m_txt_ho.Text
                                        , m_txt_ten.Text
                                        , m_dat_ngay_sinh.Value
                                        , m_txt_email.Text
                                        , m_txt_dia_chi.Text
                                        , m_txt_sdt.Text
                                        , m_txt_facebook.Text
                                        , m_txt_truong_dang_hoc.Text
                                        , CIPConvert.ToDecimal(m_cbo_lop.SelectedValue)
                                        , CIPConvert.ToDecimal(m_txt_hoc_phi.Text)
                                        , m_dat_thoi_gian_start.Value
                                        , m_dat_thoi_gian_end.Value
                                        , m_txt_ghi_chu.Text);
                    BaseMessages.MsgBox_Infor("Bạn đã thêm thành công!!!");
                    load_data_2_ds_hs();
                    this.Close();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    //us.UPDATE();
                    //m_us.Update();

                    m_us.update_by_proc(m_us.dcID
                                        , m_txt_ma_doi_tuong.Text
                                        , m_txt_ho.Text
                                        , m_txt_ten.Text
                                        , m_dat_ngay_sinh.Value
                                        , m_txt_email.Text
                                        , m_txt_sdt.Text
                                        , m_txt_dia_chi.Text
                                        , m_txt_facebook.Text
                                        , m_txt_truong_dang_hoc.Text
                                        , CIPConvert.ToDecimal(m_cbo_lop.SelectedValue)
                                        , CIPConvert.ToDecimal(m_txt_hoc_phi.Text)
                                        , m_dat_thoi_gian_start.Value
                                        , m_dat_thoi_gian_end.Value
                                        , m_txt_ghi_chu.Text
                                        , m_us.dcID_GD_HOC);
                    BaseMessages.MsgBox_Infor("Bạn đã sửa thành công!!!");
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void delete_data()
        {

        }

        private bool check_data_ma_doi_tuong()
        {


            //if((m_sle_so_phieu_thu.EditValue == "" || m_sle_so_phieu_thu.EditValue == null) && m_str_frm_type=="PHIEU_THUC_THU") {
            //    m_lbl_check_so_phieu.Text = "Bạn chọn Sổ phiếu thu trước nhé";
            //    m_txt_so_phieu.BackColor = Color.Bisque;
            //    m_sle_so_phieu_thu.BackColor = Color.Bisque;
            //    return false;
            //}
            //m_ds.Clear();
            //m_ds.EnforceConstraints();
            string v_str_filter = "";
            v_str_filter = "MA_DOI_TUONG = '" + m_txt_ma_doi_tuong.Text.Trim() + "'";

            DataRow[] v_dr = m_ds_dm_hs.DM_HOC_SINH.Select(v_str_filter);
            if (v_dr.Length != 0)
            {
                //XtraMessageBox.Show("Mã học sinh chưa có trong dữ liệu phần mềm. Bạn có muốn nhập mới học sinh này","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                //m_lbl_check_so_phieu.Visible = true;

                m_txt_ma_doi_tuong.BackColor = Color.Bisque;
                m_lbl_check_ma_doi_tuong.Visible = true;
                m_lbl_check_ma_doi_tuong.Text = "Đã có mã học viên rồi...";
                return true;
            }
            else
            {
                m_txt_ma_doi_tuong.BackColor = Color.White;
                //m_sle_so_phieu_thu.BackColor = Color.White;
                m_lbl_check_ma_doi_tuong.Visible = false;
                return false;
            }
            //else {
            //    return false;
            //}

        }
        #endregion

        #region Events
        private void set_define_events()
        {
            //this.Load += F251_dm_hs_theo_lop_de_Load;
            this.KeyDown += F251_dm_hs_theo_lop_de_KeyDown;
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
            m_cmd_exit.Click += m_cmd_exit_Click;
            m_txt_ma_doi_tuong.TextChanged += m_txt_ma_doi_tuong_TextChanged;
        }

        void m_cmd_exit_Click(object sender, EventArgs e)
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

        void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                delete_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_txt_ma_doi_tuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
                {
                    return;
                }
                check_data_ma_doi_tuong();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }



        void F251_dm_hs_theo_lop_de_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void F251_dm_hs_theo_lop_de_Load(object sender, EventArgs e)
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

        #endregion
    }
}
