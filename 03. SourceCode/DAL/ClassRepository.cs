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
        public List<Class> getClasses()
        {
            const string procedure = "att_get_Classes";
            var result = AnhThayDbContext.Context.Connection.Query<Class>(sql: procedure
                , param: null
                , commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<AttendanceType> getAttendanceTypes()
        {
            const string procedure = "att_get_AttendanceTypes";
            var result = AnhThayDbContext.Context.Connection.Query<AttendanceType>(sql: procedure
                , param: null
                , commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<AttendanceDTO> getAttendances(int classId, int sessionNo)
        {
            const string procedure = "att_get_Attendances";

            var parameters = new DynamicParameters();
            parameters.Add("@ClassId", classId);
            parameters.Add("@SessionNo", sessionNo);

            var result = AnhThayDbContext.Context.Connection.Query<AttendanceDTO>(sql: procedure
                , param: parameters
                , commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
    }
}
