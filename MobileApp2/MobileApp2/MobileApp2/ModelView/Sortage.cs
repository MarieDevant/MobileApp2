using System;
using System.Collections.Generic;
using System.Text;
using MobileApp2.Model;
using System.Diagnostics;

namespace MobileApp2.ModelView
{
    class Sortage
    {
        
        public Sortage()
        {

        }
        public static void FindObject(string toFind,Load lo, out List<Room> foundR, out List<Box> foundB, out List<Item> foundI)
         // Return 3 arrays containing the objects where the string ToFind is contained in the name of the object
        {
            toFind = toFind.ToLower();
            foundR = new List<Room>();
            foundB = new List<Box>();
            foundI = new List<Item>();
            for (int i=0; i < lo.MoveOut.Rooms.Count; i++)
            {
                Room r = lo.MoveOut.Rooms[i];
                if (r.Name.ToLower().Contains(toFind))
                {
                    foundR.Add(r);
                }
                for(int j=0; j < r.Boxes.Count; j++)
                {
                    Box b = r.Boxes[j];
                    if (b.Name.ToLower().Contains(toFind))
                    {
                        foundB.Add(b);
                    }
                    for(int k=0; k < b.Items.Count; k++)
                    {
                        Item it = b.Items[k];
                        if (it.Name.ToLower().Contains(toFind))
                        {
                            foundI.Add(it);
                        }
                    }
                }
            }
        }
        public void Test()
        {
            string s = "b";

            // Initialize a fake database
            //User me = new User("me", "pwd");
            //MoveOut vacance = new MoveOut("vacances", me);
            //Room r1 = new Room("Living Room", ConsoleColor.Red, vacance);
            //Box b11 = new Box("B1LR", r1);
            //Item it111 = new Item("Lamp", b11);
            //Item it112 = new Item("Pillow", b11);
            //Box b12 = new Box("B2LR", r1);
            //Item it121 = new Item("Blap", b12);
            //Room r2 = new Room("Kitchen", ConsoleColor.Green, vacance);
            //Box b21 = new Box("B1K", r2);
            //Item it211 = new Item("Plates", b21);
            //Item it212 = new Item("Forks x24", b21);
            //Box b22 = new Box("B2K", r2);
            //Item it221 = new Item("Glasses", b22);
            //Room r3 = new Room("Garage", ConsoleColor.Blue, vacance);
            //Box b31 = new Box("B1G", r3);
            //Item it311 = new Item("Bike", b31);
            //List<Room> rooms = new List<Room>();
            //rooms.Add(r1);
            //rooms.Add(r2);
            //rooms.Add(r3);
            //Load lo = new Load(me, vacance, rooms);

            Load lo = LoadJson.LoadTheJson();
            List<Room> foundR; List<Box> foundB; List<Item> foundI;

            FindObject(s, lo,out foundR,out foundB,out foundI);

            foreach (Room r in foundR)
            {
                Debug.WriteLine(r.Name);

            }
            foreach (Box b in foundB)
            {
                Debug.WriteLine(b.Name);

            }
            foreach (Item i in foundI)
            {
                Debug.WriteLine(i.Name);

            }
        }
    }
}
