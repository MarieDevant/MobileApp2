using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp2.Model
{
    class Load
    {
        private User usr;
        private MoveOut moveOut;
        private Room[] rooms;

        public Load(User me, MoveOut mi, Room[] r)
        {
            usr = me;
            moveOut = mi;
            rooms = r;
        }

        public User Usr
        {
            get
            {
                return usr;
            }
            set
            {
                usr = value;
            }
        }

        public MoveOut MoveOut
        {
            get
            {
                return moveOut;
            }
            set
            {
                moveOut = value;
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
