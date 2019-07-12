using Chat.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.DAL.Repositories
{
    public class BaseRepository<T> : ICRUDRepository<T> where T : class
    {
        public BaseRepository()
        {

        }
        public void Create(T item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return 
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
