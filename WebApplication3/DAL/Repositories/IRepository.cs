using System.Collections.Generic;
using CricketersWebApi.DAL.Entities;

namespace CricketersWebApi.DAL.Repositories
{
    interface IRepository<T> where T: EntityBase
    {
        List<T> Get();
        T Get(int id);
        T Update(T obj);

        T Insert(T obj);
        int Delete(T obj);
    }
}
