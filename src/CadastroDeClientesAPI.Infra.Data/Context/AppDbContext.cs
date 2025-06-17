using CadastroDeClientesAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeClientesAPI.Infra.Data.Context;

public class AppDbContext : DbContext
{
    // Este DbSet representa a tabela de Clientes no banco de dados.
    public DbSet<Cliente> Clientes { get; set; }

    // O construtor que recebe as configurações de conexão do banco de dados.
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}