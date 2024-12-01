using ProjetoRaiz.Models;
using System.Collections.Generic;

namespace ProjetoRaiz.Repositories
{
    public interface IPedidoRepository
    {
        List<Pedido> GetAll();
        Pedido GetById(int id);
        void Add(Pedido pedido);
        void Update(Pedido pedido);
        void Delete(int id);
    }
}
