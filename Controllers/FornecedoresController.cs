using Microsoft.AspNetCore.Mvc;
using ProjetoRaiz.Models;
using ProjetoRaiz.Repositories;

namespace ProjetoRaiz.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FornecedoresController : ControllerBase
    {
        private readonly IFornecedorRepository _repository;

        public FornecedoresController(IFornecedorRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_repository.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var fornecedor = _repository.GetById(id);
            return fornecedor != null ? Ok(fornecedor) : NotFound();
        }

        [HttpPost]
        public IActionResult Add(Fornecedor fornecedor)
        {
            _repository.Add(fornecedor);
            return CreatedAtAction(nameof(GetById), new { id = fornecedor.Id }, fornecedor);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Fornecedor fornecedor)
        {
            if (id != fornecedor.Id) return BadRequest();
            _repository.Update(fornecedor);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return NoContent();
        }
    }
}
