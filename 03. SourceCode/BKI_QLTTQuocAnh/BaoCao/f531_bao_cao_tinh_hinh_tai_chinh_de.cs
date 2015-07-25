using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid;
using IP.Core.IPCommon;


namespace BKI_QLTTQuocAnh.BaoCao
{
    public partial class f531_bao_cao_tinh_hinh_tai_chinh_de : Form
    {
        public f531_bao_cao_tinh_hinh_tai_chinh_de()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public void display(PivotDrillDownDataSource ip_ds, DateTime ip_dat_tu_ngay, DateTime ip_dat_den_ngay)
        {
            gridControl1.DataSource = ip_ds;
            m_dat_tu_ngay.Text = CIPConvert.ToStr(ip_dat_tu_ngay);
            m_dat_den_ngay.Text = CIPConvert.ToStr(ip_dat_den_ngay);
            make_stt();
            this.ShowDialog();
        }

        private void make_stt()
        {
            var col = gridView1.Columns.Add();
            col.FieldName = "STT";
            col.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            col.AppearanceCell.Options.UseTextOptions = true;
            col.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.CustomUnboundColumnData += gridView2_CustomUnboundColumnData;
        }

        private void gridView2_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
                e.Value = e.ListSourceRowIndex + 1;
        }

        //public WinControlContainer CopyGridControl(GridControl grid)
        //{
        //    WinControlContainer winContainer = new WinControlContainer();

        //    winContainer.Location = new Point(0, 0);
        //    winContainer.Size = new Size(200, 100);

        //    winContainer.WinControl = grid;
        //    return winContainer;
        //}

        //private void simpleButton1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //var r = new rpt_f520_bc_tt_gt_theo_ngay();

        //        //r.Bands[BandKind.Detail].Controls.Add(CopyGridControl(gridControl1));
        //        //r.xrLabel_TuNgay.Text = m_dat_tu_ngay.Value.Date.ToShortDateString();
        //        //r.xrLabel_DenNgay.Text = m_dat_den_ngay.Value.Date.ToShortDateString();
        //        ////gridView2.BestFitColumns();
        //        //r.PaperKind = System.Drawing.Printing.PaperKind.A4;
        //        //r.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

        //        //r.Landscape = false;
        //        //r.ShowPreview();
        //    }
        //    catch (Exception v_e)
        //    {

        //        throw v_e;
        //    }
        //}

    }
}
