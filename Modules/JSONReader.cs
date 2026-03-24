using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Demo_Example_2.Modules
{
    internal class JSONReader
    {
        private string? address;
        private string? user;
        private string? password;
        private string? port;
        private string? database;
        public JSONReader() {

            string json = File.ReadAllText("config.json");
            var doc = JsonDocument.Parse(json);
            var mysql = doc.RootElement.GetProperty("mysql");

            address = mysql.GetProperty("address").GetString();
            user = mysql.GetProperty("user").GetString();
            password = mysql.GetProperty("password").GetString();
            port = mysql.GetProperty("port").GetString();
            database = mysql.GetProperty("database").GetString();

        }
        public string Reading()
        {
            return $"server={address};port={port};user={user};password={password};database={database};";
        }
    }

    
}
