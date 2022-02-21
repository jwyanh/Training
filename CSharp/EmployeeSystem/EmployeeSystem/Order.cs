using System;
namespace EmployeeSystem
{
    public class Order
    {
        public Guid OrderID = Guid.NewGuid();

        public string OrderName { get; set; }

        public Nullable<DateTime> OrderDate { get; set; }
    }
}

