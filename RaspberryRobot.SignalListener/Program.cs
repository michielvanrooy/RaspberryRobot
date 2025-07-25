using RaspberryRobot.SignalListener.SignalR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<SignalRClient>(sp =>
{
    var logger = sp.GetRequiredService<ILogger<SignalRClient>>();
    var hubUrl = builder.Configuration.GetValue<string>("SignalR:HubUrl") ?? "https://localhost:7001/messagehub";
    return new SignalRClient(hubUrl);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
