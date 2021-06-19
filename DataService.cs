using CursoAspNetCore.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CursoAspNetCore
{
    public partial class Startup
    {
        class DataService : IDataService
        {
            private readonly ApplicationContext context;

            public DataService(ApplicationContext context)
            {
                this.context = context;
            }

            public void InicializarDB()
            {
                context.Database.EnsureCreated();

                var json = File.ReadAllText("livros.json");
                var livros = JsonConvert.DeserializeObject<List<Livro>>(json);

                foreach(var livro in livros)
                {
                    context.Set<Produto>().Add(new Produto(livro.Codigo, livro.Nome, livro.Preco));
                }
                context.SaveChanges();
            }
        }

        class Livro
        {
            public string Codigo { get; set; }
            public string Nome { get; set; }
            public decimal Preco { get; set; }
        }
    }
}
