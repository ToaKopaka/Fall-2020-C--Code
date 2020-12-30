using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcitingVirtualPet
    
{
    //Extra Feature that uses a decorator pattern for my extra pattern
    [Serializable]
    class NewTrick : TrickDecorator
    {
        public override int NumTricks
        {
            get { return Trick.NumTricks + 1; }
            
        }




        public NewTrick(ITrick b)
        {
            Trick = b;
        }

    }
}
