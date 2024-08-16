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
    var collection = liteDB.GetCollection<Material>(NomeDaTabela);
    return collection.FindOne(d => d.Id == id);
  }

  //----------------------------------------------------------------------------

  public virtual List<Material>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Material>(NomeDaTabela);
    return new List<Material>(tabela.FindAll());

  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
    var collection = liteDB.GetCollection<Material>(NomeDaTabela);
    collection.Delete(id);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Material m)
  {
    var collection = liteDB.GetCollection<Material>(NomeDaTabela);
    collection.Upsert(m);
  }

  //----------------------------------------------------------------------------
}