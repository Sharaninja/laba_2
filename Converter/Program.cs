using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(30.0, 0.60, 32.0);

            //USD
            Console.WriteLine(converter.ConvertUsd(1000));
            Console.WriteLine(converter.ConvertUsd(1000, false));
            Console.WriteLine();

            //EUR
            Console.WriteLine(converter.ConvertEur(1000));
            Console.WriteLine(converter.ConvertEur(1000, false));
            Console.WriteLine();

            //rub
            Console.WriteLine(converter.ConvertRub(1000));
            Console.WriteLine(converter.ConvertRub(1000, false));
        }
    }
}
