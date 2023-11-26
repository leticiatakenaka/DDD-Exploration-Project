
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Application.Interfaces
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarProdutoPorNome(string nomeProduto);
    }
}
