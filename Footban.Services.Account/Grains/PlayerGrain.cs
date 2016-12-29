using Orleans;
using System.Threading.Tasks;
using System;
using Orleans.Streams;
using Footban.Services.Account.Model.;
using Footban.Services.Account.Model.State;
using Footban.Services.Account.Model.Streams;

namespace Footban.Services.Account.Grains
{

    public class PlayerGrain : 
        Grain<PlayerState>, 
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
            _streamProvider = this.GetStreamProvider("MatchMakingStream");
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
