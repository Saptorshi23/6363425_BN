using Confluent.Kafka;

Console.WriteLine("Enter your name:");
string user = Console.ReadLine();

var config = new ProducerConfig
{
    BootstrapServers = "localhost:9092"
};

using var producer = new ProducerBuilder<Null, string>(config).Build();

Console.WriteLine("Type messages (type 'exit' to quit):");

while (true)
{
    var input = Console.ReadLine();
    if (input?.ToLower() == "exit") break;

    var msg = $"{user}: {input}";
    await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = msg });

    Console.WriteLine("Sent: " + msg);
}
