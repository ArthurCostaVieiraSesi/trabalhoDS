using LiteDB;

namespace Modelos
{
    public class Estoque : Registro
    {

    Produto produto;

    public string valor { get; set; }

    public string desconto { get; set; }

    public string obs { get; set; }

    [BsonId]
    public int id { get; set; }

    public void SetProduto (Produto produto)
    {
        this.produto = produto;
    }

    public Produto GetProduto()
    {
        return produto;
    }

    public void SetValor (string valor)
    {
        this.valor = valor;
    }

    public string GetValor()
    {
        return valor;
    }

    public void SetDesconto (string desconto)
    {
        this.desconto = desconto;
    }

    public string GetDesconto()
    {
        return desconto;
    }

    public void SetObs (string obs)
    {
        this.obs = obs;
    }

    public string GetObs()
    {
        return obs;
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