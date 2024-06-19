var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.task1_ApiService>("apiservice");

builder.AddProject<Projects.task1_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
