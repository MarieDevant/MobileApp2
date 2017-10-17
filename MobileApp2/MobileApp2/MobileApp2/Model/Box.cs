using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MobileApp2.Model
{
    public class Box
    {
        private string name;

        private string image;

        private string qrcode;

        private string description;


        private List<Item> items;



        public Box(string n, string pathImage, string descr, string pathQRCode)

        {

            name = n;

            image = pathImage;
            description = descr;
            qrcode = pathQRCode;
            items = new List<Item>();
        }

        public Box(string n)
        {

            name = n;

            image = "none";

            qrcode = "none";
            description = "none";
            items = new List<Item>();

        }

		[JsonConstructor] public Box(string n, List<Item> l)
		{

			name = n;

			image = "none";

			qrcode = "none";
			description = "none";
			items = l;
		}
        public void addItem(Item i)
        {
            items.Add(i);
        }
        public void deleteItem(Item i){
            items.Remove(i);
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

        public string Qrcode

        {

            get
            {            
                return qrcode;
            }

            set

            {

                qrcode = value;



            }

        }

        public List<Item> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
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
