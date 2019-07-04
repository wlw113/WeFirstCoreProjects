using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeFirstCoreProject.Model;

namespace WeFirstCoreProject.Infrastructure
{
    public interface IRepository<T> where T : EntityBase
    {
        Task<T> GetByIdAsync(int id);
    }
}
