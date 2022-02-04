using System;
namespace EmployeeSystem;
class Program
{
    static void Main(string[] args)
    {

        Customer customer1 = new Customer()
        {
            FirstName = "Andy",
            LastName = "Chang",
            CustomerId = 1,
        };

        Order order1 = new Order()
        {
            OrderName = "Shampoo",
            OrderDate = new DateTime(2008, 3, 1, 7, 0, 0)
        };
        Order order2 = new Order()
        {
            OrderName = "Sofa",
            OrderDate = new DateTime(2010, 3, 1, 7, 0, 0)
        };

        Order order3 = new Order(); //null order

        Console.WriteLine(order1.OrderID.ToString());

        customer1.FullName();
        customer1.AddOrder(order1);
        customer1.AddOrder(order2);
        customer1.AddOrder(order3);
        customer1.HistoryOrder();


        Order order4 = new Order()
        {
            OrderID = order1.OrderID,
            OrderName = "TV",
            OrderDate = new DateTime(2010, 3, 1, 7, 0, 0)
        };

        //updating add an Order with an existing OrderNumber should replace the existing Order (not add a duplicate) 
        customer1.AddOrder(order4);
        customer1.HistoryOrder();

        //order date
        Console.WriteLine(order4.OrderDate.ToString());

        //Add order date in the future

        Order order5 = new Order()
        {
            OrderName = "Mac",
            OrderDate = new DateTime(2023, 3, 1, 7, 0, 0)
        };

        customer1.AddOrder(order5);
        customer1.HistoryOrder();
    }


 }

