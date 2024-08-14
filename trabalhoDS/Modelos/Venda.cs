using LiteDB;

using Modelos;

namespace Venda
{
    public class Venda : Registro
    {
        Cliente cliente;
        public string datap { get; set; }
        public string datae { get; set; }
        public string total { get; set; }
        public string desconto { get; set; }

        [BsonId]
        public int id { get; set; }
        Estoque estoque;

        public void SetCliente (Cliente cliente)
        {
            this.cliente = cliente;
        }

        public Cliente GetCliente()
        {
            return cliente;
        }

        public void SetDatap (string datap)
        {
            this.datap = datap;
        }

        public string GetDatap()
        {
            return datap;
        }

        public void SetDatae (string datae)
        {
            this.datae = datae;
        }

        public string GetDatae()
        {
            return datae;
        }

        public void SetTotal (string total)
        {
            this.total = total;
        }

        public string GetTotal()
        {
            return total;
        }

        public void SetDesconto (string desconto)
        {
            this.desconto = desconto;
        }

        public string GetDesconto()
        {
            return desconto;
        }

        public void SetId (int id)
    {
        this.id = id;
    }

    public int GetId()
    {
        return id;
    }

    public void SetEstoque (Estoque estoque)
    {
        this.estoque = estoque;
    }

    public Estoque GetEstoque()
    {
        return estoque;
    }

    }

}
