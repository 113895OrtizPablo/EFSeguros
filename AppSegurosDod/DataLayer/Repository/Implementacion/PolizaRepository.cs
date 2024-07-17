using DataLayer.Context;
using DataLayer.ModelsCodeFirst;
using DataLayer.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository.Implementacion
{
    public class PolizaRepository : IPolizaRepository
    {
        private readonly ContextDb _context;

        public PolizaRepository(ContextDb context)
        {
            _context = context;
        }
        public async Task<List<Poliza>> GetAll()
        {
            return  await _context.Polizas.Include(p => p.SuProducto).Include(p => p.lAsegurados).ToListAsync();
        }

        public async Task<Poliza> GetById(int id)
        {
            return await _context.Polizas.Include(p => p.SuProducto).Include(p => p.lAsegurados).SingleOrDefaultAsync(p=>p.Id== id && p.Estado == "ACTIVO");
        }
    }
}
