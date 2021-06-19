using CursoAspNetCore.Models;

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
            }
        }
    }
}
