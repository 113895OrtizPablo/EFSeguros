using DataLayer.ModelsCodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository.Interface
{
    //Inyectamos el dbContext


    public interface IPolizaRepository
    {
        Task<List<Poliza>>   GetAll();

        Task<Poliza> GetById(int id);

       // Task<int> Add(Poliza oPoliza);

       // Task<Poliza>  Put(Poliza oPoliza);

       // bool delete(int id);
    }
}
