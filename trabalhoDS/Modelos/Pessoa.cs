using LiteDB;

namespace Modelos
{
    public class Pessoa : Registro
    {
    public string nome { get; set; }
    public string telefone { get; set; }
    public string cpf { get; set; }
    public string email { get; set; }

    [BsonId]
    public int Id { get; set; }

    }
}