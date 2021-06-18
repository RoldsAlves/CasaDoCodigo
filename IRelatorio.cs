using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CursoAspNetCore
{
    public interface IRelatorio
    {
        Task Imprimir(HttpContext context);
    }
}