using Yarp.ReverseProxy.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));
//.LoadFromMemory(new List<RouteConfig>()
//{
//    new()
//    {
//        RouteId = "API1-Route",
//        ClusterId = "API1-Cluster",
//        Match = new(){ Path = "{**catch-all}" },
//        Transforms = new List<Dictionary<string, string>>()
//        {
//            new()
//            {
//                { "PathPattern", "{**catch-all}" }
//            }
//        }
//    }
//},
//new List<ClusterConfig>
//{
//    new()
//    {
//        ClusterId = "API1-Cluster",
//        LoadBalancingPolicy = "RoundRobin",
//        Destinations = new Dictionary<string, DestinationConfig>()
//        {
//            { "destination1", new(){  Address = "https://localhost:7177" } },
//            { "destination2", new(){  Address = "https://localhost:7178" } },
//            { "destination3", new(){  Address = "https://localhost:7179" } },
//        }
//    }
//});

var app = builder.Build();

app.MapReverseProxy();

app.Run();
