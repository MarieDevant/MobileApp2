using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp2.Model
{
    class Room
    {

        private string name;

        private Color color;

        private MoveOut moveOut;



        public Room(string n, Color c, MoveOut mo)

        {

            name = n;

            color = c;

            moveOut = mo;

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

        public Color Color
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

    }

}
