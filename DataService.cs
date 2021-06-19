using CursoAspNetCore.Models;
using Newtonsoft.Json;
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
                JsonConvert.DeserializeObject<>
            }
        }

        class Livro
        {
            public string Codigo { get; set; }
            public string Nome { get; set; }
            public double Preco { get; set; }
        }
    }
}
