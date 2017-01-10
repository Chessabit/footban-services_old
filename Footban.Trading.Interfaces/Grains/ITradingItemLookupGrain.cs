using Footban.Trading.Interfaces.Model;
using Orleans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footban.Trading.Interfaces.Grains
{
    public interface ITradingItemLookupGrain : IGrainWithGuidKey
    {
        Task<List<TradingItem>> FilterTradingItems(TradingItem tradingItemDelta);
    }
}
