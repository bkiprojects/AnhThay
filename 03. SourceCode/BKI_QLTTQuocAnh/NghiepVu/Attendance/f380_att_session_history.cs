using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_QLTTQuocAnh.BaoCao;
using DAL;
using IP.Core.IPCommon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Models.DTO;

namespace BKI_QLTTQuocAnh.NghiepVu.Attendance
{
    public partial class f380_att_session_history : Form
    {
        private readonly DictionaryRepository _dictionaryRepository;
        private readonly SessionHistoryRepository _sessionHistoryRepository;
        private const int STATUS_CLASS_TYPE_ID = 12;

        public f380_att_session_history()
        {
            _dictionaryRepository = new DictionaryRepository();
            _sessionHistoryRepository = new SessionHistoryRepository();

            InitializeComponent();

            formatControl();
        }


        private void formatControl()
        {
            setDefineEvent();
        }

       

        


        private void initFormLoad()
        {
            bindingClassStatusLookup();
        }

        private void bindingClassStatusLookup()
        {
            var dictionaries = _dictionaryRepository.getDictionaries(STATUS_CLASS_TYPE_ID);
            m_le_trang_thai_lop.Properties.DataSource = dictionaries;
        }

        private void loadDataToGrid()
        {
            if (!isSelectedClassStatusType())
            {
                XtraMessageBox.Show("Chọn trạng lớp trước", "THÔNG BÁO");
                return;
            }
            var data = _sessionHistoryRepository.getSessionHistory(getClassStatusType());
            gridControlDiemDanh.DataSource = data;
        }

        private int getClassStatusType()
        {
            return Convert.ToInt32(m_le_trang_thai_lop.EditValue);
        }

        private bool isSelectedClassStatusType()
        {
            if (m_le_trang_thai_lop.EditValue == null)
            {
                return false;
            }

            return true;
        }

        private void showDetailAttendance()
        {
            var sessionHistory = (SessionHistoryDTO) gridViewDiemDanh.GetRow(gridViewDiemDanh.FocusedRowHandle);
            var classId = sessionHistory.ClassId;
            var session = sessionHistory.CurrentSession;
                
            var frm = new f417_diem_danh();
            frm.displayFromF380(classId, session);
        }
        #region Events
        private void setDefineEvent()
        {
            Load += F380_att_session_history_Load;
            m_cmd_search.Click += m_cmd_search_Click;
            repositoryItemButtonAttendance.ButtonClick += repositoryItemButtonAttendanceOnClick;
        }
        private void F380_att_session_history_Load(object sender, EventArgs e)
        {
            try
            {
                initFormLoad();
            }
            catch(Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                loadDataToGrid();
            }
            catch(Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void repositoryItemButtonAttendanceOnClick(object sender, ButtonPressedEventArgs eventArgs)
        {
            try
            {
                showDetailAttendance();
            }
            catch(Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }
        #endregion

    }
}
