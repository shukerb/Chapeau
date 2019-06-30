using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChepeauModel
{
    public enum Enum_OrderStatus
    {
        //when you send the order to the kitchen 
        Sent = 1,
        //when the chef accept it
        Preparing,
        // when the chef is done
        Ready,
        // when the dich is served
        served,
        //when its paid
        complete

    }
}
