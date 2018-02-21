using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ObserverPatternStocks
{
    class Stock_Vestas: Subject
    {
        RandomStockGenerator rsg;
        bool first;
        public Stock_Vestas(): base()
        {
            Name = "Vestas";
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
                rsg.Generator(this);
            }

        }
    }
}
