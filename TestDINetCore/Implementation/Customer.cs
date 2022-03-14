using TestDINetCore.Abstractions;
using Microsoft.Extensions.Logging;
using System;

namespace TestDINetCore.Implementation
{
    public class Customer : ICustomer
    {
        public void CreateCustomer()
        {
            Console.WriteLine("Creating a customer with concrete class injected using constructor injection");
        }

        public void UpdateCustomer()
        {
            Console.WriteLine("Updating a customer with concrete class injected using constructor injection");
        }
    }
}
