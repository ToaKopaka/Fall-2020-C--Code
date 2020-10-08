using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ReturnOfMasters
{
    class HatMaster :  ClothingMaster, IReport
    {

        

        public HatMaster(String name, int clothingAmount) : base(name, clothingAmount)
        {
            this.name = name;
            this.clothingAmount = clothingAmount;

        }

        public string Report()
        {
            return ("My name is " + name + " and I wear " + clothingAmount + " hats.");
        }
    }
}
