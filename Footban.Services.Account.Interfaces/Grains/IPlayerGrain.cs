using Orleans;
using System.Threading.Tasks;

namespace Footban.Services.Account.Interfaces.Grains
{
    public interface IPlayerGrain : IGrainWithGuidKey
    {
        Task LogOut();
    }
}
