using Footban.Database.Trading.Model.Response.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footban.Database.Trading.Model.Response
{
    public class FilterTradingItemsResponse
    {
        public IEnumerable<TradingItemData> TradingItems { get; set; }
    }
}
