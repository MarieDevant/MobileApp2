using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp2.Model
{
    class Box
    {
        private string name;

        private string image;

        private string qrcode;

        private string description;

        private Room room;

        private List<Item> items;



        public Box(string n, string pathImage, string descr, string pathQRCode, Room roomFather)

        {

            name = n;

            image = pathImage;
            description = descr;
            qrcode = pathQRCode;
            items = new List<Item>();
            room = roomFather;
            room.addBox(this);

        }

        public Box(string n, Room roomFather)
        {

            name = n;

            image = "none";

            qrcode = "none";
            description = "none";
            items = new List<Item>();
            room = roomFather;
            room.addBox(this);


        }

        public void addItem(Item i)
        {
            items.Add(i);
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

        public Room Room
        {

            get
            {

                return room;

            }

            set
            {

                room = value;

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
