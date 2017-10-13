using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MobileApp2.Model
{
    class Room
    {

        private string name;

        private ConsoleColor color;

        private List<Box> boxes;

        public Room(string n, ConsoleColor c)

        {

            name = n;

            color = c;

            boxes = new List<Box>();

        }
		[JsonConstructor] public Room(string n, ConsoleColor c, List<Box> l)

		{

			name = n;

			color = c;

			boxes = l;
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
