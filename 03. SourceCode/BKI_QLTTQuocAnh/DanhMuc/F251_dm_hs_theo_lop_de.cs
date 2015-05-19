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

        public void display_4_update(US.US_DM_LOP_MON ip_us_dm_lop_mon)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode;
        DS_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON m_ds = new DS_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON();
        US_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON m_us = new US_V_DM_HOC_SINH_GD_HOC_DM_LOP_MON();
        #endregion

        #region Private Method
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            add_value_to_cbo_lop(); 
        }

        private void add_value_to_cbo_lop()
        {
            DS_DM_LOP_MON v_ds = new DS_DM_LOP_MON();
            US_DM_LOP_MON v_us = new US_DM_LOP_MON();
            v_us.FillDataset(v_ds);

            m_cbo_lop.DataSource = v_ds.DM_LOP_MON;
            m_cbo_lop.DisplayMember = DM_LOP_MON.MO_TA;
            m_cbo_lop.ValueMember = DM_LOP_MON.ID;
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
            if (!CValidateTextBox.IsValid(m_txt_hoc_phi, DataType.NumberType, allowNull.NO, false))
            {
                MessageBox.Show("Học phí không được để trống và phải là số");
                return false;
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
            m_us.dcDON_GIA_BUOI_HOC = CIPConvert.ToDecimal(m_txt_hoc_phi.Text);
            //m_us.dcTONG_SO_BUOI_HOC = CIPConvert.ToDecimal(m_txt_tong_so_buoi.Text);
            //m_us.dcTONG_TIEN_KHOA_HOC = CIPConvert.ToDecimal(m_txt_tong_tien.Text);
            m_us.datTHOI_GIAN_HOC_FROM_DATE = m_dat_thoi_gian_start.Value;
            m_us.datTHOI_GIAN_HOC_TO_DATE = m_dat_thoi_gian_end.Value;
            m_us.strGHI_CHU = m_txt_ghi_chu.Text;
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
            m_txt_hoc_phi.Text = m_us.dcDON_GIA_BUOI_HOC.ToString();
            //m_us.dcTONG_SO_BUOI_HOC = CIPConvert.ToDecimal(m_txt_tong_so_buoi.Text);
            //m_us.dcTONG_TIEN_KHOA_HOC = CIPConvert.ToDecimal(m_txt_tong_tien.Text);
            m_dat_thoi_gian_start.Value = m_us.datTHOI_GIAN_HOC_FROM_DATE;
            m_dat_thoi_gian_end.Value = m_us.datTHOI_GIAN_HOC_TO_DATE;
            m_txt_ghi_chu.Text = m_us.strGHI_CHU;
        }
        
        #endregion

        #region Events
        private void set_define_events()
        {
            this.Load += F251_dm_hs_theo_lop_de_Load;
            this.KeyDown += F251_dm_hs_theo_lop_de_KeyDown;
            m_cmd_save.Click += m_cmd_insert_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
        }

        void m_cmd_delete_Click(object sender, EventArgs e)
        {
            return;   
        }

        void m_cmd_insert_Click(object sender, EventArgs e)
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
                    m_us.Insert();
                    BaseMessages.MsgBox_Infor("Bạn đã thêm thành công!!!");
                    this.Close();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    //us.UPDATE();
                    m_us.Update();
                    BaseMessages.MsgBox_Infor("Bạn đã sửa thành công!!!");
                    this.Close();
                    break;
                default:
                    break;
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
