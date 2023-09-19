using GeekShop.MessageBus;

namespace geekShop.MessageBus
{
    public interface IMessageBus
    {
        Task PublicMessage(BaseMessage message, string topicName);
    }
}