using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnOfMasters
{
    abstract class ClothingMaster
    {
        protected String name;
        protected int clothingAmount;

        public ClothingMaster(String name, int clothingAmount)
        {
            this.clothingAmount = clothingAmount;
            this.name = name;

        }


    }
}
