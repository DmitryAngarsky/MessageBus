using System.Threading.Tasks;
using EventTower.Messages;

namespace EventTower
{
    public interface IMessageHandler<T> where T : IMesssage
    {
        Task Handle(T messsage);
    }
}