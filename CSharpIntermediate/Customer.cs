using System;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        public Customer()
        {
            
        }
        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            var rating = CalculateRating();
            if (rating == 0)
            {
                Console.WriteLine("Promoted to Level 1");
            }
            else
            {
                Console.WriteLine("Promote to Level 2");
            }
        }

        protected int CalculateRating()
        {
            return 0;
        }
    }
}