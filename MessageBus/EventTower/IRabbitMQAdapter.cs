using EventTower.Messages;

namespace EventTower
{
    public delegate void MessageReceived(MessageReceivedEventArgs args);
    
    public interface IRabbitMQAdapter
    {
        event MessageReceived MessageReceived;
        void TryConnection();
        void BasicPublish(ICommand command, string destination);
        void BasicPublish(IEvent @event);
        void StartConsuming();
    }
}