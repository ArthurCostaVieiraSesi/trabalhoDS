using LiteDB;

namespace Modelos
{
    public class Item : Registro, IEquatable<Item>
    {
        public string nome { get; set; }
        public string custo { get; set; }

        [BsonId]
        public int Id { get; set; }


        public bool Equals(Item other)
        {
            return Id == other.Id;
        }
    }
}