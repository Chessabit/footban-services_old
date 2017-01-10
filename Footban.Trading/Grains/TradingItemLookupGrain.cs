using Footban.Trading.Interfaces.Grains;
using Orleans;
using Orleans.Concurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Footban.Trading.Interfaces.Model;
using Footban.Database.Trading;

namespace Footban.Trading.Grains
{
    [StatelessWorker]
    public class TradingItemLookupGrain : Grain, ITradingItemLookupGrain
    {
        private ITradingDataAccessLayer _tradingDataAccessLayer;
        
        public TradingItemLookupGrain()
        {
            _tradingDataAccessLayer = new TradingDataAccessLayer();
        }

        public TradingItemLookupGrain(ITradingDataAccessLayer tradingDataAccessLayer)
        {
            _tradingDataAccessLayer = tradingDataAccessLayer;
        }

        public Task<List<TradingItem>> FilterTradingItems(TradingItem tradingItemDelta)
        {
            throw new NotImplementedException();
        }
    }
}
