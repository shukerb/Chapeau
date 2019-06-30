using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChepeauModel
{
    public enum Enum_OrderStatus
    {
        //when you make a new order
        Not_Ready = 1,
        ////when you send the order to the kitchen or bar
        Sent,
        //when the chef or bartender accept it
        Preparing,
        // when the chef or bartender is done
        Ready,
        // when the dish is served
        Served,
        //when its paid
        Complete
    }
}
