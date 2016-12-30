using System.Threading.Tasks;
using Footban.Database.Account.Model.Request;
using Footban.Database.Account.Model.Response;

namespace Footban.Database.Account
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