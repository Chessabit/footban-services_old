using Footban.Services.Database.Account.Methods;
using Footban.Services.Database.Account.Model.Request;
using Footban.Services.Database.Account.Model.Response;
using System.Threading.Tasks;

namespace Footban.Services.Database.Account
{
    public class AccountDataAccessHelper
    {
        public async Task<LogInResponse> LoginAsync(LogInRequest request)
        {
            return await new LogIn().LogInAsync(request);
        }
    }
}
