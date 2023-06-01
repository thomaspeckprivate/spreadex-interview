using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using ThomasPeck.Config;
using ThomasPeck.Config.Data;

namespace ThomasPeck
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine(solution(args[0], args[1]));
        }


        ///<summary>Takes two strings to be decoded into a clients total profit or loss</summary>
        ///<returns>an integer of clients profit or loss</returns>
        public static int solution(string S, string T)
        {
            var marketData = new MarketConfig(S.Split('|').Select(x => new MarketData(x)).ToList());
            var tradeData = T.Split('|').Select(x => new TradeData(x)).ToList();

            var PnL = (decimal)0;

            foreach(var trade in tradeData)
            {
                var tempPnL = (decimal)0;
                var marketPrice = (decimal)0;
                if (marketData.Markets.TryGetValue(trade.MarketID, out var price))
                {
                    if (trade.Size > 0)                 // if purchasing
                    {
                        marketPrice = price.CurrentAskPrice;
                    } else if (trade.Size < 0)          // if selling
                    {
                        marketPrice = price.CurrentBidPrice;
                    }
                }
                tempPnL = (marketPrice - trade.TradePrice) * trade.Size;
                PnL += tempPnL;
            }

            return (int)PnL;
        }
    }

}
