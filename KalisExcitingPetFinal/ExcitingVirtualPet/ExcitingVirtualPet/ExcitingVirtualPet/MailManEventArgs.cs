using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcitingVirtualPet
    
{
    [Serializable]
    class MailManEventArgs : EventArgs
    {

        //Extra feature mailman and it also uses events
        public int Num = 0;
    }
}
