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
                return lo;
			}

		}
        public static void SaveTheJson(Load lo){
            string jsonData = JsonConvert.SerializeObject(lo, Formatting.Indented);
			System.IO.File.WriteAllText(path, jsonData);
        }

    }
}
