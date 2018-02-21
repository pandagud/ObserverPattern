using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace ObserverPatternStocks
{
    class RandomStockGenerator
    {
        Stopwatch sw = new Stopwatch();
        Random r = new Random();

        public void Generator(Subject s)
        {

            double value = s.Value;
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            {
                sw.Start();
                while (sw.ElapsedMilliseconds > 1000)
                {
                    double val = Convert.ToDouble(r.Next(95, 105)) / 100;
                    s.setValue(Math.Round(val * s.Value, 2));
                    sw.Stop();
                    sw.Reset();
                }
            }
        }
    }
}
