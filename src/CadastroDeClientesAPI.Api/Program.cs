using CadastroDeClientesAPI.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// --- Início da Adição ---
// 1. pega a string de conexão do appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// 2. registra o AddDbContext no sistema de injeção de dependências
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

// 3. adiciona services ao container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 4. constói toda a aplicação com base nas configurações
var app = builder.Build();

// 5. Configura o pipeline de requisições HTTP (como o app vai se comportar) em ambiente de desenvolvimento, mostra a página de documentação do Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// 6. Coloca a aplicação para rodar e esperar por requisições
app.Run();