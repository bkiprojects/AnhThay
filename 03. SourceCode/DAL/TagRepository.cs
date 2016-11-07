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
    public class TagRepository
    {
        public TagRepository()
        {
            
        }

        public List<Tag> getTags()
        {
            const string procedure = "pr_att_get_tags";

            var parameters = new DynamicParameters();

            var result = AnhThayDbContext.Context.Connection.Query<Tag>(sql: procedure
                , param: parameters
                , commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<StudentTagDTO> GetStudentTags(int classId)
        {
            const string procedure = "pr_att_get_student_tags";

            var parameters = new DynamicParameters();
            parameters.Add("@ClassId", classId);

            var result = AnhThayDbContext.Context.Connection.Query<StudentTagDTO>(sql: procedure
                , param: parameters
                , commandType: CommandType.StoredProcedure);

            return result.ToList();
        } 
    }
}
