using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.DS.CDBNames;
using BKI_QLTTQuocAnh.RPT;
using BKI_QLTTQuocAnh.US;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_QLTTQuocAnh.BaoCao
{
    public partial class f418_bao_cao_diem_danh_tong_hop : Form
    {
        public f418_bao_cao_diem_danh_tong_hop()
        {
            InitializeComponent();
            format_controls();
            load_data_to_sle_lop();
        }
        public void display_from_f410(decimal ip_id_lop_mon)
        {
            m_sle_lop.EditValue = ip_id_lop_mon;
            this.ShowDialog();
        }
        ///Members
        ///

        ///Private Methods
        ///
        private void format_controls()
        {
            //CControlFormat.setFormStyle(this, new CAppContext_201());
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163))); this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163))); this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;

            set_define_events();
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

        private void set_init_form_load()
        {
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            if (m_sle_lop.EditValue == null || m_sle_lop.Text == "")
            {
                return;
            }

            make_stt();

            DataSet v_ds = new DataSet();
            v_ds.Tables.Add();

            US_DM_HOC_SINH v_us = new US_DM_HOC_SINH();
            v_us.FillDuLieuBaoCaoDiemDanhTongHop(CIPConvert.ToDecimal(m_sle_lop.EditValue), v_ds, Convert.ToInt32(m_txt_buoi.EditValue));

            gridControl1.DataSource = v_ds.Tables[0];
            
        }

        private void make_stt()
        {
            var col = gridView2.Columns.Add();
            col.FieldName = "STT";
            col.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            gridView2.CustomUnboundColumnData += gridView2_CustomUnboundColumnData;
        }

        private void gridView2_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
                e.Value = e.ListSourceRowIndex + 1;
        }

        private void hien_thi_danh_sach_phieu(decimal ip_dc_id_lop_mon, decimal ip_dc_id_hoc_sinh)
        {
            US_GD_PHIEU_THU v_us = new US_GD_PHIEU_THU();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add();
            v_us.FillDanhSachPhieu(v_ds, ip_dc_id_lop_mon, ip_dc_id_hoc_sinh);

            F496_DE v_frm = new F496_DE();
            v_frm.gridControl1.DataSource = v_ds.Tables[0];
            v_frm.ShowDialog();
        }
        ///Events
        ///
        private void set_define_events()
        {
            this.Load += frm_bao_cao_so_giao_dich_theo_lop_Load;
            m_cmd_search.Click += m_cmd_search_Click;
            //m_sle_lop.EditValueChanged += m_sle_lop_EditValueChanged;
            m_cmd_xuat_excel.Click += M_cmd_xuat_excel_Click;
        }

        private void M_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                string path = "";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    path = dlg.SelectedPath;
                }
                path = path + "/Bao cao diem danh tong hop_" + DateTime.Now.ToString("dd-mm-yyyy") + ".xlsx";

                gridView2.ExportToXlsx(path);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_sle_lop_EditValueChanged(object sender, EventArgs e)
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

        void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_lop.EditValue == null || m_sle_lop.Text == "")
                {
                    MessageBox.Show("Bạn phải chọn lớp trước!!!");
                    return;
                }

                load_data_2_grid();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void frm_bao_cao_so_giao_dich_theo_lop_Load(object sender, EventArgs e)
        {
            try
            {
                set_init_form_load();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_lop.EditValue == null || m_sle_lop.Text == "")
                {
                    return;
                }
                Decimal v_id_hoc_sinh = CIPConvert.ToDecimal(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID_HOC_SINH"));
                hien_thi_danh_sach_phieu(CIPConvert.ToDecimal(m_sle_lop.EditValue), v_id_hoc_sinh);
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                string path = "";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    path = dlg.SelectedPath;
                }
                path = path + "giaodichtheolop" + DateTime.Now.Hour + DateTime.Now.Minute + ".xlsx";

                gridView2.ExportToXlsx(path);
            }
            catch (Exception v_e)
            {

                throw v_e;
            }
        }

        public WinControlContainer CopyGridControl(GridControl grid)
        {
            WinControlContainer winContainer = new WinControlContainer();

            winContainer.Location = new Point(0, 0);
            winContainer.Size = new Size(200, 100);

            winContainer.WinControl = grid;
            return winContainer;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var r = new rpt_lop();
                //gridView2.BestFitColumns();
                r.Bands[BandKind.Detail].Controls.Add(CopyGridControl(gridControl1));
                r.xrLabel2.Text = m_sle_lop.Text;
                r.PaperKind = System.Drawing.Printing.PaperKind.A4;
                r.Landscape = true;
                r.ShowPreview();
            }
            catch (Exception v_e)
            {

                throw v_e;
            }
        }



    }
}
