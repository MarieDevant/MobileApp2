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



        public Box(string n, string pathImage, string pathQRCode, Room roomFather)

        {

            name = n;

            image = pathImage;

            qrcode = pathQRCode;

            room = roomFather;

        }

        public Box(string n, Room roomFather)
        {

            name = n;

            image = "none";

            qrcode = "none";

            room = roomFather;

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

    }
}
