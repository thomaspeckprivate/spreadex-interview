using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThomasPeck.Config.Data;

namespace ThomasPeck.Config
{
    public class MarketConfig
    {
        public IReadOnlyDictionary<string, MarketPriceConfig> Markets { get; }
        public MarketConfig(List<MarketData> data)
        {
            var temp = new Dictionary<string, MarketPriceConfig>();
            foreach (var item in data)
            {
                temp.Add(item.MarketID, new MarketPriceConfig(item.CurrentAskPrice, item.CurrentBidPrice));
            }
            Markets = temp;
        }
    }
}
