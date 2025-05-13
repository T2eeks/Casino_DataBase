using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Casino_DataBase.DataAccess
{
    public class DatabaseConnection
    {
        private static SqlConnection _instance;
        private static readonly object _lock = new object();
        private static string _connectionString;

        private DatabaseConnection() { }

        public static SqlConnection GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null || _instance.State == ConnectionState.Closed)
                {
                    if (string.IsNullOrEmpty(_connectionString))
                    {
                        var connectionStringSetting = ConfigurationManager.ConnectionStrings["CasinoConnectionString"];
                        if (connectionStringSetting == null)
                        {
                            throw new Exception("Строка подключения 'CasinoConnectionString' не найдена в app.config");
                        }
                        _connectionString = connectionStringSetting.ConnectionString;
                    }

                    _instance = new SqlConnection(_connectionString);
                    _instance.Open();
                }
                return _instance;
            }
        }

        public static void CloseConnection()
        {
            lock (_lock)
            {
                if (_instance != null && _instance.State == ConnectionState.Open)
                {
                    _instance.Close();
                    _instance.Dispose();
                    _instance = null; 
                }
            }
        }
    }
}