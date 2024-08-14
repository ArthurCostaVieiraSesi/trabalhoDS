using Modelos;

namespace Controles;

public class ClienteControle : BaseControle
{
  //----------------------------------------------------------------------------

  public ClienteControle() : base()
  {
    NomeDaTabela = "Clientes";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int id)
  {
    return null;
  }

  //----------------------------------------------------------------------------

  public virtual List<Cliente>? LerTodos()
  {
    return null;
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Cliente c)
  {
  }

  //----------------------------------------------------------------------------
}