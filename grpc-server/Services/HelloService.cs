using eudaimonia.grpc.client.forecast.command;
using Grpc.Core;

namespace grpc_server.Services;

public class HelloService : ForecastCommandService.ForecastCommandServiceBase
{
    public override Task<Empty> HistoryUploadFinishedCommand(ForecastCommand request, ServerCallContext context)
    {
        return Task.FromResult(new Empty{Something = "Hello"});
    }
}