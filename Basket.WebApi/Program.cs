using Basket.WebApi.GrpcClientServices;
using Basket.WebApi.Protos;
using Basket.WebApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddStackExchangeRedisCache(options => { options.Configuration = builder.Configuration["CacheSettings:ConnectionString"]; });
builder.Services.AddScoped<IBasketRepository, BasketRepository>();

builder.Services.AddScoped<DiscountGrpcService>();
builder.Services.AddGrpcClient<DiscountProtoService.DiscountProtoServiceClient>(options =>
    options.Address = new Uri(builder.Configuration["GrpcSettings:DiscountUrl"]));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(x => { x.SwaggerEndpoint("/swagger/v1/swagger.json", "V1"); x.RoutePrefix = ""; });
app.UseAuthorization();
app.MapControllers();

app.Run();