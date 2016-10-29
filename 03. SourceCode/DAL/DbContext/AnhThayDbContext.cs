using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DAL.DbContext
{
    public class AnhThayDbContext
    {
        private readonly string _connectionString;
        private IDbConnection _connection;

        public static AnhThayDbContext Instance
        {
            get { return new AnhThayDbContext(); }
        }

        public AnhThayDbContext()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AnhThayDbContext"].ConnectionString;
        }

        public IDbConnection Connection
        {
            get
            {
                if(_connection == null)
                {
                    _connection = new SqlConnection(_connectionString);
                }

                if (_connection.State == ConnectionState.Open)
                    return _connection;

                try
                {
                    _connection.Open();
                }
                catch(Exception)
                {

                    _connection.Close();
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
