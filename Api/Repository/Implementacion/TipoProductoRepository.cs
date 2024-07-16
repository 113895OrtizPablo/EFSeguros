using Api.Context;
using Api.ModelsDataBase;
using Api.Repository.Interfaz;
using Clases.Models;

namespace Api.Repository.Implementacion
{
    public class TipoProductoRepository : ITipoProductoRepository
    {
        private readonly SegurosContext _context;

        public TipoProductoRepository()
        {
            _context = new SegurosContext();
        }

        public int Add(TipoProducto tipo)
        {
            _context.Add(tipo);
            return _context.SaveChanges();
        }

        public bool delete(int id)
        {
            var entity = _context.TipoProductos.FirstOrDefault(x => x.Id == id);
            _context.Remove(entity);
            var response = _context.SaveChanges();
            if (response != 0)
            {
                return true;
            }
            return false;
        }

        public List<TipoProducto> GetAll()
        {
           return _context.TipoProductos.ToList();
        }

        public TipoProducto Put(TipoProducto tipo)
        {
            var entity = _context.TipoProductos.FirstOrDefault(x => x.Id == tipo.Id);
            entity.Tipo = tipo.Tipo;
            _context.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
