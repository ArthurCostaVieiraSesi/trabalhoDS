using LiteDB;

namespace Modelos
{
    public class Estoque : Registro
    {

    public Produto Produto { get; set; }

    public string valor { get; set; }

    public string quantidade { get; set; }

    public string obs { get; set; }

    [BsonId]
    public int Id { get; set; }


    }
    
}