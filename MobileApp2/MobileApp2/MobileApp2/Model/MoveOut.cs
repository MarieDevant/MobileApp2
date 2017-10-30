using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MobileApp2.Model
{
    public class MoveOut
    {
        private int id { get; set; }
        private string name;
        private List<Room> rooms;


        public MoveOut(int i,string name)

        {
            id = i;
            this.name = name;
            rooms = new List<Room>();
        }
		[JsonConstructor] public MoveOut(int i,string name, List<Room> rooms)

		{
            id = i;
            this.name = name;
            this.rooms = rooms;
		}

        public void addRoom(Room r)
        {
            rooms.Add(r);
        }
        public void deleteRoom(Room r){
            rooms.Remove(r);
        }

        public string Name
        {

            get
            {

                return name;

            }

            set
            {

                name = value;

            }

        }

        public List<Room> Rooms
        {
            get
            {
                return rooms;
            }
            set
            {
                rooms = value;
            }
        }

    }

}
