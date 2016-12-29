using Orleans;
using System.Threading.Tasks;

namespace Footban.Services.Account.Grains
{
    public interface IPlayerGrain : IGrainWithGuidKey
    {
        Task LogOut();
    }
}
