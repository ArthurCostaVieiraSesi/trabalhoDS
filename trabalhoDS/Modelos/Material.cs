namespace Modelos
{
    public class Material : Item, IEquatable<Material>
    {
        public Fornecedor Fornecedor;
        public string descricao { get; set; }

        public bool Equals(Material other)
        {
            return Id == other.Id;
        }
    }

}