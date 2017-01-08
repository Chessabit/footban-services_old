using Orleans;
using System.Threading.Tasks;
using System;
using Orleans.Streams;
using Footban.Account.Model.State;
using Footban.Account.Model.Streams;
using Footban.Account.Interfaces.Grains;
using Footban.Database.Account;
using Orleans.Runtime;
using Orleans.Core;

namespace Footban.Account.Grains
{
    public class PlayerGrain : Grain<PlayerState>, 
        IPlayerGrain, 
        IAsyncObserver<MatchMakingPayload>
    {
        private IStreamProvider _streamProvider;
        private IAccountDataAccessLayer _accountDataAccessLayer;
        private Logger _logger; 

        public async override Task OnActivateAsync()
        {
            _streamProvider = GetStreamProvider("MatchMakingStream");
            _logger = GetLogger();
            State = (await _accountDataAccessLayer.HydrateAsync(0)).State;
        }

        public PlayerGrain()
        {
            _accountDataAccessLayer = new AccountDataAccessLayer();
        }

        public PlayerGrain(IGrainIdentity identity, 
            IGrainRuntime runtime,
            IAccountDataAccessLayer accountDataAccessLayer) 
                : base(identity, runtime, null, null)
        {
            _accountDataAccessLayer = accountDataAccessLayer;
        }

        public Task LogOut()
        {
            DeactivateOnIdle();
            return TaskDone.Done;
        }

        public Task OnCompletedAsync()
        {
            return TaskDone.Done;
        }

        public Task OnErrorAsync(Exception ex)
        {
            _logger.Error(0, $"Error occured when utilising match making stream caught in grain: {RuntimeIdentity}");
            return TaskDone.Done;
        }

        public Task OnNextAsync(MatchMakingPayload item, StreamSequenceToken token = null)
        {
            //TODO: Match making logic?
            return TaskDone.Done;
        }
    }
}
