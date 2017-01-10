using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footban.Database.Common
{
    public abstract class DatabaseCommand<TRequest, TResponse>
    {
        public abstract Task<TResponse> ExecuteAsync(TRequest request);
    }
}
