using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_QLTTQuocAnh.NghiepVu {
    public partial class F310_dm_hv : Form {
        public F310_dm_hv(decimal ip_dc_id_lop) {
            InitializeComponent();
            load_user_control(ip_dc_id_lop);
        }

        private void load_user_control(decimal ip_dc_id_lop) {
            uc_ds_hs v_uc = new uc_ds_hs(ip_dc_id_lop);
            this.Controls.Add(v_uc);
            v_uc.Dock = DockStyle.Fill;
        }
    }
}
