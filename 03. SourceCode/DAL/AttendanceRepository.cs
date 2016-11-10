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
    public class AttendanceRepository
    {
        public AttendanceRepository()
        {
            
        }
        public List<AttendanceType> getAttendanceTypes()
        {
            const string procedure = "pr_att_get_attendanceTypes";

            var result = AnhThayDbContext.Context.Connection.Query<AttendanceType>(sql: procedure
                , param: null
                , commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
        public List<AttendanceDTO> getAttendances(int classId, int session)
        {
            const string procedure = "pr_att_get_attendances";

            var parameters = new DynamicParameters();
            parameters.Add("@ClassId", classId);
            parameters.Add("@Session", session);

            var result = AnhThayDbContext.Context.Connection.Query<AttendanceDTO>(sql: procedure
                , param: parameters
                , commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public bool isExistAttendance(int classId, int session)
        {
            const string procedure = "pr_att_check_exist_attendance";

            var parameters = new DynamicParameters();
            parameters.Add("@ClassId", classId);
            parameters.Add("@Session", session);
            parameters.Add("@IsExist", direction: ParameterDirection.Output, dbType: DbType.Int32);

            AnhThayDbContext.Context.Connection.Execute(sql: procedure
                , param: parameters
                , commandType: CommandType.StoredProcedure);

            return parameters.Get<int>("@IsExist").ToString() == "1" ? true : false;
        }

        public void deleteExistAttendance(int classId, int session)
        {
            const string procedure = "pr_att_delete_exist_attendance";

            var parameters = new DynamicParameters();
            parameters.Add("@ClassId", classId);
            parameters.Add("@Session", session);

            AnhThayDbContext.Context.Connection.Execute(sql: procedure
                , param: parameters
                , commandType: CommandType.StoredProcedure);
        }

        public void saveSessionHistory(int classId, int session)
        {
            const string procedure = "pr_att_save_session_history";

            var parameters = new DynamicParameters();
            parameters.Add("@ClassId", classId);
            parameters.Add("@Session", session);
            parameters.Add("@Status", direction: ParameterDirection.Output, dbType: DbType.Int32);

            AnhThayDbContext.Context.Connection.Execute(sql: procedure
                , param: parameters
                , commandType: CommandType.StoredProcedure);
        }
    }
}
