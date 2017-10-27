using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Sqlite;
using MobileApp2.Model;


namespace MobileApp2.ModelView
{
    class ConnectSQLite
    {
        private SQLiteConnection my_co;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        public ConnectSQLite()
        {
            
        }
        public void OpenCo()
        {
            my_co = new SQLiteConnection("Data Source=TestDatabase.s3db;Version=3;");
            my_co.Open();
        }
        public void CloseCo()
        {
            my_co.Close();
        }
        private void ExecuteQuery(string txtQuery)
        {
            OpenCo();
            cmd = my_co.CreateCommand();
            cmd.CommandText = txtQuery;
            cmd.ExecuteNonQuery();
            CloseCo();
        }

        public List<Room> getRooms(MoveOut mo)
        {
            List<Room> result = new List<Room>();
            OpenCo();
            string query = "SELECT * FROM Room";
            cmd = new SQLiteCommand(query, my_co); 
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Room(reader["id"], reader["name"], reader["Color"], mo));
            }
            CloseCo();
            return result;
        }

        public List<Box> getBoxes(Room r)
        {
            List<Box> result = new List<Box>();
            OpenCo();
            string query = "SELECT * FROM Box WHERE fatherRoom ="+r.id;
            cmd = new SQLiteCommand(query, my_co);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Box(reader["id"], reader["name"]mo));
            }
            CloseCo();
            return result;
        }

    }
}