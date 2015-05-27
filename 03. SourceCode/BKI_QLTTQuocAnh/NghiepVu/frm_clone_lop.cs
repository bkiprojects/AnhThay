using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.DS.CDBNames;
using BKI_QLTTQuocAnh.US;
using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_QLTTQuocAnh.NghiepVu {
    public partial class frm_clone_lop : Form {
        public frm_clone_lop() {
            InitializeComponent();
        }

        ///Member
        ///
        DS_DM_LOP_MON m_ds_dm_lop_mon = new DS_DM_LOP_MON();
        US_GD_HOC m_us = new US_GD_HOC();

        ///Private Methods
        private void load_data_2_ds_dm_lop() {
            US_DM_LOP_MON v_us = new US_DM_LOP_MON();
            string v_str_filter = "where TRANG_THAI_LOP_MON = " + CONST_TRANG_THAI_LOP_MON.DANG_HOAT_DONG;
            m_ds_dm_lop_mon.Clear();
            m_ds_dm_lop_mon.EnforceConstraints = false;
            v_us.FillDataset(m_ds_dm_lop_mon, v_str_filter);
        }
        private void load_data_to_sle_lop_gd1() {
            load_data_2_ds_dm_lop();

            //Chinh hien thi nguoi dung
            m_sle_lop_gd1.Properties.DataSource = m_ds_dm_lop_mon.DM_LOP_MON;
            m_sle_lop_gd1.Properties.DisplayMember = DM_LOP_MON.MO_TA;
            m_sle_lop_gd1.Properties.ValueMember = DM_LOP_MON.ID;

            m_sle_lop_gd1.Properties.PopulateViewColumns();
            m_sle_lop_gd1.Properties.View.Columns[DM_LOP_MON.ID].Visible = false;
            m_sle_lop_gd1.Properties.View.Columns[DM_LOP_MON.ID_LOP].Visible = false;
            m_sle_lop_gd1.Properties.View.Columns[DM_LOP_MON.ID_MON].Visible = false;
            m_sle_lop_gd1.Properties.View.Columns[DM_LOP_MON.TRANG_THAI_LOP_MON].Visible = false;
            m_sle_lop_gd1.Properties.View.Columns[DM_LOP_MON.DON_GIA_BUOI_HOC].Visible = false;
            m_sle_lop_gd1.Properties.View.Columns[DM_LOP_MON.TONG_TIEN_KHOA_HOC].Visible = false;
            m_sle_lop_gd1.Properties.View.Columns[DM_LOP_MON.TONG_SO_BUOI_HOC].Visible = false;
            m_sle_lop_gd1.Properties.View.Columns[DM_LOP_MON.THOI_GIAN_HOC_TO_DATE].Visible = false;
            m_sle_lop_gd1.Properties.View.Columns[DM_LOP_MON.THOI_GIAN_HOC_FROM_DATE].Visible = false;
            m_sle_lop_gd1.Properties.View.Columns[DM_LOP_MON.GHI_CHU].Visible = false;
            m_sle_lop_gd1.Properties.View.Columns[DM_LOP_MON.ID_TRO_GIANG].Visible = false;

            m_sle_lop_gd1.Properties.View.Columns[DM_LOP_MON.MO_TA].Width = 300;
            m_sle_lop_gd1.Properties.View.Columns[DM_LOP_MON.MA_LOP_MON].Width = 150;

            m_sle_lop_gd1.Properties.View.Columns[DM_LOP_MON.MA_LOP_MON].Caption = "Mã lớp";
            m_sle_lop_gd1.Properties.View.Columns[DM_LOP_MON.MO_TA].Caption = "Chọn tên lớp";

            m_sle_lop_gd1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_lop_gd1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }
        private void load_data_to_sle_lop_gd2() {
            load_data_2_ds_dm_lop();

            //Chinh hien thi nguoi dung
            m_sle_lop_gd2.Properties.DataSource = m_ds_dm_lop_mon.DM_LOP_MON;
            m_sle_lop_gd2.Properties.DisplayMember = DM_LOP_MON.MO_TA;
            m_sle_lop_gd2.Properties.ValueMember = DM_LOP_MON.ID;

            m_sle_lop_gd2.Properties.PopulateViewColumns();
            m_sle_lop_gd2.Properties.View.Columns[DM_LOP_MON.ID].Visible = false;
            m_sle_lop_gd2.Properties.View.Columns[DM_LOP_MON.ID_LOP].Visible = false;
            m_sle_lop_gd2.Properties.View.Columns[DM_LOP_MON.ID_MON].Visible = false;
            m_sle_lop_gd2.Properties.View.Columns[DM_LOP_MON.TRANG_THAI_LOP_MON].Visible = false;
            m_sle_lop_gd2.Properties.View.Columns[DM_LOP_MON.DON_GIA_BUOI_HOC].Visible = false;
            m_sle_lop_gd2.Properties.View.Columns[DM_LOP_MON.TONG_TIEN_KHOA_HOC].Visible = false;
            m_sle_lop_gd2.Properties.View.Columns[DM_LOP_MON.TONG_SO_BUOI_HOC].Visible = false;
            m_sle_lop_gd2.Properties.View.Columns[DM_LOP_MON.THOI_GIAN_HOC_TO_DATE].Visible = false;
            m_sle_lop_gd2.Properties.View.Columns[DM_LOP_MON.THOI_GIAN_HOC_FROM_DATE].Visible = false;
            m_sle_lop_gd2.Properties.View.Columns[DM_LOP_MON.GHI_CHU].Visible = false;
            m_sle_lop_gd2.Properties.View.Columns[DM_LOP_MON.ID_TRO_GIANG].Visible = false;

            m_sle_lop_gd2.Properties.View.Columns[DM_LOP_MON.MO_TA].Width = 300;
            m_sle_lop_gd2.Properties.View.Columns[DM_LOP_MON.MA_LOP_MON].Width = 150;

            m_sle_lop_gd2.Properties.View.Columns[DM_LOP_MON.MA_LOP_MON].Caption = "Mã lớp";
            m_sle_lop_gd2.Properties.View.Columns[DM_LOP_MON.MO_TA].Caption = "Chọn tên lớp";

            m_sle_lop_gd2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            m_sle_lop_gd2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
        }

        private void set_init_form_load() {
            load_data_to_sle_lop_gd1();
            load_data_to_sle_lop_gd2();
        }
        private void load_danh_sach_hv_2_grid() {
            US_V_GD_HOC v_us = new US_V_GD_HOC();
            DS_V_GD_HOC v_ds = new DS_V_GD_HOC();
            v_us.FillDataset(v_ds, "where trang_thai_yn = 'Y' and id_lop_mon = "+ CIPConvert.ToDecimal(m_sle_lop_gd1.EditValue));

            gridControl.DataSource = v_ds.V_GD_HOC;
        }

        ///Events

        private void frm_clone_lop_Load(object sender, EventArgs e) {
            try {
                set_init_form_load();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_sle_lop_gd1_EditValueChanged(object sender, EventArgs e) {
            try {
                load_danh_sach_hv_2_grid();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_insert_Click(object sender, EventArgs e) {
            try {
                
                if(gridView.GetSelectedRows().Length == 0) {
                    MessageBox.Show("Bạn cần chọn học viên trước!");
                    return;
                }
                if(m_sle_lop_gd1.Text == m_sle_lop_gd2.Text) {
                    MessageBox.Show("Không thể chuyển giai đoạn trong cùng một lớp!");
                }
                m_us.BeginTransaction();

                foreach(var rowHandle in gridView.GetSelectedRows()) {
                    m_us.ClearAllFields();
                    DataRow v_dr = gridView.GetDataRow(rowHandle);
                    m_us.dcID_HOC_SINH = CIPConvert.ToDecimal(v_dr["ID_HOC_SINH"].ToString());
                    m_us.dcID_LOP_MON = CIPConvert.ToDecimal(m_sle_lop_gd2.EditValue);
                    m_us.strTRANG_THAI_YN = "Y";
                    m_us.datNGAY_BAT_DAU = DateTime.Now.Date;
                    m_us.Insert();
                }
                m_us.CommitTransaction();
                MessageBox.Show("Đã thêm các học viên này vào lớp mới!");
            }
            catch(Exception v_e) {
                if(m_us.is_having_transaction()) {
                    m_us.Rollback();
                }
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}
