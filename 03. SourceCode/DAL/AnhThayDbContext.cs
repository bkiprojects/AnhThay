using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
namespace DAL
{
    public class AnhThayDbContext
    {
        private IDbConnection _connection;
        private static AnhThayDbContext _context;

        public AnhThayDbContext()
        {

        }

        public static AnhThayDbContext Context
        {
            get
            {
                if(_context == null)
                {
                    return new AnhThayDbContext();
                }

                return _context;
            }
        }


        public IDbConnection Connection
        {
            get
            {
                if(_connection == null)
                {
                    _connection = new SqlConnection(getConnection());
                }
                if(_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }

                return _connection;
            }
        }

        

        public void Dispose()
        {
            if(_connection != null && _connection.State == ConnectionState.Open)
                _connection.Close();
        }

        private string getConnection()
        {
            var server = ConfigurationManager.AppSettings["SERVER"];
            var initial_database = ConfigurationManager.AppSettings["INITIAL_DATABASE"]; 
            var fill_database = ConfigurationManager.AppSettings["FILL_DATABASE"];
            var initial_user = ConfigurationManager.AppSettings["INITIAL_USER"];
            var pass_word = ConfigurationManager.AppSettings["PASS_WORD"];

            var connectionString = string.Format("Data Source={0};initial catalog={1};"
                                        +"Integrated Security={2};"
                                        +"User Id={3};Password={4};"
                                        +"MultipleActiveResultSets={5}",
                                        server,
                                        initial_database,
                                         "false",
                                         initial_user,
                                         pass_word,
                                         "true");

            return connectionString;
        }
    }
}
