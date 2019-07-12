using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.DAL.Interfaces
{
    public interface ICRUDRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Create(T item);
        void Delete(int id);
        T GetById(int id);
    }
}
