using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders; // This has to be initialized, because the default value will be null, and we would get a null reference.

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id) 
        {
            this.Name = name;
        }

        
    }
}
