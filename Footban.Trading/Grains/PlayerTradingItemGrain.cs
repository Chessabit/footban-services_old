using System.Threading.Tasks;
using Orleans;
using Footban.Trading.Interfaces.Grains;
using Footban.Trading.Interfaces.Observerables;
using Orleans.Runtime;
using System;
using Footban.Database.Trading;
using Footban.Trading.Interfaces.Model;
using Footban.Database.Trading.Model.Request;
using Footban.Database.Trading.Model.State;

namespace Footban.Trading.Grains
{
    /// <summary>
    /// Item that can be traded.
    /// </summary>
    public class PlayerTradingItemGrain: Grain<PlayerCardState>, IPlayerTradingItemGrain
    {
        private Logger _logger;
        private ObserverSubscriptionManager<IPlayerItemObserver> _subscriptions;
        private ITradingDataAccessLayer dataAccess;

        public async override Task OnActivateAsync()
        {
            _logger = GetLogger();
            _subscriptions = new ObserverSubscriptionManager<IPlayerItemObserver>();
            State = (await dataAccess.HydratePlayerCardState(new HydratePlayerCardStateRequest())).State;
        }

        public Task Subscribe(IPlayerItemObserver observer)
        {
            throw new NotImplementedException();
        }

        public Task Unsubscribe(IPlayerItemObserver observer)
        {
            throw new NotImplementedException();
        }

        public Task Bid()
        {
            throw new NotImplementedException();
        }
    }
}
