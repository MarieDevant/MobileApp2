using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp2.Model
{
    public class Load
    {
        private User usr;
        private MoveOut moveOut;

        public Load(User me, MoveOut mi)
        {
            usr = me;
            moveOut = mi;
        }

        public User Usr
        {
            get
            {
                return usr;
            }
            set
            {
                usr = value;
            }
        }

        public MoveOut MoveOut
        {
            get
            {
                return moveOut;
            }
            set
            {
                moveOut = value;
            }
        }
    }
}
