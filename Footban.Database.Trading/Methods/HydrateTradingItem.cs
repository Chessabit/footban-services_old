using Footban.Database.Common;
using Footban.Database.Trading.Model.Request;
using Footban.Database.Trading.Model.Response;
using System;
using System.Threading.Tasks;

namespace Footban.Database.Trading.Methods
{
    public class HydrateTradingItem : DatabaseCommand<HydrateTradingItemRequest, HydrateTradingItemResponse>
    {
        public override Task<HydrateTradingItemResponse> ExecuteAsync(HydrateTradingItemRequest request)
        {
            throw new NotImplementedException();
        }
                
    }
}
