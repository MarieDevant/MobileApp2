using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp2.Model
{
    class MoveOut
    {

        private string name;

        private User user;

        private List<Room> rooms;


        public MoveOut(string n, User usr)

        {

            name = n;

            user = usr;
            rooms = new List<Room>();
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

        public User User
        {

            get
            {

                return user;

            }

            set
            {

                user = value;

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
