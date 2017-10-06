using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp2.Model
{
    class Room
    {

        private string name;

        private ConsoleColor color;

        private MoveOut moveOut;

        private List<Box> boxes;




        public Room(string n, ConsoleColor c, MoveOut mo)

        {

            name = n;

            color = c;

            moveOut = mo;
            mo.addRoom(this);
            boxes = new List<Box>();

        }

        public void addBox(Box b)
        {
            boxes.Add(b);
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

        public ConsoleColor Color
        {

            get
            {

                return color;

            }

            set
            {

                color = value;

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
        public List<Box> Boxes
        {
            get
            {
                return boxes;
            }
            set
            {
                boxes = value;
            }
        }

    }

}
