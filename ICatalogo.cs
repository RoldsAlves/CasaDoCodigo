using CursoAspNetCore.Models;
using System.Collections.Generic;

namespace CursoAspNetCore
{
    public interface ICatalogo
    {
        List<Livro> GetLivros();
    }
}