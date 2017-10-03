using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp2.Model
{
    class User
    {

        private string name;

        private string password;



        public User(string n, string pw)

        {

            name = n;

            password = pw;

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

        public string Password
        {

            get
            {

                return password;

            }

            set
            {

                password = value;

            }

        }

    }

}
