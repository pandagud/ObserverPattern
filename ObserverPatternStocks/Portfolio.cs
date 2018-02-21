using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternStocks
{
    public class Portfolio : IObserver
    {
        public List<Subject> stocks = new List<Subject>();
        public void Update(Subject s)
        {
            Console.WriteLine("The value of " + s.Name + " is " + s.Value);
        }

        public void AddSubject(Subject s)
        {
            s.Attach(this);
            stocks.Add(s);
        }
    }
}
