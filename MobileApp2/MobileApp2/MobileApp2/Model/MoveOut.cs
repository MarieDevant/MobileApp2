using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MobileApp2.Model
{
    class MoveOut
    {

        private string name;
        private List<Room> rooms;


        public MoveOut(string name)

        {

            this.name = name;
            rooms = new List<Room>();
        }
		[JsonConstructor] public MoveOut(string name, List<Room> rooms)

		{

			this.name = name;
            this.rooms = rooms;
		}

        public void addRoom(Room r)
        {
            rooms.Add(r);
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
