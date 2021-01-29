using EventTower.Messages;
using RabbitMQ.Client;

namespace EventTower
{
    public class DefaultRabbitMQAdapter : IRabbitMQAdapter
    {
        private IModel _consumerChannel;
        private bool _isConnected = false;
        private const string COMMAND_EXCHANGE_NAME = "CommandExchange";
        private const string EVENT_EXCHANGE_NAME = "EventExchange";
        private int retryCount = 4;
        private string queueName;
        private IConnection _connection;
        private ConnectionFactory factory = new ConnectionFactory() {HostName = "localhost"};
        public event MessageReceived MessageReceived;
        public void TryConnection()
        {
            throw new System.NotImplementedException();
        }

        public void BasicPublish(ICommand command, string destination)
        {
            throw new System.NotImplementedException();
        }

        public void BasicPublish(IEvent @event)
        {
            throw new System.NotImplementedException();
        }

        public void StartConsuming()
        {
            throw new System.NotImplementedException();
        }
    }
}