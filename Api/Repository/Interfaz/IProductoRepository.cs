using Api.ModelsDataBase;

namespace Api.Repository.Interfaz
{
    public interface IProductoRepository
    {
        List<Producto> GetAll();
        int Add(Producto oProducto);
        Producto Put(Producto oProducto);
        bool delete(int id);
    }
}
