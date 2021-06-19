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
        Pedido GetPedido();
        void AddItem(string codigo);
    }
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        private readonly IHttpContextAccessor contextAcessor;
        public PedidoRepository(ApplicationContext context, IHttpContextAccessor contextAccessor) : base(context)
        {
            this.contextAcessor = contextAccessor;
        }

        public Pedido GetPedido()
        {
            var pedidoId = GetPedidoId();
            var pedido = dbSet.Where(p => p.Id == pedidoId).SingleOrDefault();

            if(pedido == null)
            {
                pedido = new Pedido();
                dbSet.Add(pedido);
                context.SaveChanges();
                SetPedidoId(pedido.Id);
            }

            return pedido;
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
