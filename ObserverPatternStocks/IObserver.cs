﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternStocks
{
    public interface IObserver
    {
        void Update(Subject s);
    }
}
