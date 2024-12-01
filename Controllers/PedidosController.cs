using Microsoft.AspNetCore.Mvc;
using ProjetoRaiz.Models;
using ProjetoRaiz.Repositories;

namespace ProjetoRaiz.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidosController : ControllerBase
    {
        private readonly IPedidoRepository _repository;

        public PedidosController(IPedidoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_repository.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var pedido = _repository.GetById(id);
            return pedido != null ? Ok(pedido) : NotFound();
        }

        [HttpPost]
        public IActionResult Add(Pedido pedido)
        {
            _repository.Add(pedido);
            return CreatedAtAction(nameof(GetById), new { id = pedido.Id }, pedido);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Pedido pedido)
        {
            if (id != pedido.Id) return BadRequest();
            _repository.Update(pedido);
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
