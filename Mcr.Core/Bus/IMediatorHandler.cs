using Mcr.Core.Commands;
using System.Threading.Tasks;

namespace Mcr.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
    }
}
