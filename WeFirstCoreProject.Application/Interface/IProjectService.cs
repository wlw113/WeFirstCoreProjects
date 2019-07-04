using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeFirstCoreProject.Model;
using WeFirstCoreProject.Model.Entitys;

namespace WeFirstCoreProject.Application.Interface
{
   public interface IProjectService<T> where T:EntityBase
    {
        Task<SystemUserInfo> GetByProjectId(int id);
    }
}
