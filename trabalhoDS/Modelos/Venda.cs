using Modelos;

namespace Venda
{
    public class Venda : Registro
    {
        Cliente cliente;
        string datap;
        string datae;
        string total;
        string desconto;
        int id;

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

    }

}