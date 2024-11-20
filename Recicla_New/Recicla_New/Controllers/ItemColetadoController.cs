
using ApplicationService.Interface;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ItemColetadoController : ControllerBase
    {
        readonly IItemColetadoApplication _itemColetadoRepository;

        public ItemColetadoController(IItemColetadoApplication itemColetadoRepository)
        {
            _itemColetadoRepository = itemColetadoRepository;
        }

        [HttpGet]
        public IActionResult GetItensColetados()
        {
            try
            {
                var coleta = _itemColetadoRepository.GetItensColetados();
                return Ok(coleta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetItem(int id)
        {
            try
            {
                var item = _itemColetadoRepository.GetItemColetado(id);
                return Ok(item);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertItem(ItemColetado item)
        {
            try
            {
                _itemColetadoRepository.InsertItem(item);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateItem(ItemColetado item)
        {
            try
            {
                _itemColetadoRepository.UpdateItem(item);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteItem(int id)
        {
            try
            {
                _itemColetadoRepository.DeleteItem(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
