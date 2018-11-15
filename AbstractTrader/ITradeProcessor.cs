﻿using System.Collections.Generic;
using System.IO;

namespace AbstractTrader
{
    public interface ITradeProcessor
    {
        void ProcessTrades(Stream stream);
    }
}
