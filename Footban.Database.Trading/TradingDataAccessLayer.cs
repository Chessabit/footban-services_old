using Footban.Database.Trading.Methods;
using Footban.Database.Trading.Model.Request;
using Footban.Database.Trading.Model.Response;
using System.Threading.Tasks;

namespace Footban.Database.Trading
{
    public class TradingDataAccessLayer : ITradingDataAccessLayer
    {
        public async Task<HydrateTradingItemResponse> HydrateTradingItem(HydrateTradingItemRequest request)
        {
            return await new HydrateTradingItem().ExecuteAsync(request);
        }
    }
}
