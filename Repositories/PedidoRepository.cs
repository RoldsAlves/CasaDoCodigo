using CursoAspNetCore.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoAspNetCore.Repositories
{
    public interface IPedidoRepository
    {

    }
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        private readonly IHttpContextAccessor contextAcessor;
        public PedidoRepository(ApplicationContext context, IHttpContextAccessor contextAccessor) : base(context)
        {
            this.contextAcessor = contextAccessor;
        }

        private int? GetPedidoId()
        {
            return contextAcessor.HttpContext.Session.GetInt32("pedidoId");
        }

        private void SetPedidoId(int pedidoId)
        {
            contextAcessor.HttpContext.Session.SetInt32("pedidoId", pedidoId);
        }
    }
}
