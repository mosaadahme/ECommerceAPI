using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Domain.Enums
{
    public enum OrderType: byte
    {
        Received,
        Approved,
        GettingReady,
        HasBeenShipped,
        Completed
    }
}
