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
    public class DictionaryRepository
    {
        public DictionaryRepository()
        {
            
        }

        public List<DictionaryDTO> getDictionaries(int dictionaryTypeId)
        {
            const string procedure = "pr_cm_get_dicionaries";

            var parameters = new DynamicParameters();
            parameters.Add("@DictionaryTypeId", dictionaryTypeId);

            var result = AnhThayDbContext.Context.Connection.Query<DictionaryDTO>(sql: procedure
                , param: parameters
                , commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        
    }
}
