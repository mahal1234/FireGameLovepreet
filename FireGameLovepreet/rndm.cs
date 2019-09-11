using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGameLovepreet
{
   public class Rndm
    {
        Random rd = new Random();
        public int fireMatch() {
            return rd.Next(1,8);
        }
    }
}
