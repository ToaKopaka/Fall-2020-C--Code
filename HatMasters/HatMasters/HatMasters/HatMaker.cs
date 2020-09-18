using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HatMasters
{
    class HatMaker
    {
        private byte hats;
        private String name;
        public HatMaker(String name, byte hats)
        {
            this.hats = hats;
            this.name = name;
        }

       
        
        public String getName()
        {
            return name;
        }
        
        public byte getHats()
        {
            return hats;
        }

        public void printInfo()
        {
            MessageBox.Show("This master's name is " + name + " and the number of hats " + name + " has is " + hats);
        }



    }
}
