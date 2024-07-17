using DataLayer.ModelsCodeFirst;
using DataLayer.Repository.Implementacion;
using DataLayer.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Negocio.DTOs;
using static System.Runtime.InteropServices.JavaScript.JSType;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolizaController : ControllerBase
    {
        private readonly IPolizaRepository polizaRepository;

        public PolizaController(IPolizaRepository polizaRepository)
        {
            this.polizaRepository = polizaRepository;
        }
        // GET: api/<PolizaController>
        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            List<Poliza> lPolizas =await polizaRepository.GetAll();

            if (lPolizas == null) return NotFound();

            List<DtoPolizaGet> lstPolizasDto = new List<DtoPolizaGet>();
           
            foreach (var poliza in lPolizas)
            {
                DtoPolizaGet dtoPoliza = new DtoPolizaGet
                {
                    Id = poliza.Id,
                    Producto = poliza.SuProducto.Name,
                    Estado = poliza.Estado,
                    lAsegurados = new List<DtoAseguradoGetPoliza>()
                };
                foreach (Asegurado a in poliza.lAsegurados)
                {
                    if (a.Estado.ToString().Equals("ACTIVO"))
                    {
                        DtoAseguradoGetPoliza asegurado = new DtoAseguradoGetPoliza
                        {
                            Id = a.Id,
                            Nombre = a.Nombre,
                            Estado = a.Estado
                        };
                        dtoPoliza.lAsegurados.Add(asegurado);
                    }             
                }
                lstPolizasDto.Add(dtoPoliza);
            }
            return Ok(lstPolizasDto);
           
        }

        // GET api/<PolizaController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Poliza poliza = await polizaRepository.GetById(id);

            if (poliza == null) return NotFound();

            DtoPolizaGet dtoPoliza = new DtoPolizaGet
            {
                Id = poliza.Id,
                Producto = poliza.SuProducto.Name,
                Estado = poliza.Estado,
                lAsegurados = new List<DtoAseguradoGetPoliza>()
            };
            foreach (Asegurado a in poliza.lAsegurados)
            {
                if (a.Estado.ToString().Equals("ACTIVO"))
                {
                    DtoAseguradoGetPoliza asegurado = new DtoAseguradoGetPoliza
                    {
                        Id = a.Id,
                        Nombre = a.Nombre,
                        Estado = a.Estado
                    };
                    dtoPoliza.lAsegurados.Add(asegurado);
                }
            }
            return Ok(dtoPoliza);
        }
        /*
        // POST api/<PolizaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PolizaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PolizaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
