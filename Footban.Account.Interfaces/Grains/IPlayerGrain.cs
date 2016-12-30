using Orleans;
using System.Threading.Tasks;

namespace Footban.Account.Interfaces.Grains
{
    public interface IPlayerGrain : IGrainWithGuidKey
    {
        Task LogOut();
    }
}
