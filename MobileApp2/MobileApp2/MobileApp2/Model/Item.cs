using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MobileApp2.Model
{
    class Item
    {

        private string name;

        private string image;

        private string description;




        public Item(string n, string pathImage, string desc)

        {

            name = n;

            image = pathImage;

            description = desc;

        }

        [JsonConstructor] public Item(string n)
        {

            name = n;

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
