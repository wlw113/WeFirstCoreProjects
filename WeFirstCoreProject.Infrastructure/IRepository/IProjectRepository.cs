using System;
using System.Collections.Generic;
using System.Text;
using WeFirstCoreProject.Model;

namespace WeFirstCoreProject.Infrastructure.IRepository
{
   public interface IProjectRepository<T>:IRepository<T> where T:EntityBase
    {
    }
}
