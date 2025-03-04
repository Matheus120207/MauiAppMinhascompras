var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.MAuiAppMinhasCompras_ApiService>("apiservice");

builder.AddProject<Projects.MAuiAppMinhasCompras_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
