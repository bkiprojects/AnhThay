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

        public void addStudentTag(StudentTag studentTag)
        {
            const string procedure = "pr_att_create_studentTag";

            var parameters = new DynamicParameters();
            parameters.Add("@ClassId", studentTag.ClassId);
            parameters.Add("@StudentId", studentTag.StudentId);
            parameters.Add("@TagId", studentTag.TagId);

            parameters.Add("@Notes", studentTag.Notes);
            parameters.Add("@TagDate", studentTag.TagDate);

            parameters.Add("@FeeNotes", studentTag.FeeNotes);
            parameters.Add("@StudyNotes", studentTag.StudyNotes);

            AnhThayDbContext.Context.Connection.Execute(sql: procedure
                , param: parameters
                , commandType: CommandType.StoredProcedure);
        }
        public void updateStudentTag(StudentTag studentTag)
        {
            const string procedure = "pr_att_update_studentTag";

            var parameters = new DynamicParameters();
            parameters.Add("@ClassId", studentTag.ClassId);
            parameters.Add("@StudentId", studentTag.StudentId);
            parameters.Add("@TagId", studentTag.TagId);

            parameters.Add("@Notes", studentTag.Notes);
            parameters.Add("@TagDate", studentTag.TagDate);

            parameters.Add("@FeeNotes", studentTag.FeeNotes);
            parameters.Add("@StudyNotes", studentTag.StudyNotes);

            AnhThayDbContext.Context.Connection.Execute(sql: procedure
                , param: parameters
                , commandType: CommandType.StoredProcedure);
        }

        public void deleteStudentTag(long studentId, int classId)
        {
            const string procedure = "pr_att_delete_studentTag";

            var parameters = new DynamicParameters();
            parameters.Add("@ClassId", classId);
            parameters.Add("@StudentId", studentId);

            AnhThayDbContext.Context.Connection.Execute(sql: procedure
                , param: parameters
                , commandType: CommandType.StoredProcedure);
        }
    }
}
