namespace Modelos
{
public class Produto : Item
{

    Material material;

    string preco;

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

}
}