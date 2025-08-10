using RaspberryRobot.Core;
using RaspberryRobot.Core.Interfaces;
using RaspberryRobot.Core.MotorActions;
using RaspberryRobot.SignalListener.SignalR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IMotorAction, ForwardLeftAction>();
builder.Services.AddSingleton<IMotorAction, ForwardRightAction>();
builder.Services.AddSingleton<IMotorAction, ReverseLeftAction>();
builder.Services.AddSingleton<IMotorAction, ReverseRightAction>();
builder.Services.AddSingleton<MotorActionFactory>();
builder.Services.AddTransient<IRobot, Robot>();

builder.Services.AddSingleton<SignalRClient>(sp =>
{
    var robot = sp.GetRequiredService<IRobot>();
    var logger = sp.GetRequiredService<ILogger<SignalRClient>>();
    var hubUrl = builder.Configuration.GetValue<string>("SignalR:HubUrl") ?? "https://localhost:7001/messagehub";
    return new SignalRClient(hubUrl, robot);
});

builder.Services.AddHostedService<SignalRClientHostedService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
