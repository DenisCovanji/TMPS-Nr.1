using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = Account.With()
                .Name("John")
                .Surname("Snow")
                .Gender("Male")
                .Age("25")
                .Marital_status("Single")
                .Build();

            Console.ReadLine();
        }
    }
}
