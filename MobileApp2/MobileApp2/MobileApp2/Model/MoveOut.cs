using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp2.Model
{
    class MoveOut
    {

        private string name;

        private User user;

        private Room[] rooms;
        private int countRooms;


        public MoveOut(string n, User usr)

        {

            name = n;

            user = usr;
            countRooms = 0;
            rooms = new Room[10];
        }

        public void addRoom(Room r)
        {
            rooms[countRooms] = r;
            countRooms++;
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
        public int CountRooms
        {
            get
            {
                return countRooms;
            }
            set
            {
                countRooms = value;
            }
        }
        public Room[] Rooms
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
