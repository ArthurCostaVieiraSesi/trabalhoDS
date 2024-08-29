using LiteDB;

namespace Modelos
{
    public class Venda : Registro
    {
        public Cliente Cliente { get; set; }
        public string datap { get; set; }
        public string datae { get; set; }
        public string total { get; set; }
        public string desconto { get; set; }

        [BsonId]
        public int Id { get; set; }
        public Produto Produto { get; set; }

    }

}
