using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeFirstCoreProject.Application.Interface;
using WeFirstCoreProject.Infrastructure.IRepository;
using WeFirstCoreProject.Model;
using WeFirstCoreProject.Model.Entitys;

namespace WeFirstCoreProject.Application.Services
{
   public class ProjectService<T>:IProjectService<T> where T:EntityBase
    {
        private readonly IProjectRepository<SystemUserInfo> _projectRepository;

        public ProjectService(IProjectRepository<SystemUserInfo> projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public virtual async Task<SystemUserInfo> GetByProjectId(int id) => await this._projectRepository.GetByIdAsync(id);
        
    }
}
