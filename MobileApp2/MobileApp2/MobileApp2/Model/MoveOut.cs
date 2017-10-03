using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp2.Model
{
    class MoveOut
    {

        private string name;

        private User user;



        public MoveOut(string n, User usr)

        {

            name = n;

            user = usr;

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

        public User User
        {

            get
            {

                return user;

            }

            set
            {

                user = value;

            }

        }

    }

}
