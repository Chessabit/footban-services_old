using Footban.Database.Common;
using Footban.Database.Trading.Model.Request;
using Footban.Database.Trading.Model.Response;
using System;
using System.Threading.Tasks;

namespace Footban.Database.Trading.Methods
{
    public class HydratePlayerCardState : DatabaseCommand<HydratePlayerCardStateRequest, HydratePlayerCardStateResponse>
    {
        public override Task<HydratePlayerCardStateResponse> ExecuteAsync(HydratePlayerCardStateRequest request)
        {
            throw new NotImplementedException();
        }
                
    }
}
