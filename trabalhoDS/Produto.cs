namespace Modelos
{
public class Produto : Item
{
    string preco;

    public void SetPreco (string preco)
    {
        this.preco = preco;
    }

    public string GetPreco()
    {
        return preco;
    }

}
}