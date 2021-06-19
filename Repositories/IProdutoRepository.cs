using System.Collections.Generic;

namespace CursoAspNetCore.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> livros);
    }
}