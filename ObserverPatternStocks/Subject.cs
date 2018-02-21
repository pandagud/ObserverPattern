using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternStocks
{
    public abstract class Subject
    {
        List<IObserver> olist;
        Random r;
        private double value;
        public double Value
        {
            get
            {
                return value;
            }

            protected set
            {
                this.value = value;
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Subject()
        {
            olist = new List<IObserver>();
            Value = 0;
            r = new Random();
        }

        public abstract void setValue(double i);

        public void Attach(IObserver o)
        {
            olist.Add(o);
        }

        public void Detach(IObserver o)
        {
            olist.Remove(o);
        }

        public void Notify(Subject s)
        {
            foreach (var item in olist)
            {
                item.Update(s);
            }
        }

    }
}