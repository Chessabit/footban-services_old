using System.Threading.Tasks;
using Orleans;
using Footban.Trading.Interfaces.Grains;
using Footban.Trading.Interfaces.Observerables;
using Orleans.Runtime;
using System;
using Footban.Database.Trading;
using Footban.Database.Trading.Model.Request;
using Footban.Database.Trading.Model.State;

namespace Footban.Trading.Grains
{
    /// <summary>
    /// Item that can be traded.
    /// </summary>
    public class ShoutTradingItemGrain: Grain<ShoutCardState>, IShoutTradingItemGrain
    {
        private Logger _logger;
        private ObserverSubscriptionManager<IShoutItemObserver> _subscriptions;
        private ITradingDataAccessLayer dataAccess;

        public async override Task OnActivateAsync()
        {
            _logger = GetLogger();
            _subscriptions = new ObserverSubscriptionManager<IShoutItemObserver>();
            State = (await dataAccess.HydrateShoutCardState(new HydrateShoutCardStateRequest())).State;
        }

       public Task Bid()
        {
            throw new NotImplementedException();
        }

        public Task Subscribe(IShoutItemObserver observer)
        {
            throw new NotImplementedException();
        }

        public Task Unsubscribe(IShoutItemObserver observer)
        {
            throw new NotImplementedException();
        }
    }
}
