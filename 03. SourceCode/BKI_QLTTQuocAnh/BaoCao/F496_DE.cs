using BKI_QLTTQuocAnh.RPT;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
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


        public WinControlContainer CopyGridControl(GridControl grid) {
            WinControlContainer winContainer = new WinControlContainer();

            winContainer.Location = new Point(0, 0);
            winContainer.Size = new Size(200, 100);

            winContainer.WinControl = grid;
            return winContainer;
        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            try {
                var r = new dsphieu();

                r.Bands[BandKind.Detail].Controls.Add(CopyGridControl(gridControl1));
                gridView1.BestFitColumns();
                r.PaperKind = System.Drawing.Printing.PaperKind.A4;
                r.Landscape = true;
                r.ShowPreview();
            }
            catch(Exception v_e) {
                
                throw v_e;
            }
        }
    }
}
