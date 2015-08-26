using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DS;


namespace BKI_QLTTQuocAnh.DanhMuc
{
    public partial class frm_dm_so_phieu_thu_de : Form
    {
        public frm_dm_so_phieu_thu_de()
        {
            InitializeComponent();
        }

        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display_for_update(US_DM_SO_PHIEU_THU ip_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us.dcID = ip_us.dcID;

            m_txt_ten_so.Text = ip_us.strTEN_SO;
            m_txt_mo_ta.Text = ip_us.strMO_TA;
            m_txt_ghi_chu.Text = ip_us.strGHI_CHU;

            if (ip_us.dcTU_SO == 0)
            {
                m_txt_tu_so.Text = "";
            }
            else
            {
                m_txt_tu_so.Text = ip_us.dcTU_SO.ToString();
            }
            if (ip_us.dcDEN_SO == 0)
            {
                m_txt_den_so.Text = "";
            }
            else
            {
                m_txt_den_so.Text = ip_us.dcDEN_SO.ToString();
            }
            if (ip_us.datTHOI_GIAN_BAT_DAU_SU_DUNG.Date < CIPConvert.ToDatetime("01/01/2000"))
            {
                m_dat_bd.EditValue = DBNull.Value;
            }
            else
            {
                m_dat_bd.EditValue = ip_us.datTHOI_GIAN_BAT_DAU_SU_DUNG;
            }
            if (ip_us.datTHOI_GIAN_KET_THUC_SD.Date < CIPConvert.ToDatetime("01/01/2000"))
            {
                m_dat_kt.EditValue = DBNull.Value;
            }
            else
            {
                m_dat_kt.EditValue = ip_us.datTHOI_GIAN_KET_THUC_SD;
            }


            this.ShowDialog();
        }
        ///Members
        ///
        DataEntryFormMode m_e_form_mode;
        US_DM_SO_PHIEU_THU m_us = new US_DM_SO_PHIEU_THU();
        ///private methods
        ///

        private void set_init_form_load()
        {

        }

        private bool check_validate_is_ok()
        {
            if (m_txt_ten_so.Text == "" || m_txt_ten_so.EditValue == null)
            {
                MessageBox.Show("Tên sổ không được trống");
                return false;
            }
            return true;
        }

        private void save_data()
        {
            if (!check_validate_is_ok())
            {
                return;
            }

            m_us.strTEN_SO = m_txt_ten_so.Text;
            m_us.dcMA_SO_QUYEN = CIPConvert.ToDecimal(m_txt_ten_so.Text.Substring(m_txt_ten_so.Text.LastIndexOf(" ") + 1));

            if (m_txt_tu_so.Text != "" && m_txt_tu_so.EditValue != null)
            {
                m_us.dcTU_SO = CIPConvert.ToDecimal(m_txt_tu_so.EditValue);
            }
            if (m_txt_den_so.Text != "" && m_txt_den_so.EditValue != null)
            {
                m_us.dcDEN_SO = CIPConvert.ToDecimal(m_txt_den_so.EditValue);
            }

            if (m_dat_bd.EditValue != null && m_dat_bd.Text != "")
            {
                m_us.datTHOI_GIAN_BAT_DAU_SU_DUNG = m_dat_bd.DateTime.Date;
            }
            if (m_dat_kt.EditValue != null && m_dat_kt.Text != "")
            {
                m_us.datTHOI_GIAN_KET_THUC_SD = m_dat_kt.DateTime.Date;
            }

            m_us.strMO_TA = m_txt_mo_ta.Text;
            m_us.strGHI_CHU = m_txt_ghi_chu.Text;
            m_us.strIS_DELETED = "N";
            m_us.strIS_ACTIVE = "Y";
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us.Insert();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us.Update();
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }
            MessageBox.Show("Đã cập nhật thành công");
            this.Close();
        }

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch (Exception v_e)
            {

                throw v_e;
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

                throw v_e;
            }
        }

        private void frm_dm_so_phieu_thu_de_Load(object sender, EventArgs e)
        {
            try
            {
                set_init_form_load();
            }
            catch (Exception v_e)
            {

                throw;
            }
        }
    }
}
