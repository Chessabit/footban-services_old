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
using Footban.Trading.Interfaces.Model.Request;
using Footban.Trading.Interfaces.Model.Response;

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

        public Task<FilterPlayerResponse> FilterPlayerCards(FilterPlayerRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<FilterShoutResponse> FilterShoutCards(FilterShoutRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
