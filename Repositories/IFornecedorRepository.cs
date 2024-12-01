using ProjetoRaiz.Models;
using System.Collections.Generic;

namespace ProjetoRaiz.Repositories
{
    public interface IFornecedorRepository
    {
        List<Fornecedor> GetAll();
        Fornecedor GetById(int id);
        void Add(Fornecedor fornecedor);
        void Update(Fornecedor fornecedor);
        void Delete(int id);
    }
}
