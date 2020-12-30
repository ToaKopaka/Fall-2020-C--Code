using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcitingVirtualPet
   
{
    [Serializable]
class Mailman
    {
        //Extra feature mailman and it also uses events
        public event EventHandler Mail;

        public Mailman() { }

        public void MailArrives(int NumberOfMailMen)
        {
            EventHandler mailarrives = Mail;
            if(mailarrives != null)
            {
                MailManEventArgs e = new MailManEventArgs();
                e.Num = NumberOfMailMen;
                mailarrives(this, e);
            }
        }


    }
}
