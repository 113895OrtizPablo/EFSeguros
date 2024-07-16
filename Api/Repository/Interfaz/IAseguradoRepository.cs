using Api.ModelsDataBase;

namespace Api.Repository.Interfaz
{
    public interface IAseguradoRepository
    {
        List<Asegurado> GetAll();
        int Add(Asegurado oAsegurado);
        Asegurado Put(Asegurado oAsegurado);
        bool delete(int id);
    }
}
