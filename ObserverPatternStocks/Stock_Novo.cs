using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ObserverPatternStocks
{
    class Stock_Novo : Subject
    {
        RandomStockGenerator rsg;
        bool first;
        public Stock_Novo(): base()
        {
            Name = "Novo";
            rsg = new RandomStockGenerator();
            first = true;
        }

        public override void setValue(double i)
        {
            Value = i;
            Notify(this);
            
            if (first)
            {
                first = false;
                Thread t = new Thread(() => rsg.Generator(this));
                t.Start();
            }

        }
    }
}
