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
        public static void FindObject(string toFind, Load lo, out List<Room> foundR, out List<Box> foundB, out List<Item> foundI)
        // Return 3 lists containing the objects where the string ToFind is contained in the name of the object
        {
            toFind = toFind.ToLower();

            List<ToDoItem> found = new List<ToDoItem>();

            foreach (ToDoItem obj in list)
            {
                if (obj.Name.Contains(toFind))
                {
                    found.Add(obj);

                    foundR = new List<Room>();
                    foundB = new List<Box>();
                    foundI = new List<Item>();
                    for (int i = 0; i < lo.MoveOut.Rooms.Count; i++)
                    {
                        Room r = lo.MoveOut.Rooms[i];
                        if (r.Name.ToLower().Contains(toFind))
                        {
                            foundR.Add(r);
                        }
                        for (int j = 0; j < r.Boxes.Count; j++)
                        {
                            Box b = r.Boxes[j];
                            if (b.Name.ToLower().Contains(toFind))
                            {
                                foundB.Add(b);
                            }
                            for (int k = 0; k < b.Items.Count; k++)
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

            }
        }
    }
}
