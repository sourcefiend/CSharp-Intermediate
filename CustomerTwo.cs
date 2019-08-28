using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class CustomerTwo
    {
        public int Id;
        public string Name;
        public readonly List<OrderTwo> Orders = new List<OrderTwo>();

        public CustomerTwo(int id)
        {
            this.Id = id;
        }

        public CustomerTwo(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            // ...
        }
    }

    public class OrderTwo
    {

    }
}
