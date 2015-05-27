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


namespace BKI_QLTTQuocAnh.DanhMuc {
    public partial class frm_dm_so_phieu_thu_de : Form {
        public frm_dm_so_phieu_thu_de() {
            InitializeComponent();
        }

        public void display_for_insert() {
            m_e_form_mode = DataEntryFormMode.InsertDataState;

        }
        public void display_for_update(US_DM_SO_PHIEU_THU ip_us) {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;

        }
        ///Members
        ///
        DataEntryFormMode m_e_form_mode;
        
        ///private methods
        ///
        private void set_init_form_load() {
            
        }
        private void save_data() {

        }

        private void m_cmd_save_Click(object sender, EventArgs e) {
            try {
                save_data();
            }
            catch(Exception v_e) {
                
                throw v_e;
            }
        }

        private void m_cmd_exit_Click(object sender, EventArgs e) {
            try {
                this.Close();
            }
            catch(Exception v_e) {

                throw v_e;
            }
        }

        private void frm_dm_so_phieu_thu_de_Load(object sender, EventArgs e) {
            try {
                set_init_form_load();
            }
            catch(Exception v_e) {
                
                throw;
            }
        }
    }
}
