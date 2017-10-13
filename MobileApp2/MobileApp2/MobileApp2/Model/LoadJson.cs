using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace MobileApp2.Model
{
    class LoadJson
    {
		public static string path = "../TestDatabase.json";

		public static void test(string[] args)
        {
            Load lo = LoadJson.LoadTheJson();
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

    }
}
