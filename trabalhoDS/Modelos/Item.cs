using LiteDB;

namespace Modelos
{
public class Item : Registro
{
    public string nome { get; set; }
    public string custo { get; set; }

    [BsonId]
    public int id { get; set; }

    public void SetNome (string nome)
    {
        this.nome = nome;
    }

    public string GetNome()
    {
        return nome;
    }

    public void SetCusto (string custo)
    {
        this.custo = custo;
    }

    public string GetCusto()
    {
        return custo;
    }

    public void SetId (int id)
    {
        this.id = id;
    }

    public int GetId()
    {
        return id;
    }

}
}