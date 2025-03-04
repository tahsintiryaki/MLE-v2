using MassTransit;
using MLE.IntegrationHandler.Events;

namespace MLE.IntegrationHandler.Consumers;

public class OrderCreatedEventHandler : IConsumer<OrderCreatedEvent>
{
    public async Task Consume(ConsumeContext<OrderCreatedEvent> context)
    {
        Console.WriteLine($"{context.Message.Id} nolu order was created.");
    }
}