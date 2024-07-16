using Api.ModelsDataBase;

namespace Api.Repository.Interfaz
{
    public interface IPolizaRepository
    {
        List<Poliza> GetAll();
        int Add(Poliza oPoliza);
        Poliza Put(Poliza oPoliza);
        bool delete(int id);
    }
}
