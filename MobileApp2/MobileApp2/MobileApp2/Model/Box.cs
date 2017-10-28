using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MobileApp2.Model
{
    public class Box
    {
        public int id { get; set; }
        private string name;

        private string image;

        private string qrcode;

        private string description;

        public Room fatherRoom{ get; set; }
        private List<Item> items;



        public Box(int i,string n, string pathImage, string descr, string pathQRCode, Room father)

        {
            id = i;
            name = n;
            fatherRoom = father;
            image = pathImage;
            description = descr;
            qrcode = pathQRCode;
            items = new List<Item>();
        }

        public Box(int i, string n, Room father)
        {
            id = i;
            name = n;
			fatherRoom = father;

			image = "none";
            qrcode = "none";
            description = "none";
            items = new List<Item>();

        }

		[JsonConstructor] public Box(int i,string n, List<Item> l)
		{
            id = i;
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
