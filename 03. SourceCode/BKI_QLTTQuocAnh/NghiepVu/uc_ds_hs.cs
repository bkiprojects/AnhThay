using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;



namespace BKI_QLTTQuocAnh.NghiepVu {
    public partial class uc_ds_hs : UserControl {
        public uc_ds_hs(decimal ip_dc_id_lop) {
            InitializeComponent();
            format_control();
            load_data_2_cbo(ip_dc_id_lop);
            load_data_2_grid(ip_dc_id_lop);
        }
        #region Members
        DS_V_GD_HOC m_ds_v_gd_hoc = new DS_V_GD_HOC();
        #endregion
        private void format_control(){
            
            set_define_events();
        }
        private void load_data_2_grid(decimal ip_dc_id_lop) {
            load_data_2_ds(ip_dc_id_lop);
            gridControl.DataSource = m_ds_v_gd_hoc;
        }
        private void load_data_2_ds(decimal ip_dc_id_lop) {
            US_V_GD_HOC v_us_v_gd_hoc = new US_V_GD_HOC();
            v_us_v_gd_hoc.FillDataset(m_ds_v_gd_hoc, "where TRANG_THAI_YN = 'Y' and id_lop_mon = " + ip_dc_id_lop);
        }
        private void load_data_2_cbo(decimal ip_dc_id_lop) {
            US_DM_LOP_MON v_us = new US_DM_LOP_MON();
            DS_DM_LOP_MON v_ds = new DS_DM_LOP_MON();

            v_us.FillDataset(v_ds, "where TRANG_THAI_LOP_MON = " + CONST_TRANG_THAI_LOP_MON.DANG_HOAT_DONG + " and id = "+ ip_dc_id_lop);
        }

        ///Events
        ///
        ///
        private void set_define_events() {
            m_cmd_search.Click += m_cmd_search_Click;
            m_txt_search.Click += m_txt_search_Click;
            m_cbo_lop.SelectedIndexChanged += m_cbo_lop_SelectedIndexChanged;
        }

        void m_cbo_lop_SelectedIndexChanged(object sender, EventArgs e) {
            try {

            }
            catch(Exception v_e) {

                throw v_e;
            }
        }

        void m_txt_search_Click(object sender, EventArgs e) {
            try {

            }
            catch(Exception v_e) {

                throw v_e;
            }
        }

        void m_cmd_search_Click(object sender, EventArgs e) {
            try {

            }
            catch(Exception v_e) {
                
                throw v_e;
            }
        }

    }
}
