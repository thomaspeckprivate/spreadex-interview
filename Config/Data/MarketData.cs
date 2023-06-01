using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasPeck.Config.Data
{
    public class MarketData
    {
        public string MarketID;
        public decimal CurrentAskPrice;
        public decimal CurrentBidPrice;

        public MarketData(string s)
        {
            var temp = s.Split(',');
            if (temp.Length < 3)
            {
                throw new Exception($"Arguments received [{temp.Length}] is fewer than exected [3].");
            }
            MarketID = temp[0];
            CurrentAskPrice = decimal.Parse(temp[1]);
            CurrentBidPrice = decimal.Parse(temp[2]);
        }
    }
}
