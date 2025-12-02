var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.EventManagementApp>("eventmanagementapp");

builder.Build().Run();
