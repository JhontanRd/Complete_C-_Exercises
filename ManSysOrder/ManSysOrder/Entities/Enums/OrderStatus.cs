using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManSysOrder.Entities.Enums
{
    internal enum OrderStatus : int
    {
        Received = 0,
        InPreparation = 1,
        Ready = 2,
        Delivered = 3
    }
}
