using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarProdutoPorNome(string nomeProduto)
        {
            return Db.Produtos.Where(p => p.NomeProduto == nomeProduto);
        }
    }
}
