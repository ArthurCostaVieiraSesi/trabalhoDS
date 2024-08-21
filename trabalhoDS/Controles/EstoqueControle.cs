using Modelos;

namespace Controles;

public class EstoqueControle : BaseControle
{
  //----------------------------------------------------------------------------

  public EstoqueControle() : base()
  {
    NomeDaTabela = "Estoques";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int id)
  {
    var collection = liteDB.GetCollection<Estoque>(NomeDaTabela);
    return collection.FindOne(d => d.Id == id);
  }

  //----------------------------------------------------------------------------

  public virtual List<Estoque>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Estoque>(NomeDaTabela);
    return new List<Estoque>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
    var collection = liteDB.GetCollection<Estoque>(NomeDaTabela);
    collection.Delete(id);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Estoque e)
  {
    var collection = liteDB.GetCollection<Estoque>(NomeDaTabela);
    collection.Upsert(e);
  }

  //----------------------------------------------------------------------------
}