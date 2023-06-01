using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasPeck.Config.Data
{
    public class TradeData
    {
        public string MarketID;
        public decimal TradePrice;
        public decimal Size;

        public TradeData(string s)
        {
            var temp = s.Split(',');
            if (temp.Length < 3)
            {
                throw new Exception($"Arguments received [{temp.Length}] is fewer than exected [3].");
            }
            MarketID = temp[0];
            TradePrice = decimal.Parse(temp[1]);
            Size = decimal.Parse(temp[2]);
        }
    }
}
