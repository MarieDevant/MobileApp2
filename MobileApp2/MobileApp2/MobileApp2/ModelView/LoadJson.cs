﻿using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using MobileApp2.Model;

namespace MobileApp2.ModelView
{
    class LoadJson
    {
		public static string path = "../JsonData/TestDatabase.json";
        public static Load database;


		public static Load LoadTheJson(string json)
		{
/*#if __IOS__
var resourcePrefix = "MobileApp2.iOS.";
#endif
#if __ANDROID__
var resourcePrefix = "MobileApp2.Droid.";
#endif
#if WINDOWS_PHONE
var resourcePrefix = "MobileApp2.WinPhone.";
#endif

            var assembly = typeof(LoadJson).GetType().Assembly;
			Stream stream = assembly.GetManifestResourceStream(resourcePrefix+"TestDatabase.json");
			using (StreamReader r = new StreamReader(path+"TestDatabase.json"))
			{
				string json = r.ReadToEnd();

                Load lo = JsonConvert.DeserializeObject<Load>(json);
                database = lo;
                return lo;
			*/
            Load lo = JsonConvert.DeserializeObject<Load>(json);
            return lo;
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
