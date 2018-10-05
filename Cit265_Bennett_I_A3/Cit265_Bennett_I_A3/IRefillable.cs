using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cit265_Bennett_I_A3
{
    //Interface is a lightweight structure that is a simple datatype/method holder
    interface IRefillable
    {
        void Refill(int amt);

        float FuelPercentage
        {
            get;

        }
    }
}
