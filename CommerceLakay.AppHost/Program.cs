var builder = DistributedApplication.CreateBuilder(args);

var productApi = builder.AddProject<Projects.CommerceLakay_ProductService>("apiservice-product");
var orderApi = builder.AddProject<Projects.CommerceLakay_OrderService>("apiservice-order");

builder.AddProject<Projects.CommerceLakay_Web>("frontend-ui")
    .WithReference(productApi)
    .WithReference(orderApi);

builder.Build().Run();
