namespace Modelos
{
    public class Material : Item
    {
        public Fornecedor fornecedor;
        public string descricao { get; set; }

    public void SetFornecedor (Fornecedor fornecedor)
    {
        this.fornecedor = fornecedor;
    }

    public Fornecedor GetFornecedor()
    {
        return fornecedor;
    }

    public void SetDescricao (string descricao)
    {
        this.descricao = descricao;
    }

    public string GetDescricao()
    {
        return descricao;
    }


    }
    
}