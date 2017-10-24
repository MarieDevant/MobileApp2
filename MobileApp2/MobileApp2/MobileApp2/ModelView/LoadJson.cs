﻿using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using MobileApp2.Model;

namespace MobileApp2.ModelView
{
    class LoadJson
    {
		public static string path = "Users/Daniel/Documents/GitHub/MobileApp2/MobileApp2/MobileApp2/MobileApp2/JsonData/TestDatabase.json";
        public static Load database;
		public static void test()
        {
            Load lo = LoadJson.LoadTheJson();
            lo.MoveOut.addRoom(new Room("Surprise",ConsoleColor.Black));
			for (int i = 0; i < lo.MoveOut.Rooms.Count; i++)
			{
				Console.WriteLine(lo.MoveOut.Rooms[i].Name);
				for (int j = 0; j < lo.MoveOut.Rooms[i].Boxes.Count; j++)
				{
					Console.WriteLine(lo.MoveOut.Rooms[i].Boxes[j].Name);
					for (int k = 0; k < lo.MoveOut.Rooms[i].Boxes[j].Items.Count; k++)
					{
						Console.WriteLine(lo.MoveOut.Rooms[i].Boxes[j].Items[k].Name);
					}
				}
			}
			Console.ReadKey();
        }

		public static Load LoadTheJson()
		{
            
			using (StreamReader r = new StreamReader(path))
			{
				string json = r.ReadToEnd();

                Load lo = JsonConvert.DeserializeObject<Load>(json);
                database = lo;
                return lo;
			}

		}
        public static void SaveTheJson(Load lo){
            string jsonData = JsonConvert.SerializeObject(lo, Formatting.Indented);
			System.IO.File.WriteAllText(path, jsonData);
        }

        public static void RemoveItem(Item it)
        {
            Box fatherBox = FindBox(it);
            fatherBox.deleteItem(it);
        }
        public static void RemoveBox(Box b)
        {
            //Is the Garbage Collector going to delete the items in the box or should we do it by ourselves?
            Room fatherRoom = FindRoom(b);
            fatherRoom.deleteBox(b);
        }
        public static Room FindRoom(Box b)
        {
            foreach(Room r in database.MoveOut.Rooms)
            {
                foreach(Box box in r.Boxes)
                {
                    if (box == b)
                    {
                        return r;
                    }
                }
            }
            return new Room("unknown", ConsoleColor.White);
        }
        public static Box FindBox(Item i)
        {
            foreach (Room r in database.MoveOut.Rooms)
            {
                foreach (Box box in r.Boxes)
                {
                    foreach(Item it in box.Items)
                    {
                        if (i == it)
                        {
                            return box;
                        }
                    }
                }
            }
            return new Box("unknown");
        }

    }
}
