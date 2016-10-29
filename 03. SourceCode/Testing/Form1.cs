using DAL;
using DevExpress.XtraGrid.Columns;
using System.Linq;
using System.Windows.Forms;

namespace Testing
{
    public partial class Form1 : Form
    {
        private readonly ClassRepository _classRepository;

        public Form1()
        {
            _classRepository = new ClassRepository();
            InitializeComponent();
            loadDataToGrid();
        }

        private void loadDataToGrid()
        {
            var classId = 1;
            var sessionNo = 1;
            
            var attendances  = _classRepository.getAttendances(classId, sessionNo);
            var attendanceTypes = _classRepository.getAttendanceTypes();
            
            //Add dynamic columns
            foreach (var each in attendanceTypes)
            {
                var column = new GridColumn {Caption = each.ShortcutChar, FieldName = each.ShortcutChar};
                column.Visible = true;
                gridView1.Columns.Add(column);
            }

            var students = attendances.Select(x => new { x.StudentId, x.StudentName }).Distinct();
            gridControl1.DataSource = students;

            foreach(var each in students)
            {
                var rowHandle = gridView1.LocateByValue("StudentId", each.StudentId);

                if(rowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                    continue;
                for(var i = 2; i < gridView1.Columns.Count; i++)
                {
                    var countType =
                        attendances.Count(
                            x => x.StudentId == each.StudentId && x.ShortcutChar == gridView1.Columns[i].FieldName);
                    gridView1.SetRowCellValue(rowHandle, gridView1.Columns[i], countType);
                }
                gridView1.UpdateCurrentRow();
            }
        }
    }
}
