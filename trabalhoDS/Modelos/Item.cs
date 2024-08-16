using LiteDB;

namespace Modelos
{
public class Item : Registro
{
    public string nome { get; set; }
    public string custo { get; set; }

    [BsonId]
    public int Id { get; set; }


}
}