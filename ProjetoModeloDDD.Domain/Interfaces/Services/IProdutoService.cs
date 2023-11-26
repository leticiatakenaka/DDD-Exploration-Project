using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarProdutoPorNome(string nomeProduto);
    }
}
