using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool_Warehouse_Management_System.DataAccess.Entities;

namespace Tool_Warehouse_Management_System.DataAccess
{
    public interface IRepository<T> where T : EntityBase
    {
        Task<List<T>> GetAll();

        Task<T> GetById(int id);

        Task Insert(T entity);

        Task Update(T entity);

        Task Delete(int id);
    }
}

