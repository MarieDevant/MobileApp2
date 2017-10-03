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

        private Box[] boxes;
        private int countBox; 




        public Room(string n, ConsoleColor c, MoveOut mo)

        {

            name = n;

            color = c;

            moveOut = mo;
            mo.addRoom(this);
            boxes = new Box[10];
            countBox = 0;

        }

        public void addBox(Box b)
        {
            boxes[countBox] = b;
            countBox = 0;
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
        public Box[] Boxes
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
        public int CountBox
        {
            get
            {
                return countBox;
            }
            set
            {
                countBox = value;
            }
        }

    }

}
