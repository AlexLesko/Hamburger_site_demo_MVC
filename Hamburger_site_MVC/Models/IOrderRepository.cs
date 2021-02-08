using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hamburger_site_MVC.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
