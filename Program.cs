
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    // Registers MVC & Web API services.
    .AddMvcCore()
    .AddDataAnnotations()
    .AddAuthorization()
    // Registers services to generate OpenApi Specifications (via third party library).
    .AddApiExplorer();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();
