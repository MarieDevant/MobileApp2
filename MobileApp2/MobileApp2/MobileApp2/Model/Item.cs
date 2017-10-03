using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp2.Model
{
    class Item
    {

        private string name;

        private string image;

        private string description;

        private Box box;



        public Item(string n, string pathImage, string desc, Box FatherBox)

        {

            name = n;

            image = pathImage;

            description = desc;

            box = FatherBox;
            FatherBox.addItem(this);

        }

        public Item(string n, Box FatherBox)
        {

            name = n;

            image = "none";

            description = "none";

            box = FatherBox;
            FatherBox.addItem(this);

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

        public Box Box

        {

            get

            {

                return box;

            }

            set

            {

                box = value;

            }

        }

    }

}
