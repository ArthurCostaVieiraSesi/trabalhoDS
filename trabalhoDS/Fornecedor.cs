namespace Modelos
{
public class Fornecedor : Pessoa
{

    string cep;

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
