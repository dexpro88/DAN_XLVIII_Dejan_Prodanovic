﻿using DAN_XLVIII_Dejan_Prodanovic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAN_XLVIII_Dejan_Prodanovic.Service
{
    interface IPizzeriaService
    {
        List<tblPizza> GetPizzas();
        List<tblOrder> GetOrdersOfGuest(string JMBG);
        tblOrder AddOrder(tblOrder order);
        tblPizzaOrder AddPizzaOrder(tblPizzaOrder pizzaOrder);
        List<tblOrder> GetOrders();
        List<tblPizzaOrder> GetPizzaOrdersByOrderID(int orderId);
    }
}
