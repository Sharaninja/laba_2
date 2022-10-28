using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address
            {
                Index = "02224",
                Country = "Ukraine",
                City = "Kiyv",
                Street = "Balsaka st.",
                House = "8A",
                Appartment = 41
            };

            Console.WriteLine(address.ToString());
        }
    }
}
