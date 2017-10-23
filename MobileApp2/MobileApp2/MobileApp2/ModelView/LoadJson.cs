﻿using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using MobileApp2.Model;
using MobileApp2.Android;

namespace MobileApp2.ModelView
{
    class LoadJson
    {
		const string filename = "TestDatabase.json";
        public static Load database;

        public LoadJson(){}

        public static Load LoadTheJson()
		{
			var fileService = Xamarin.Forms.DependencyService.Get<ISaveAndLoad>();
			var output = "";

			output = fileService.LoadTextAsync(filename);
			Load lo = JsonConvert.DeserializeObject<Load>(output);
            database = lo;
            AppDomain.CurrentDomain.SetData("load", lo);
            return lo;
		}
        public static void SaveTheJson(Load lo){
            string jsonData = JsonConvert.SerializeObject(lo, Formatting.Indented);
			System.IO.File.WriteAllText(filename, jsonData);
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
