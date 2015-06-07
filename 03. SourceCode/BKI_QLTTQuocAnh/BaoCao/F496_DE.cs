using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_QLTTQuocAnh.BaoCao {
    public partial class F496_DE : Form {
        public F496_DE() {
            InitializeComponent();
            gridView1.ExpandAllGroups();
        }

        private void gridControl1_Click(object sender, EventArgs e) {

        }

        private void m_cmd_xuat_excel_Click(object sender, EventArgs e) {
            try {
                 FolderBrowserDialog dlg = new FolderBrowserDialog();
                 string path ="";
                 if(dlg.ShowDialog() == DialogResult.OK) {
                     path = dlg.SelectedPath;
                 }
                 path = path + "dsphieu"+DateTime.Now.Hour+DateTime.Now.Minute+".xlsx";

                 gridView1.ExportToXlsx(path);
            }
            catch(Exception v_e) {

                throw v_e;
            }
        }
    }
}
