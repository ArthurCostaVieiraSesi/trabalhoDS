namespace Modelos
{
public class Item
{
    string nome;
    string estoque;
    string custo;
    string descricao;
    int id;

    public void SetNome (string nome)
    {
        this.nome = nome;
    }

    public string GetNome()
    {
        return nome;
    }

    public void SetEstoque (string estoque)
    {
        this.estoque = estoque;
    }

    public string GetEstoque()
    {
        return estoque;
    }

    public void SetCusto (string custo)
    {
        this.custo = custo;
    }

    public string GetCusto()
    {
        return custo;
    }

    public void SetDescricao (string descricao)
    {
        this.descricao = descricao;
    }

    public string GetDescricao()
    {
        return descricao;
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