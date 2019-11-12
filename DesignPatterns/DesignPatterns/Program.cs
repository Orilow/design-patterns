using Example_06.ChainOfResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bancomat();
            var s = bank.CashOut(253, "$");
            Console.ReadKey();
        }
    }
}
