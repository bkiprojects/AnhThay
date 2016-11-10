using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;

namespace BKI_QLTTQuocAnh.DanhMuc
{
    public partial class f260_att_dm_diem_danh : Form
    {
        private readonly AttendanceRepository _attendanceRepository;
        public f260_att_dm_diem_danh()
        {
            _attendanceRepository = new AttendanceRepository();
            InitializeComponent();
            init();
        }

        private void init()
        {
            var data = _attendanceRepository.getAttendanceTypes();
            gridControl1.DataSource = data;
        }
    }
}
