using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvadersOOP
{
    class GameElements
    {
        public int speed_ { get; set; }


        public int move(int csmacd)
        {
            speed_ = csmacd;
            return speed_;
        }

    

    }
}
