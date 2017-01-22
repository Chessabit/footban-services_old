using Footban.Database.Trading.Model.Request;
using Footban.Database.Trading.Model.Response;
using System.Threading.Tasks;

namespace Footban.Database.Trading
{
    public interface ITradingDataAccessLayer
    {
        Task<HydratePlayerCardStateResponse> HydratePlayerCardState(HydratePlayerCardStateRequest request);
        Task<HydrateShoutCardStateResponse> HydrateShoutCardState(HydrateShoutCardStateRequest request);
    }
}
