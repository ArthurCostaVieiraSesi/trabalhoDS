namespace Modelos
{
    public class Cliente : Pessoa, IEquatable<Cliente>
    {

        public bool Equals(Cliente other)
        {
            return Id == other.Id;
        }

    }
    
}
