using Orleans;
using System.Threading.Tasks;
using System;
using Orleans.Streams;
using Footban.Account.Model.State;
using Footban.Account.Model.Streams;
using Footban.Account.Interfaces.Grains;

namespace Footban.Account.Grains
{

    public class PlayerGrain : Grain<PlayerState>, 
        IPlayerGrain, 
        IAsyncObserver<MatchMakingPayload>
    {
        private IStreamProvider _streamProvider;
        public Task LogOut()
        {
            DeactivateOnIdle();
            return TaskDone.Done;
        }

        public override Task OnActivateAsync()
        {
            _streamProvider = GetStreamProvider("MatchMakingStream");
            return TaskDone.Done;
        }



        public Task OnCompletedAsync()
        {
            throw new NotImplementedException();
        }

        public Task OnErrorAsync(Exception ex)
        {
            throw new NotImplementedException();
        }

        public Task OnNextAsync(MatchMakingPayload item, StreamSequenceToken token = null)
        {
            throw new NotImplementedException();
        }
    }
}
