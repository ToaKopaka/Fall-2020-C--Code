using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnOfMasters
{
    class PantsMaster : ClothingMaster, IReport
    {

        public PantsMaster(String name, int clothingAmount) : base(name, clothingAmount)
        {
            this.name = name;
            this.clothingAmount = clothingAmount;

        }

        public string Report()
        {
            return ("My name is " + name + " and I wear " + clothingAmount + " pants.");
        }
    }
}
