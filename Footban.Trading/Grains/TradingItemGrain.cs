using System.Threading.Tasks;
using Orleans;
using Footban.Trading.Interfaces.Grains;
using Footban.Trading.Interfaces.Observerables;
using Orleans.Runtime;
using System;

namespace Footban.Trading.Grains
{
    /// <summary>
    /// Item that can be traded.
    /// </summary>
    public class TradingItemGrain : Grain, ITradingItemGrain
    {
        private Logger _logger;
        private ObserverSubscriptionManager<ITradingItemObserver> _subscriptions;

        public override Task OnActivateAsync()
        {
            _logger = GetLogger();
            _subscriptions = new ObserverSubscriptionManager<ITradingItemObserver>();
            return TaskDone.Done;
        }

        public Task Bid(int playerId, int amount)
        {
            return TaskDone.Done;
        }

        public Task Subscribe(ITradingItemObserver observer)
        {
            _subscriptions.Subscribe(observer);
            return TaskDone.Done;
        }

        public Task Unsubscribe(ITradingItemObserver observer)
        {
            _subscriptions.Unsubscribe(observer);
            return TaskDone.Done;
        }

    }
}
