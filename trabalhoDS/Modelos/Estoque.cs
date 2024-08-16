using LiteDB;

namespace Modelos
{
    public class Estoque : Registro
    {

    public Produto produto;

    public string valor { get; set; }

    public string desconto { get; set; }

    public string obs { get; set; }

    [BsonId]
    public int Id { get; set; }


    }
    
}