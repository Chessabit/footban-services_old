using System.Threading.Tasks;
using Footban.Services.Database.Account.Model.Request;
using Footban.Services.Database.Account.Model.Response;

namespace Footban.Services.Database.Account
{
    public interface IAccountDataAccessLayer
    {
        /// <summary>
        /// Logs active sesion into database.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<LogInResponse> LoginAsync(LogInRequest request);
    }
}