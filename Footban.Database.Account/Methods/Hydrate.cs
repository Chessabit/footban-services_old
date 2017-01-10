using Footban.Database.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footban.Database.Account.Methods
{
    public class Hydrate : DatabaseCommand<int, HydratePlayerStateResponse>
    {
        public async override Task<HydratePlayerStateResponse> ExecuteAsync(int request)
        {
            return new HydratePlayerStateResponse();
        }
              
    }
}
