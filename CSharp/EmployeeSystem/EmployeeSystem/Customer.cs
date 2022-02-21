using System;
namespace EmployeeSystem
{
  class Customer
	{
		public Customer()
		{
		}

		public string FirstName { get; set; } // in C# 6.0 read-only auto-properties
		public string LastName { get; set; }
		public int CustomerId { get; set; }
        public List<Order> Orders = new List<Order>();

        public void FullName()
        {
			Console.WriteLine(FirstName + " " + LastName);
        }


        public void HistoryOrder()
        {
            Console.WriteLine("Your OrderHistory is : ");
            foreach (var entry in Orders)
            {
                Console.WriteLine(entry.OrderName);
            }
        }

        public void AddOrder(Order NewOrder)
        {
            int duplicate = 0;
            foreach (var entry in Orders)
            {
                if (NewOrder.OrderID == entry.OrderID)
                {
                    entry.OrderName = NewOrder.OrderName;
                    entry.OrderDate = NewOrder.OrderDate;
                    duplicate = 1;
                }
            }
            if (duplicate == 0)
            {
                Orders.Add(NewOrder);
            }
            
        }


    }
}

