using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Sqlite;

namespace MobileApp2.ModelView
{
    class ConnectSQLite
    {
        public SQLiteConnection my_co;

        public ConnectSQLite() {
            my_co = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
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
