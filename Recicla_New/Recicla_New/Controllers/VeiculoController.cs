
using Domain.Entities;
using Infrastructure.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Application.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        readonly IVeiculoRepository _veiculoRepository;

        public VeiculoController(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        [HttpGet("{id}")]
        public ActionResult<Veiculo> Get(int id)
        {
            return Ok(_veiculoRepository.GetVeiculo(id));
        }


        // GET: api/<AlunosController>
        [HttpGet]
        public ActionResult<List<Veiculo>> GetAll()
        {
            return Ok(_veiculoRepository.GetVeiculos());
        }


    }
}
