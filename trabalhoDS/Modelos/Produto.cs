namespace Modelos
{
public class Produto : Item
{

    Material material;

    public string preco { get; set; }

    public string estoque { get; set; }

    public void SetPreco (string preco)
    {
        this.preco = preco;
    }

    public string GetPreco()
    {
        return preco;
    }

    public void SetMaterial (Material material)
    {
        this.material = material;
    }

    public Material GetMaterial()
    {
        return material;
    }

    public void SetEstoque (string estoque)
    {
        this.estoque = estoque;
    }

    public string GetEstoque()
    {
        return estoque;
    }

}
}