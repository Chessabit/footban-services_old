using Footban.Trading.Interfaces.Grains;
using Orleans;
using Orleans.Concurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Footban.Trading.Interfaces.Model;

namespace Footban.Trading.Grains
{
    [StatelessWorker]
    public class TradingItemLookupGrain : Grain, ITradingItemLookupGrain
    {

        public Task<List<TradingItem>> FilterTradingItems(TradingItem tradingItemDelta)
        {
            throw new NotImplementedException();
        }
    }
}
