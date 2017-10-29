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

        public static List<ToDoItem> FindObject(string toFind, List<ToDoItem> list)
        // Return a list containing the objects where the string ToFind is contained in the name of the object
        {
            toFind = toFind.ToLower();
            List<ToDoItem> found = new List<ToDoItem>();

            foreach(ToDoItem obj in list){
                if (obj.Name.Contain(toFind)){
                    found.Add(obj);
                }
            }
            return found;
        }
    }
}
