using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MobileApp2.Model
{
    public class Item
    {
        private int id { get; set; }
        private string name;
        private Box fatherBox { get; set; }
        private string image;

        private string description;

        [JsonConstructor] public Item(int i,string n, string pathImage, string desc, Box b)

        {
            id = i;
            name = n;
            fatherBox = b;
            image = pathImage;

            description = desc;

        }

         public Item(int i,string n, Box b)
        {
            id = i;
            name = n;
			fatherBox = b;
			image = "none";

            description = "none";

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

        public string Image

        {

            get

            {

                return image;

            }

            set

            {

                image = value;

            }

        }

        public string Description

        {

            get

            {

                return description;

            }

            set

            {

                description = value;

            }

        }

    }

}
