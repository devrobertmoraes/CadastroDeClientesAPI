namespace CadastroDeClientesAPI.Domain;

/// <summary>
/// Representa a entidade Cliente, a principal do sistema.
/// </summary>
public class Cliente
{
    // Propriedades
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public DateTime DataCadastro { get; private set; }

    // construtor
    public Cliente(string nome, string email)
    {
        Id = Guid.NewGuid();
        Nome = nome;
        Email = email;
        DataCadastro = DateTime.UtcNow;
    }
}