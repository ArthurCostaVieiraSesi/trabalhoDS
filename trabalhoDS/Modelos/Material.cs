namespace Modelos
{
    public class Material : Item
    {
        Fornecedor fornecedor;

    public void SetFornecedor (Fornecedor fornecedor)
    {
        this.fornecedor = fornecedor;
    }

    public Fornecedor GetFornecedor()
    {
        return fornecedor;
    }


    }
    
}