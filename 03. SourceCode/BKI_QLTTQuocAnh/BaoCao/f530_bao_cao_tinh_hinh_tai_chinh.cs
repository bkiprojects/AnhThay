
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

using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.DS.CDBNames;
using BKI_QLTTQuocAnh.US;

using DevExpress.XtraPivotGrid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid;
using BKI_QLTTQuocAnh.RPT;

namespace BKI_QLTTQuocAnh.BaoCao
{
    public partial class f530_bao_cao_tinh_hinh_tai_chinh : Form
    {
        public f530_bao_cao_tinh_hinh_tai_chinh()
        {
            InitializeComponent();
            set_define_events();
        }

        #region Public Interface

        #endregion

        #region Members
        DS_V_GD_PHIEU_THU m_ds = new DS_V_GD_PHIEU_THU();
        US_V_GD_PHIEU_THU m_us = new US_V_GD_PHIEU_THU();
        #endregion

        #region Private Methods
        private void set_initial_form_load()
        {
            m_dat_tu_ngay.Text = "01/01/2015";
            load_data_to_sle_lop();
            load_data_2_grid();
        }

        private void load_data_to_sle_lop()
        {
            //Chinh hien thi nguoi dung
            m_sle_lop.Properties.DataSource = load_data_2_ds_dm_lop().DM_LOP_MON;
            m_sle_lop.Properties.DisplayMember = DM_LOP_MON.MO_TA;
            m_sle_lop.Properties.ValueMember = DM_LOP_MON.ID;

            m_sle_lop.Properties.PopulateViewColumns();
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.ID].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.ID_LOP].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.ID_MON].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.TRANG_THAI_LOP_MON].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.DON_GIA_BUOI_HOC].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.TONG_TIEN_KHOA_HOC].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.TONG_SO_BUOI_HOC].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.THOI_GIAN_HOC_TO_DATE].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.THOI_GIAN_HOC_FROM_DATE].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.GHI_CHU].Visible = false;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.ID_TRO_GIANG].Visible = false;

            m_sle_lop.Properties.View.Columns[DM_LOP_MON.MO_TA].Width = 300;
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.MA_LOP_MON].Width = 150;

            m_sle_lop.Properties.View.Columns[DM_LOP_MON.MA_LOP_MON].Caption = "Mã lớp";
            m_sle_lop.Properties.View.Columns[DM_LOP_MON.MO_TA].Caption = "Chọn tên lớp";

            m_sle_lop.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_lop.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private DS_DM_LOP_MON load_data_2_ds_dm_lop()
        {
            DS_DM_LOP_MON v_ds = new DS_DM_LOP_MON();
            US_DM_LOP_MON v_us = new US_DM_LOP_MON();
            string v_str_filter = "where TRANG_THAI_LOP_MON = " + CONST_TRANG_THAI_LOP_MON.DANG_HOAT_DONG;
            v_ds.Clear();
            v_ds.EnforceConstraints = false;
            v_us.FillDataset(v_ds, v_str_filter);

            return v_ds;
        }

        private void load_data_2_grid()
        {
            DS_V_GD_PHIEU_THU m_ds = new DS_V_GD_PHIEU_THU();
            US_V_GD_PHIEU_THU m_us = new US_V_GD_PHIEU_THU();
            if (m_sle_lop.EditValue == null || m_sle_lop.EditValue == "")
            {
                m_ds.Clear();
                m_us.FillDataset_by_date(m_ds, m_dat_tu_ngay.Value.Date, m_dat_den_ngay.Value.Date);

            }
            else
            {
                m_ds.Clear();
                m_us.FillDataset_by_date_and_id_lop(m_ds, m_dat_tu_ngay.Value.Date, m_dat_den_ngay.Value.Date, CIPConvert.ToDecimal(m_sle_lop.EditValue));
            }

            pivotGridControl1.DataSource = m_ds.Tables[0];
        }

        #endregion

        private void set_define_events()
        {
            m_cmd_search.Click += m_cmd_search_Click;
        }

        void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void f530_bao_cao_tinh_hinh_tai_chinh_Load(object sender, EventArgs e)
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

        private void pivotGridControl1_FieldValueDisplayText(object sender, DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs e)
        {
            try
            {
                if (e.ValueType == PivotGridValueType.GrandTotal)
                {
                    e.DisplayText = "Tổng cộng";
                }
                if (e.ValueType == PivotGridValueType.Total)
                {
                    e.DisplayText = e.Field.Caption + " " + e.Value;
                }
                if ((e.DisplayText == "1" || e.DisplayText == "2" || e.DisplayText == "3" || e.DisplayText == "4") && e.ValueType == PivotGridValueType.Value)
                {
                    e.DisplayText = "Quý " + e.DisplayText;
                }
                if (e.DisplayText.Contains("Jan") || e.DisplayText.Contains("Feb") || e.DisplayText.Contains("Mar") || e.DisplayText.Contains("Apr") || e.DisplayText.Contains("May") || e.DisplayText.Contains("Jun") || e.DisplayText.Contains("Jul") || e.DisplayText.Contains("Aug") || e.DisplayText.Contains("Sep") || e.DisplayText.Contains("Oct") || e.DisplayText.Contains("Nov") || e.DisplayText.Contains("Dec"))
                {
                    e.DisplayText = "Tháng " + e.Value.ToString();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void pivotGridControl1_CellDoubleClick(object sender, PivotCellEventArgs e)
        {
            try
            {

                f531_bao_cao_tinh_hinh_tai_chinh_de v_frm = new f531_bao_cao_tinh_hinh_tai_chinh_de();

                v_frm.display(e.CreateDrillDownDataSource(), m_dat_tu_ngay.Value.Date, m_dat_den_ngay.Value.Date);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        public WinControlContainer CopyGridControl(PivotGridControl pivotGridControl)
        {
            WinControlContainer winContainer = new WinControlContainer();

            winContainer.Location = new Point(0, 0);
            winContainer.Size = new Size(200, 100);

            winContainer.WinControl = pivotGridControl;
            return winContainer;
        }
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var r = new rpt_f530_bao_cao_tinh_hinh_tai_chinh();

                r.Bands[BandKind.Detail].Controls.Add(CopyGridControl(pivotGridControl1));
                r.xrLabel_TuNgay.Text = m_dat_tu_ngay.Value.Date.ToShortDateString();
                r.xrLabel_DenNgay.Text = m_dat_den_ngay.Value.Date.ToShortDateString();
                //gridView2.BestFitColumns();
                r.PaperKind = System.Drawing.Printing.PaperKind.A4;
                r.Landscape = false;
                r.ShowPreview();
            }
            catch (Exception v_e)
            {

                throw v_e;
            }
        }

    }
}
