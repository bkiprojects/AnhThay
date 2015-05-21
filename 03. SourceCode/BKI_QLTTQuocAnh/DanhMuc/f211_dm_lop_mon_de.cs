using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using C1.Win.C1FlexGrid;
using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DS;


namespace BKI_QLTTQuocAnh.DanhMuc
{
    public partial class f211_dm_lop_mon_de : Form
    {
        public f211_dm_lop_mon_de()
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
            m_us_dm_lop_mon = ip_us_dm_lop_mon;
            us_object_2_form();
            this.ShowDialog();
        }

        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode;
        US_DM_LOP_MON m_us_dm_lop_mon = new US_DM_LOP_MON();
        #endregion

        #region Private methods

        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            //CControlFormat.setC1FlexFormat(m_fg);
            //CGridUtils.AddSave_Excel_Handlers(m_fg);
            //CGridUtils.AddSearch_Handlers(m_fg);

            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            load_data_2_cbo_mon_hoc();
        }

        private void load_data_2_cbo_mon_hoc()
        {
        }

        private bool is_check_exist(string ma_lop_mon, DS_DM_LOP_MON ip_ds_dm_lop_mon)
        {
            string filter = "MA_LOP_MON = '" + ma_lop_mon + "'";
            DataRow[] v_dr = ip_ds_dm_lop_mon.DM_LOP_MON.Select(filter);

            if (v_dr.Length == 0)
            {
                return false;
            }
            return true;
        }

        private bool is_check_active(string ma_lop_mon, DS_DM_LOP_MON ip_ds_dm_lop_mon)
        {
            string filter = "TRANG_THAI_LOP_MON = 89 AND MA_LOP_MON = '" + ma_lop_mon + "'";
            DataRow[] v_dr = ip_ds_dm_lop_mon.DM_LOP_MON.Select(filter);

            if (v_dr.Length == 0)
            {
                return false;
            }
            return true;
        }

        private bool kiem_tra_du_lieu_trung()
        {
            DS_DM_LOP_MON v_ds = new DS_DM_LOP_MON();
            US_DM_LOP_MON v_us = new US_DM_LOP_MON();
            v_us.FillDataset(v_ds);

            string v_ma_lop_mon = m_txt_ma_lop_mon.Text;

            if (is_check_exist(v_ma_lop_mon, v_ds))
            {
                if (is_check_active(v_ma_lop_mon, v_ds))
                {
                    MessageBox.Show("Lớp môn này đã có và đã cho nghỉ hoạt động. Bạn có thể cho hoạt động lại!");
                }
                else
                {
                    MessageBox.Show("Lớp môn này đã tồn tại, mời bạn đặt mã lớp khác!");
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool check_validate_data_is_OK()
        {
            if (!CValidateTextBox.IsValid(m_txt_ma_lop_mon, DataType.NumberType, allowNull.NO, false))
            {
                MessageBox.Show("Mã lớp môn không được để trống và phải là số");
                return false;
            }

            if (m_e_form_mode == DataEntryFormMode.InsertDataState)
            {
                if (kiem_tra_du_lieu_trung())
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            
            if (!CValidateTextBox.IsValid(m_txt_mo_ta, DataType.StringType, allowNull.NO, false))
            {
                MessageBox.Show("Mô tả không được để trống");
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
            m_us_dm_lop_mon.strMA_LOP_MON = m_txt_ma_lop_mon.Text;
            m_us_dm_lop_mon.strMO_TA = m_txt_mo_ta.Text;
            m_us_dm_lop_mon.dcDON_GIA_BUOI_HOC = CIPConvert.ToDecimal(m_txt_hoc_phi.Text);
        }

        private void us_object_2_form()
        {
            m_txt_ma_lop_mon.Text = m_us_dm_lop_mon.strMA_LOP_MON;
            m_txt_mo_ta.Text = m_us_dm_lop_mon.strMO_TA;
            m_txt_hoc_phi.Text = m_us_dm_lop_mon.dcDON_GIA_BUOI_HOC.ToString();
            m_dat_thoi_gian_start.Value = m_us_dm_lop_mon.datTHOI_GIAN_HOC_FROM_DATE;
            m_dat_thoi_gian_end.Value = m_us_dm_lop_mon.datTHOI_GIAN_HOC_TO_DATE;
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
                    m_us_dm_lop_mon.Insert();
                    BaseMessages.MsgBox_Infor("Bạn đã thêm thành công!!!");
                    this.Close();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    //us.UPDATE();
                    m_us_dm_lop_mon.Update();
                    BaseMessages.MsgBox_Infor("Bạn đã sửa thành công!!!");
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        #endregion

        private void set_define_events()
        {
            this.Load += f211_dm_lop_mon_de_Load;
            m_cmd_luu.Click += m_cmd_luu_Click;
            this.KeyDown += f211_dm_lop_mon_de_KeyDown;
        }

        void f211_dm_lop_mon_de_KeyDown(object sender, KeyEventArgs e)
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

        void m_cmd_luu_Click(object sender, EventArgs e)
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

        void f211_dm_lop_mon_de_Load(object sender, EventArgs e)
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

    }
}
