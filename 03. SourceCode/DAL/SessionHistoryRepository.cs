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
    public class SessionHistoryRepository
    {
        public SessionHistoryRepository()
        {
            
        }

        public List<SessionHistoryDTO> getSessionHistory(int classStatusId)
        {
            const string procedure = "pr_att_get_SessionHistory";

            var parameters = new DynamicParameters();
            parameters.Add("@ClassStatusId", classStatusId);

            var result = AnhThayDbContext.Context.Connection.Query<SessionHistoryDTO>(sql: procedure
                , param: parameters
                , commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        
    }
}
