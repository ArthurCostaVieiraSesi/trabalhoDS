using Modelos;

namespace Controles;

public class VendaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public VendaControle() : base()
  {
    NomeDaTabela = "Vendas";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int id)
  {
    var collection = liteDB.GetCollection<Venda>(NomeDaTabela);
    return collection.FindOne(d => d.Id == id);
  }

  //----------------------------------------------------------------------------

  public virtual List<Venda>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Venda>(NomeDaTabela);
    return new List<Venda>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
    var collection = liteDB.GetCollection<Venda>(NomeDaTabela);
    collection.Delete(id);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Venda v)
  {
    var collection = liteDB.GetCollection<Venda>(NomeDaTabela);
    collection.Upsert(v);
  }

  //----------------------------------------------------------------------------
}