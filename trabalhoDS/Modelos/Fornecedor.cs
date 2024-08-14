namespace Modelos
{
public class Fornecedor : Pessoa
{

    public string cep { get; set; }

    public void SetCep (string cep)
    {
        this.cep = cep;
    }

    public string GetCep()
    {
        return cep;
    }

}
}
