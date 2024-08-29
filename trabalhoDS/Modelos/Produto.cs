namespace Modelos
{
    public class Produto : Item, IEquatable<Produto>
    {

    public Material Material { get; set; }

    public string preco { get; set; }

    public string estoque { get; set; }

    public bool Equals(Produto other)
        {
            return Id == other.Id;
        }


    }
}