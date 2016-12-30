using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footban.Services.Database.Common
{
    public class DataAccessMethods<TMethod, TArg, TReturn> 
        where TMethod : Task<Func<TArg, TReturn>>
    { 

    }
}
