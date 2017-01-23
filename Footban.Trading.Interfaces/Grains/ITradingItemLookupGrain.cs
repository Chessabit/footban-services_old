using Footban.Trading.Interfaces.Model;
using Footban.Trading.Interfaces.Model.Request;
using Footban.Trading.Interfaces.Model.Response;
using Orleans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footban.Trading.Interfaces.Grains
{
    public interface ITradingItemLookupGrain : IGrainWithGuidKey
    {
        Task<FilterPlayerResponse> FilterPlayerCards(FilterPlayerRequest request);
        Task<FilterShoutResponse> FilterShoutCards(FilterShoutRequest request);
    }
}
