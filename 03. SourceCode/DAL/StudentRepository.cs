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
    public class StudentRepository
    {
        public StudentRepository()
        {
            
        }

        public List<StudentDTO> getStudentInfo(int classId)
        {
            const string procedure = "pr_att_load_student_info";

            var parameters = new DynamicParameters();
            parameters.Add("@ip_dc_id_lop", classId);
            var result = AnhThayDbContext.Context.Connection.Query<StudentDTO>(sql: procedure
                , param: parameters
                , commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public void updateStudentInfo(StudentDTO studentInfo)
        {
            const string procedure = "pr_update_student_info";

            var parameters = new DynamicParameters();
            parameters.Add("@StudentCode", studentInfo.StudentCode);
            parameters.Add("@FirstName", studentInfo.FirstName);
            parameters.Add("@LastName", studentInfo.LastName);

            parameters.Add("@PhoneNumber", studentInfo.PhoneNumber);
            parameters.Add("@Email", studentInfo.Email);

            parameters.Add("@Facebook", studentInfo.Facebook);
            parameters.Add("@Birthday", studentInfo.BirthDay);
            parameters.Add("@CurrentWorkplace", studentInfo.CurrentWorkplace);

            AnhThayDbContext.Context.Connection.Execute(sql: procedure
                , param: parameters
                , commandType: CommandType.StoredProcedure);
        }

    }
}
