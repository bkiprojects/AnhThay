using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.DS.CDBNames;
using BKI_QLTTQuocAnh.US;
using DAL;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using Models.Entity;

namespace BKI_QLTTQuocAnh.NghiepVu.Attendance
{
    public partial class f382_update_tag : Form
    {
        private readonly ClassRepository _classRepository;
        private readonly TagRepository _tagRepository;
        private int _classId;
        private int _formMode = 1; //Insert, 2=update
        public f382_update_tag()
        {
            _classRepository = new ClassRepository();
            _tagRepository = new TagRepository();

            InitializeComponent();
            init();
        }

        public void displayForInsert(int classId)
        {
            _formMode = 1;
            _classId = classId;
            m_sle_lop.EditValue = classId;
            m_sle_ma_hv.Focus();
            ShowDialog();
        }


        public void displayForUpdate(StudentTag studentTag)
        {
            _formMode = 2;
            m_sle_lop.EditValue = studentTag.ClassId;
            m_sle_ma_hv.EditValue = studentTag.StudentId;
            m_le_tag.EditValue = studentTag.TagId;
            m_txt_note.Text = studentTag.Notes;

            m_txt_feeNotes.Text = studentTag.FeeNotes;
            m_txt_studyNotes.Text = studentTag.StudyNotes;

            m_sle_lop.Enabled = false;
            m_sle_ma_hv.Enabled = false;
            ShowDialog();
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

        private void bindingToHocVienLookup()
        {
            var data = _classRepository.getDanhSachHocVienTheoLop(Convert.ToInt32(m_sle_lop.EditValue));
            m_sle_ma_hv.Properties.DataSource = data;
        }
        private void init()
        {
            load_data_to_sle_lop();
            loadTags();
        }

        private void loadTags()
        {
            var data = _tagRepository.getTags();

            m_le_tag.Properties.DataSource = data;

        }
        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
            
        }

        private void m_sle_lop_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_lop.EditValue != null)
                {
                    bindingToHocVienLookup();
                }
            }
            catch(Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                if(m_sle_lop.EditValue == null)
                {
                    XtraMessageBox.Show("Chọn lớp trước.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if(m_sle_ma_hv.EditValue == null)
                {
                    XtraMessageBox.Show("Chọn học viên trước.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //if(m_le_tag.EditValue == null)
                //{
                //    XtraMessageBox.Show("Chọn tag trước.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                if (_formMode == 1)
                {
                    StudentTag obj = new StudentTag()
                    {
                        ClassId = Convert.ToInt32(m_sle_lop.EditValue),
                        Notes = m_txt_note.Text,
                        StudentId = Convert.ToInt64(m_sle_ma_hv.EditValue),

                        TagDate = DateTime.Now.Date,

                        FeeNotes = m_txt_feeNotes.Text,
                        StudyNotes = m_txt_studyNotes.Text
                    };
                    if(m_le_tag.EditValue != null)
                    {
                        obj.TagId = Convert.ToInt32(m_le_tag.EditValue);
                    }
                    _tagRepository.addStudentTag(obj);

                    XtraMessageBox.Show("Thêm tag cho học viên thành công!", "THÔNG BÁO", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    StudentTag obj = new StudentTag()
                    {
                        ClassId = Convert.ToInt32(m_sle_lop.EditValue),
                        Notes = m_txt_note.Text,
                        StudentId = Convert.ToInt64(m_sle_ma_hv.EditValue),

                        TagDate = DateTime.Now.Date,
                        //TagId = Convert.ToInt32(m_le_tag.EditValue),

                        FeeNotes = m_txt_feeNotes.Text,
                        StudyNotes = m_txt_studyNotes.Text
                    };
                    if(m_le_tag.EditValue != null)
                    {
                        obj.TagId = Convert.ToInt32(m_le_tag.EditValue);
                    }

                    _tagRepository.updateStudentTag(obj);
                    XtraMessageBox.Show("Cập nhật tag cho học viên thành công!", "THÔNG BÁO", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Close();
                }
                
            }
            catch(Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }
    }
}
