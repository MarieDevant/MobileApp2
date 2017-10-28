using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MobileApp2.Model
{
    public class Room
    {
        public int id { get; set; }
        private string name;

        private ConsoleColor color;

        private List<Box> boxes;

        public MoveOut fatherMoveOut{ get; set; }

        public Room(int i, string n, ConsoleColor c, MoveOut father)

        {
            id = i;

            name = n;
            fatherMoveOut = father;
            color = c;

            boxes = new List<Box>();

        }
		[JsonConstructor] public Room(int i, string n, ConsoleColor c, List<Box> l, MoveOut father)

		{
            id = i;

            name = n;
			fatherMoveOut = father;
			color = c;

			boxes = l;
		}

        public void addBox(Box b)
        {
            boxes.Add(b);
        }
        public void deleteBox(Box b){
            boxes.Remove(b);
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
