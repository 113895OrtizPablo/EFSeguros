using Api.ModelsDataBase;
using Api.Repository.Interfaz;

namespace Api.Repository.Implementacion
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly SegurosContext _context;

        public ProductoRepository()
        {
            _context = new SegurosContext();
        }
        public int Add(Producto oProducto)
        {
            _context.Add(oProducto);
            return _context.SaveChanges();
        }

        public bool delete(int id)
        {
            var entity = _context.Productos.FirstOrDefault(x => x.Id == id);
            _context.Remove(entity);
            var response = _context.SaveChanges();
            if (response != 0)
            {
                return true;
            }
            return false;
        }

        public List<Producto> GetAll()
        {
            return _context.Productos.ToList();
        }

        public Producto Put(Producto oProducto)
        {
            var entity = _context.Productos.FirstOrDefault(x => x.Id == oProducto.Id);
            entity.Name = oProducto.Name;
            _context.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
