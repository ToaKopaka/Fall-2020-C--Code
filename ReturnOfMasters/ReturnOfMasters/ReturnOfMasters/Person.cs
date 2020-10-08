using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReturnOfMasters
{
    class Person : IReport
    {
        protected String name;

        public Person(String name)
        {
            this.name = name;
        }



        public string Report()
        {
            return("My name is " + name + " and I am just happy to be here.");
        }
    }
}
