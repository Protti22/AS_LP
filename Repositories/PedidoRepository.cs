using ProjetoRaiz.Data;
using ProjetoRaiz.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoRaiz.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly ApplicationDbContext _context;

        public PedidoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Pedido> GetAll() => _context.Pedidos.ToList();

        public Pedido GetById(int id) => _context.Pedidos.Find(id);

        public void Add(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
        }

        public void Update(Pedido pedido)
        {
            _context.Pedidos.Update(pedido);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var pedido = _context.Pedidos.Find(id);
            if (pedido != null)
            {
                _context.Pedidos.Remove(pedido);
                _context.SaveChanges();
            }
        }
    }
}
