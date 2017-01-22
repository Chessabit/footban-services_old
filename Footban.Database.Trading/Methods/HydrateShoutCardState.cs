using Footban.Database.Common;
using Footban.Database.Trading.Model.Request;
using Footban.Database.Trading.Model.Response;
using System;
using System.Threading.Tasks;

namespace Footban.Database.Trading.Methods
{
    public class HydrateShoutCardState : DatabaseCommand<HydrateShoutCardStateRequest, HydrateShoutCardStateResponse>
    {
        public override Task<HydrateShoutCardStateResponse> ExecuteAsync(HydrateShoutCardStateRequest request)
        {
            throw new NotImplementedException();
        }
                
    }
}
