using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask.model
{
    internal class Customer
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Default Constructor
        public Customer()
        {
        
        }

        // Parameterized Constructor
        public Customer(string customerName, string email, string phoneNumber)
        {
            CustomerName = customerName;
            Email = email;
            PhoneNumber = phoneNumber;
        }


        public void customerDetails()
        {
            Console.WriteLine("Customer Details");
            Console.WriteLine($"Customer Name{CustomerName}");
            Console.WriteLine($"Email{Email}");
            Console.WriteLine($"Customer Phone Number{PhoneNumber}");
        }
    }
}
