using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mono.Data.Sqlite;


namespace MobileApp2.ModelView
{
    class ConnectSQLite
    {
        public SqliteConnection my_co;

        public ConnectSQLite() {
            my_co = new SqliteConnection("Data Source=MyDatabase.sqlite;Version=3;");
        }

        public void OpenCo()
        {
            my_co.Open();
        }

        public void CloseCo()
        {
            my_co.Close();
        }
    }
}
