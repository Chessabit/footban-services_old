using Footban.Services.Database.Account.Model.Request;
using Footban.Services.Database.Account.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footban.Database.Account.Methods
{
    public class LogIn
    {
        public async Task<LogInResponse> LogInAsync(LogInRequest request)
        {
            return new LogInResponse();
        }
    }
}
