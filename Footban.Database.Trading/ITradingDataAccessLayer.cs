using Footban.Database.Trading.Model.Request;
using Footban.Database.Trading.Model.Response;
using System.Threading.Tasks;

namespace Footban.Database.Trading
{
    public interface ITradingDataAccessLayer
    {
        Task<HydrateTradingItemResponse> HydrateTradingItem(HydrateTradingItemRequest request);
    }
}
