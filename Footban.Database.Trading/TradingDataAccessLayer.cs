using Footban.Database.Trading.Methods;
using Footban.Database.Trading.Model.Request;
using Footban.Database.Trading.Model.Response;
using System.Threading.Tasks;

namespace Footban.Database.Trading
{
    public class TradingDataAccessLayer : ITradingDataAccessLayer
    {
        public async Task<HydratePlayerCardStateResponse> HydratePlayerCardState(HydratePlayerCardStateRequest request)
        {
            return await new HydratePlayerCardState().ExecuteAsync(request);
        }

        public async Task<HydrateShoutCardStateResponse> HydrateShoutCardState(HydrateShoutCardStateRequest request)
        {
            return await new HydrateShoutCardState().ExecuteAsync(request);
        }
    }
}
