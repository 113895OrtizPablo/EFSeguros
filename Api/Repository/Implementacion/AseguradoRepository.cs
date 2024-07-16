using Api.ModelsDataBase;
using Api.Repository.Interfaz;

namespace Api.Repository.Implementacion
{
    public class AseguradoRepository : IAseguradoRepository
    {
        private readonly SegurosContext _context;

        public AseguradoRepository()
        {
            _context = new SegurosContext();
        }
        public int Add(Asegurado oAsegurado)
        {
            _context.Add(oAsegurado);
            return _context.SaveChanges();
        }

        public bool delete(int id)
        {
            var entity = _context.Asegurados.FirstOrDefault(x => x.Id == id);
            _context.Remove(entity);
            var response = _context.SaveChanges();
            if (response != 0)
            {
                return true;
            }
            return false;
        }

        public List<Asegurado> GetAll()
        {
            return _context.Asegurados.ToList();
        }

        public Asegurado Put(Asegurado oAsegurado)
        {
            var entity = _context.Asegurados.FirstOrDefault(x => x.Id == oAsegurado.Id);
            entity.Dni = oAsegurado.Dni;
            entity.Nombre = oAsegurado.Nombre;
            entity.Estado = oAsegurado.Estado;
            entity.FechaNacimiento = oAsegurado.FechaNacimiento;
            _context.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
