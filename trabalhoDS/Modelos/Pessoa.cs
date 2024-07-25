namespace Modelos
{
public class Pessoa : Registro
{
    string nome;
    string telefone;
    string cpf;
    string email;
    int id;

    public void SetNome (string nome)
    {
        this.nome = nome;
    }

    public string GetNome()
    {
        return nome;
    }

    public void SetTelefone (string telefone)
    {
        this.telefone = telefone;
    }

    public string GetTelefone()
    {
        return telefone;
    }

    public void SetCpf (string cpf)
    {
        this.cpf = cpf;
    }

    public string GetCpf()
    {
        return cpf;
    }

    public void SetEmail (string email)
    {
        this.email = email;
    }

    public string GetEmail()
    {
        return email;
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