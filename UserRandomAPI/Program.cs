using Microsoft.EntityFrameworkCore;
using UserRandomAPI.Dao;
using UserRandomAPI.Repository;
using UserRandomAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DaoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection")));

builder.Services.AddHttpClient();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UsuarioServico>();

builder.Services.AddControllers();

// Adicione o serviço CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowMyReactApp",
        builder => builder.WithOrigins("http://localhost:3000") // Substitua com a URL do seu aplicativo React
                           .AllowAnyHeader()
                           .AllowAnyMethod());
});

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

// Aplique a política CORS
app.UseCors("AllowMyReactApp");

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
