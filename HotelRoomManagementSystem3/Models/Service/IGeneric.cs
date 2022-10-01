using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFinalProject.Models.Service
{
    public interface IGenericService<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Add(T OBJ);
        T GetById(object OBJ);
        void Update(T OBJ);
        void Delete(object OBJ);
        
    }
}
