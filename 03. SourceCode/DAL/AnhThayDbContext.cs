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
                    _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AnhThayDbContext"].ConnectionString);
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
    }
}
