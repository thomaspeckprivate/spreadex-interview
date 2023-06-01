using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasPeck.Config
{
    public class TradePriceConfig
    {
        public decimal TradePrice { get; }
        public decimal Size { get; }

        public TradePriceConfig(decimal tradePrice, decimal size)
        {
            TradePrice = tradePrice;
            Size = size;
        }
    }
}
