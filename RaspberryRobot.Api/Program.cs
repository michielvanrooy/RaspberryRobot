using RaspberryRobot.Api.Hubs;
using RaspberryRobot.Core;
using RaspberryRobot.Core.Interfaces;
using RaspberryRobot.Core.MotorActions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        "AllowAllOrigins",
        policy =>
        {
            policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IMotorAction, ForwardLeftAction>();
builder.Services.AddSingleton<IMotorAction, ForwardRightAction>();
builder.Services.AddSingleton<IMotorAction, ReverseLeftAction>();
builder.Services.AddSingleton<IMotorAction, ReverseRightAction>();
builder.Services.AddTransient<ICamera, Camera>();

builder.Services.AddSingleton<MotorActionFactory>();

builder.Services.AddTransient<IRobot, Robot>();


//builder.Services.AddSingleton<SignalRClient>(sp =>
//{
//    var logger = sp.GetRequiredService<ILogger<SignalRClient>>();
//    var hubUrl = builder.Configuration.GetValue<string>("SignalR:HubUrl") ?? "https://localhost:7001/messagehub";
//    return new SignalRClient(hubUrl);
//});

// Register the hosted service to start the client
//builder.Services.AddHostedService<SignalRClientHostedService>();

builder.Services.AddSignalR();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAllOrigins");

app.UseAuthorization();

app.MapControllers();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<MessageHub>("/messagehub");
});

app.Run();
