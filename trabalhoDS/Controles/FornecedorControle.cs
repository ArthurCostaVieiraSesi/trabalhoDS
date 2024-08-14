using Modelos;

namespace Controles;

public class FornecedorControle : BaseControle
{
  //----------------------------------------------------------------------------

  public FornecedorControle() : base()
  {
    NomeDaTabela = "Fornecedores";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int id)
  {
    return null;
  }

  //----------------------------------------------------------------------------

  public virtual List<Fornecedor>? LerTodos()
  {
    return null;
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Fornecedor f)
  {
  }

  //----------------------------------------------------------------------------
}