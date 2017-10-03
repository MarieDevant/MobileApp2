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

        private Room room;

        private Item[] items;
        private int countItems;



        public Box(string n, string pathImage, string pathQRCode, Room roomFather)

        {

            name = n;

            image = pathImage;

            qrcode = pathQRCode;
            items = new Item[10];
            countItems = 0;

            room = roomFather;
            room.addBox(this);

        }

        public Box(string n, Room roomFather)
        {

            name = n;

            image = "none";

            qrcode = "none";

            items = new Item[10];
            countItems = 0;
            room = roomFather;
            room.addBox(this);


        }

        public void addItem(Item i)
        {
            items[countItems] = i;
            countItems++;
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

        public Item[] Items
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
        public int CountItems
        {
            get
            {
                return countItems;
            }
            set
            {
                countItems = value;
            }
        }

    }
}
