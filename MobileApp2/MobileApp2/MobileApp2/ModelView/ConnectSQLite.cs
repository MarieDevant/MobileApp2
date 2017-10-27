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
        private void addItem(EventArgs[] args){
            //To call when creating an Item
            fatherBox = args[2];
            fatherR = fatherBox.FatherRoom;
            fatherMO = fatherR.FatherMoveOut;
            ExecuteQuery("INSERT INTO Item(id,name,image, description,fatherBox,fatherRoom,fatherMoveOut)"+args);
        }
        private void deleteItem(Item it){
            ExecuteQuery("DELETE FROM Item WHERE id = "+it.id);
        }
		private void addBox(EventArgs[] args)
		{
			//To call when creating an Box
			fatherR = args[2];
			fatherMO = fatherR.FatherMoveOut;
			ExecuteQuery("INSERT INTO Box(id,name,image,qrcode, description,fatherRoom,fatherMoveOut)" + args);
		}
		private void deleteBox(Box b)
		{
			ExecuteQuery("DELETE FROM Box WHERE id = "+b.id);
		}
		private void addBox(EventArgs[] args)
		{
			//To call when creating an Room
			fatherMO = args[2];
			ExecuteQuery("INSERT INTO Room(id,name,Color, fatherMoveOut)" + args);
		}
		private void deleteRoom(Room r)
		{
			ExecuteQuery("DELETE FROM Room WHERE id = " + r.id);
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
                result.Add(new Box(reader["id"], reader["name"], r));
            }
            CloseCo();
            return result;
        }
        public List<Item> getItems(Box b){
			List<Item> result = new List<Item>();
			OpenCo();
			string query = "SELECT * FROM Item WHERE fatherBox =" + b.id;
			cmd = new SQLiteCommand(query, my_co);
			SQLiteDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				result.Add(new Box(reader["id"], reader["name"], b));
			}
			CloseCo();
			return result;
        }

        public List<Room> searchRoom(string search){
			List<Room> result = new List<Room>();
			OpenCo();
			string query = "SELECT * FROM Room";
			cmd = new SQLiteCommand(query, my_co);
			SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["name"].contains(search))
                {
                    result.Add(new Room(reader["id"], reader["name"], reader["Color"], mo));
                }
            }
			CloseCo();
			return result;
        }
		/*public List<Box> searchBox(string search)
		{
			List<Box> result = new List<Box>();
			OpenCo();
			string query = "SELECT * FROM Box";
			cmd = new SQLiteCommand(query, my_co);
			SQLiteDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				if (reader["name"].contains(search))
				{
					result.Add(new Box(reader["id"], reader["name"], new Room()));
				}
			}
			CloseCo();
			return result;
		}*/
    }
}