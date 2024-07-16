using Api.ModelsDataBase;
using Api.Repository.Interfaz;

namespace Api.Repository.Implementacion
{
    public class PolizaRepository : IPolizaRepository
    {
        private readonly SegurosContext _context;

        public PolizaRepository()
        {
            _context = new SegurosContext();
        }
        public int Add(Poliza oPoliza)
        {
            _context.Add(oPoliza);
            return _context.SaveChanges();
        }

        public bool delete(int id)
        {
            var entity = _context.Polizas.FirstOrDefault(x => x.Id == id);
            _context.Remove(entity);
            var response = _context.SaveChanges();
            if (response != 0)
            {
                return true;
            }
            return false;
        }

        public List<Poliza> GetAll()
        {
            return _context.Polizas.ToList();
        }

        public Poliza Put(Poliza oPoliza)
        {
            var entity = _context.Polizas.FirstOrDefault(x => x.Id == oPoliza.Id);
            entity.Estado = oPoliza.Estado;
            _context.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
