using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasPeck.Config
{
    public class MarketPriceConfig
    {
        public decimal CurrentAskPrice { get; }
        public decimal CurrentBidPrice { get; }

        public MarketPriceConfig (decimal currentAskPrice, decimal currentBidPrice)
        {
            CurrentAskPrice = currentAskPrice;
            CurrentBidPrice = currentBidPrice;
        }
    }
}
