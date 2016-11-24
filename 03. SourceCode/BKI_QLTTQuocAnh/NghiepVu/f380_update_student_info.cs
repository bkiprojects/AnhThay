using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.DS.CDBNames;
using BKI_QLTTQuocAnh.US;
using DAL;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using IP.Core.IPCommon;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace BKI_QLTTQuocAnh.NghiepVu
{
    public partial class f380_update_student_info : Form
    {
        private StudentRepository _studentRepository;
        public f380_update_student_info()
        {
            _studentRepository = new StudentRepository();
            InitializeComponent();
            load_data_to_sle_lop();
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
        private void loadDataToGrid()
        {
            gridControl.DataSource = _studentRepository.getStudentInfo(Convert.ToInt32(m_sle_lop.EditValue));
        }
        private void m_cmd_load_hoc_vien_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_lop.EditValue == null)
                {
                    XtraMessageBox.Show("Chọn lớp trước!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                loadDataToGrid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void exportExcel()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xlsx files (*.xlsx)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                gridView.ExportToXlsx(saveFileDialog1.FileName);
                XtraMessageBox.Show("Trích xuất dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                exportExcel();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void loadExcelToGrid(string ip_str_path, DevExpress.XtraGrid.GridControl ip_grc)
        {
            string conStr = "";
            //string SheetName = ip_name_sheet_import + "$";
            conStr = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;
            conStr = String.Format(conStr, ip_str_path, "Yes");
            OleDbConnection con = new OleDbConnection(conStr);
            OleDbCommand ExcelCommand = new OleDbCommand();
            ExcelCommand.Connection = con;
            con.Open();
            DataTable ExcelDataSet = new DataTable();
            ExcelDataSet = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            DataTable dt = new DataTable();
            if (ExcelDataSet != null && ExcelDataSet.Rows.Count > 0)
            {
                string SheetName = ExcelDataSet.Rows[0]["TABLE_NAME"].ToString(); // get sheetname
                ExcelCommand.CommandText = "SELECT * From [" + SheetName + "]";
                OleDbDataAdapter ExcelAdapter = new OleDbDataAdapter(ExcelCommand);
                ExcelAdapter.SelectCommand = ExcelCommand;
                ExcelAdapter.Fill(dt);
            }
            con.Close();
            //format_data_header(dt);
            DataTable v_dt_result = dt.Rows.Cast<DataRow>().Where(row => !row.ItemArray.All(field => field is System.DBNull || string.IsNullOrEmpty(field.ToString()) == true)).CopyToDataTable();
            ip_grc.DataSource = v_dt_result;
        }
        private string openFileDialog()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // Set filter options and filter index.
            openFileDialog1.Filter = "xlsx Files|*.xlsx|xls Files|*.xls|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;
            var userClickedOK = openFileDialog1.ShowDialog();
            if (userClickedOK == System.Windows.Forms.DialogResult.OK)
            {
                return openFileDialog1.FileName;
            }
            return "";
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                loadExcelToGrid(openFileDialog(), gridControl);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void saveData()
        {
            List<StudentDTO> studentDtos = new List<StudentDTO>();

            //Get list object
            for(var i = 0; i < gridView.RowCount; i++)
            {

                var dr = gridView.GetDataRow(i);
                var info = new StudentDTO();
                if(dr["Birthday"] != null && dr["Birthday"].ToString() != "")
                {
                    info.Birthday = Convert.ToDateTime(dr["Birthday"]);
                }

                info.CurrentWorkplace = dr["CurrentWorkplace"].ToString();
                info.Email = dr["Email"].ToString();
                info.Facebook = dr["Facebook"].ToString();
                info.FirstName = dr["FirstName"].ToString();

                info.LastName = dr["LastName"].ToString();
                info.PhoneNumber = dr["PhoneNumber"].ToString();
                info.StudentCode = dr["StudentCode"].ToString();

                studentDtos.Add(info);
            }
            using (var scope = new TransactionScope())
            {
                foreach (var item in studentDtos)
                {
                    if (!string.IsNullOrEmpty(item.StudentCode))
                    {
                        _studentRepository.updateStudentInfo(item);
                    }
                }

                scope.Complete();
            }

            XtraMessageBox.Show("Cập nhật thông tin học viên thành công!", "THÔNG BÁO", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                saveData();
            }
            catch (Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }
    }
}
