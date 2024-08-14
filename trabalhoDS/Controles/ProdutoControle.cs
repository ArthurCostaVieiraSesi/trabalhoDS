using Modelos;

namespace Controles;

public class ProdutoControle : BaseControle
{
  //----------------------------------------------------------------------------

  public ProdutoControle() : base()
  {
    NomeDaTabela = "Produtos";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int id)
  {
    return null;
  }

  //----------------------------------------------------------------------------

  public virtual List<Produto>? LerTodos()
  {
    return null;
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Produto p)
  {
  }

  //----------------------------------------------------------------------------
}