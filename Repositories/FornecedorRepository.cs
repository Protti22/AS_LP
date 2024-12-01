using ProjetoRaiz.Data;
using ProjetoRaiz.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoRaiz.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly ApplicationDbContext _context;

        public FornecedorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Fornecedor> GetAll() => _context.Fornecedores.ToList();

        public Fornecedor GetById(int id) => _context.Fornecedores.Find(id);

        public void Add(Fornecedor fornecedor)
        {
            _context.Fornecedores.Add(fornecedor);
            _context.SaveChanges();
        }

        public void Update(Fornecedor fornecedor)
        {
            _context.Fornecedores.Update(fornecedor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var fornecedor = _context.Fornecedores.Find(id);
            if (fornecedor != null)
            {
                _context.Fornecedores.Remove(fornecedor);
                _context.SaveChanges();
            }
        }
    }
}
