using ServiceStack;
using FounderMode.ServiceModel;

namespace FounderMode.ServiceInterface;

public class MyServices : Service
{
    public object Any(Hello request)
    {
        return new HelloResponse { Result = $"Hello World!" };
    }
}