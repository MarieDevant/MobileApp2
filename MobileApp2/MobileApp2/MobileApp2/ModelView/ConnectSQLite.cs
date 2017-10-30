using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using MobileApp2.Model;
using SQLite.Net;
using Xamarin.Forms;
using SQLite.Net.Interop;
using MobileApp2.Interfaces;

namespace MobileApp2.ModelView
{
    class ConnectSQLite
    {
        private static SQLiteConnection my_co;
        private static SQLiteCommand cmd;

		public static void OpenCo()
		{
            my_co = new SQLiteConnection(DependencyService.Get<ISQLitePlatform>(),
                DependencyService.Get<IFileHelper>().GetLocalpath("MyDatabase.s3db"));
			my_co.
		}
		public static void CloseCo()
		{
			my_co.Close();
		}
		public void ExecuteQuery(string txtQuery)
		{
			OpenCo();
			cmd = my_co.CreateCommand();
			cmd.CommandText = txtQuery;
			cmd.ExecuteNonQuery();
			CloseCo();
		}
		public void addItem(EventArgs[] args)
		{
			//To call when creating an Item
			Box fatherBox = new Box(0, "bla", "bla", "none", "unknco", new Room(0, "blezr", ConsoleColor.Blue, new MoveOut(0, "hollidays")));//(Box)args[2];
			Room fatherR = fatherBox.fatherRoom;
			MoveOut fatherMO = fatherR.fatherMoveOut;
			ExecuteQuery("INSERT INTO Item(id,name,image, description,fatherBox,fatherRoom,fatherMoveOut)" + args);
		}
		public void deleteItem(Item it)
		{
			ExecuteQuery("DELETE FROM Item WHERE id = " + it.id);
		}
		public void addBox(EventArgs[] args)
		{
			//To call when creating an Box
			Room fatherR = new Room(0, "blezr", ConsoleColor.Blue, new MoveOut(0, "hollidays"));//(Room)args[2];
			MoveOut fatherMO = fatherR.fatherMoveOut;
			ExecuteQuery("INSERT INTO Box(id,name,image,qrcode, description,fatherRoom,fatherMoveOut)" + args);
		}
		public void deleteBox(Box b)
		{
			ExecuteQuery("DELETE FROM Box WHERE id = " + b.id);
		}
		public void addRoom(EventArgs[] args)
		{
			//To call when creating an Room
			//MoveOut fatherMO = (MoveOut)args[2];
			ExecuteQuery("INSERT INTO Room(id,name,Color, fatherMoveOut)" + args);
		}
		public void deleteRoom(Room r)
		{
			ExecuteQuery("DELETE FROM Room WHERE id = " + r.id);
		}

		public static MoveOut getMoveOut()
		{
			MoveOut mo = null;
			OpenCo();
			string query = "SELECT * FROM MoveOut";
			cmd = new SqliteCommand(query, my_co);
			SqliteDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				mo = new MoveOut(int.Parse(reader["id"].ToString()), reader["name"].ToString());
			}
			CloseCo();
			return mo;
		}
		public static List<Room> getRooms(MoveOut mo)
		{
			List<Room> result = new List<Room>();
			OpenCo();
			string query = "SELECT * FROM Room";
			cmd = new SqliteCommand(query, my_co);
			SqliteDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				result.Add(new Room(int.Parse(reader["id"].ToString()), reader["name"].ToString(), (ConsoleColor)Enum.Parse(typeof(ConsoleColor), reader["Color"].ToString()), mo));
			}
			CloseCo();
			return result;
		}

		public static List<Box> getBoxes(Room r)
		{
			List<Box> result = new List<Box>();
			OpenCo();
			string query = "SELECT * FROM Box WHERE fatherRoom =" + r.id;
			cmd = new SqliteCommand(query, my_co);
			SqliteDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				result.Add(new Box(int.Parse(reader["id"].ToString()), reader["name"].ToString(), r));
			}
			CloseCo();
			return result;
		}
		public static List<Item> getItems(Box b)
		{
			List<Item> result = new List<Item>();
			OpenCo();
			string query = "SELECT * FROM Item WHERE fatherBox =" + b.id;
			cmd = new SqliteCommand(query, my_co);
			SqliteDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				result.Add(new Item(int.Parse(reader["id"].ToString()), reader["name"].ToString(), b));
			}
			CloseCo();
			return result;
		}

		public static Load getLoadDatabase(User me)
		{
			MoveOut mo = getMoveOut();
			mo.Rooms = getRooms(mo);
			foreach (Room r in mo.Rooms)
			{
				r.Boxes = getBoxes(r);
				foreach (Box b in r.Boxes)
				{
					b.Items = getItems(b);
				}
			}
			return new Load(me, mo);
		}
		public List<Room> searchRoom(string search)
		{
			List<Room> result = new List<Room>();
			OpenCo();
			string query = "SELECT * FROM Room";
			cmd = new SqliteCommand(query, my_co);
			SqliteDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				if (reader["name"].ToString().ToLower().Contains(search.ToLower()))
				{

					MoveOut mo = new MoveOut(0, "blabla");
					result.Add(new Room(int.Parse(reader["id"].ToString()), reader["name"].ToString(), (ConsoleColor)Enum.Parse(typeof(ConsoleColor), reader["Color"].ToString()), mo));
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