using Grpc.Core;
using GrpcGreeter;

namespace GrpcGreeter.Services;

public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;

    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        System.Console.Error.WriteLine($"🟥[1]: GreeterService.cs:18: request.Name={request.Name}");
        return Task.FromResult(new HelloReply { Message = "Hello " + request.Name });
    }
}
