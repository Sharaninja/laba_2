using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Albert", "Einstein", 38, "Apple123");
            Console.WriteLine(user.ToString());
        }
    }
}
