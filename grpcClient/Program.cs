using Grpc.Net.Client;
using grpcServer;


class Program
{
    static async Task Main(string[] args)
    {
        // Kanalı oluşturun (gRPC sunucusuna bağlanmak için)
        using var channel = GrpcChannel.ForAddress("https://localhost:7109");

        // GreeterClient'ı başlatın
        var greetClient = new Greeter.GreeterClient(channel);

        HelloReply result = await greetClient.SayHelloAsync(new HelloRequest
        {
            Name = "Emreden Selamlar"
        });

        System.Console.WriteLine(result.Message);



    }
}
