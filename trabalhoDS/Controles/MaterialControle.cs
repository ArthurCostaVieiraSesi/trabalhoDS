using Modelos;

namespace Controles;

public class MaterialControle : BaseControle
{
  //----------------------------------------------------------------------------

  public MaterialControle() : base()
  {
    NomeDaTabela = "Materiais";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int id)
  {
    return null;
  }

  //----------------------------------------------------------------------------

  public virtual List<Material>? LerTodos()
  {
    return null;
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Material m)
  {
  }

  //----------------------------------------------------------------------------
}