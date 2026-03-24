using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Demo_Example_2.Modules
{
    internal class Database : IDisposable
    {
        private readonly MySqlConnection connection;
        

        public Database(string connStr)
        {
            try
            {
                connection = new(connStr);
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка в подключении к MySQL\n\n{e}", "Ошибка", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        public MySqlConnection GetConnect() => connection;

        public void Dispose()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
            connection.Dispose();
        }
    }
}
