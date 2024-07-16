

using Api.ModelsDataBase;

namespace Api.Repository.Interfaz
{
    public interface ITipoProductoRepository
    {

        List<TipoProducto> GetAll();
        int Add(TipoProducto tipo);
        TipoProducto Put(TipoProducto tipo);
        bool delete(int id);
    }
}
