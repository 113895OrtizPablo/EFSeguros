using Api.Dtos;
using Api.ModelsDataBase;
using Api.Repository.Implementacion;
using Api.Repository.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoProductoController : ControllerBase
    {

        private readonly ITipoProductoRepository _tipoProductoRepository;
        public TipoProductoController()
        {
            _tipoProductoRepository = new TipoProductoRepository();
        }
        [HttpGet]
        public ActionResult Get()
        {
            List<TipoProducto> entities = _tipoProductoRepository.GetAll();
            if (entities == null) return NotFound();
            List<DtoTipoProducto> lstTipoProdDto = new List<DtoTipoProducto>();
            foreach (var item in entities)
            {
                DtoTipoProducto dtoTipo = new DtoTipoProducto
                {
                    Id = item.Id,
                    Tipo = item.Tipo,
                };
                lstTipoProdDto.Add(dtoTipo);
            }
            return Ok(lstTipoProdDto);
        }
    }
}
