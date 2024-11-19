using Grpc.Net.Client;
using grpcMessageClient;
using grpcServer;



class Program
{
    static async Task Main(string[] args)
    {
        // Kanalı oluşturun (gRPC sunucusuna bağlanmak için)
         var channel = GrpcChannel.ForAddress("https://localhost:5225");

        var messageClient = new Message.MessageClient(channel);

       MessageResponse response =   messageClient.SendMessage (new MessageRequest{
            Message = "Merhaba",
            Name = "EMRECAN"
        });

        System.Console.WriteLine(response.Message);

        // // GreeterClient'ı başlatın
        // var greetClient = new Greeter.GreeterClient(channel);

        // HelloReply result = await greetClient.SayHelloAsync(new HelloRequest
        // {
        //     Name = "Emreden Selamlar"
        // });

        // System.Console.WriteLine(result.Message);



    }
}
