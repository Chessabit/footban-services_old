using Footban.Database.Account.Model.Request;
using Footban.Database.Account.Model.Response;
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
