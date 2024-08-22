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

  public virtual Registro? Ler(int idMaterial)
  {
    var collection = liteDB.GetCollection<Material>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idMaterial);
  }

  //----------------------------------------------------------------------------

  public virtual List<Material>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Material>(NomeDaTabela);
    return new List<Material>(tabela.FindAll());

  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idMaterial)
  {
    var collection = liteDB.GetCollection<Material>(NomeDaTabela);
    collection.Delete(idMaterial);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Material m)
  {
    var collection = liteDB.GetCollection<Material>(NomeDaTabela);
    collection.Upsert(m);
  }

  //----------------------------------------------------------------------------
}