using CursoAspNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoAspNetCore
{
    public class Catalogo : ICatalogo
    {
        public List<Livro> GetLivros()
        {
            var livros = new List<Livro>();
            livros.Add(new Livro("001", "Quem mexeu na minha Query?", 12.99));
            livros.Add(new Livro("002", "Fique rico com C#", 29.99));
            livros.Add(new Livro("003", "Java para iniciantes", 18.99));
            return livros;
        }
    }
}
