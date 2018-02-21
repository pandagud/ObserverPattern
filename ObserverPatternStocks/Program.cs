using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternStocks
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject s_Vestas = new Stock_Vestas();
            Subject s_Novo = new Stock_Novo();
            Portfolio p = new Portfolio();
            p.AddSubject(s_Vestas);
            p.AddSubject(s_Novo);

            foreach (var item in p.stocks)
            {
                Console.WriteLine("Input the value for the " + item.Name + ": ");
                item.setValue(double.Parse(Console.ReadLine()));
            }
            Console.ReadLine(); 
            


        }
    }
}
