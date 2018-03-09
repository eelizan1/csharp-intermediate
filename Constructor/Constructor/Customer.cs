using System.Collections.Generic;

namespace Constructor
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> orders; 

        public Customer()
        {
            // always initialize the list empty
            orders = new List<Order>(); 
        }

        public Customer(int id)
            :this() // calls the first constructor - so we can initialize the list
        {
            this.Id = id; 
        }

        public Customer(int id, string name)
            :this(id) // uses the first two contrusctors
        {
            //this.Id = id;
            this.Name = name; 
        }
    }

    public class Order
    {

    }
}
