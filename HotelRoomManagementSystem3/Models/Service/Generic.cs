using HotelRoomManagementSystem3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFinalProject.Models.Service
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly Csharp2Context _context;
        private readonly DbSet<T> table;
        public GenericService(Csharp2Context context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        public void Add(T OBJ)
        {
            
            table.Add(OBJ);
            _context.SaveChanges();
        }

        public void Delete(object OBJ)
        {
            var data = table.Find(OBJ);
            table.Remove(data);
            _context.SaveChanges();
            
        }

        public IEnumerable<T> GetAll()
        {
            var data = table.ToList();
            return data;

        }

        public T GetById(object OBJ)
        {
            var data = table.Find(OBJ);
            return data;
        }

        public void Update(T OBJ)
        {
              table.Update(OBJ);
            _context.SaveChanges();
        }
        
    }
}
