using Footban.Database.Account.Model.Request;
using Footban.Database.Account.Model.Response;
using Footban.Database.Common;
using System.Threading.Tasks;

namespace Footban.Database.Account.Methods
{
    public class LogIn : DatabaseCommand<LogInRequest, LogInResponse>
    {
        
        public async override Task<LogInResponse> ExecuteAsync(LogInRequest request)
        {
            return new LogInResponse();
        }
    }
}
