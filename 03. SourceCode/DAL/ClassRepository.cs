using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using Models;
using Models.DTO;
using Models.Entity;

namespace DAL
{
    public class ClassRepository
    {
        public ClassRepository()
        {
 
        }

        public List<StudentDTO> getDanhSachHocVienTheoLop(int classId)
        {
            const string procedure = "pr_att_get_hoc_vien_theo_lop";
            var parameters = new DynamicParameters();
            parameters.Add("@ClassId", classId);
            var result = AnhThayDbContext.Context.Connection.Query<StudentDTO>(sql: procedure
                , param: parameters
                , commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        

        public int DiemDanh(long studentId, string shortcut, long classId, int session)
        {
            const string procedure = "pr_att_diem_danh";

            var parameters = new DynamicParameters();
            parameters.Add("@StudentId", studentId);
            parameters.Add("@ShortcutKey", shortcut);
            parameters.Add("@ClassId", classId);

            parameters.Add("@Session", session);
            parameters.Add("@Status", ParameterDirection.Output, dbType: DbType.Int16);
            AnhThayDbContext.Context.Connection.Execute(sql: procedure
                , param: parameters
                , commandType: CommandType.StoredProcedure);

            return Convert.ToInt32(parameters.Get<int>("@Status"));
        }
    }
}
