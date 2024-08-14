using LiteDB;

namespace Modelos
{
public class Pessoa : Registro
{
    public string nome { get; set; }
    public string telefone { get; set; }
    public string cpf { get; set; }
    public string email { get; set; }

    [BsonId]
    public int id { get; set; }

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