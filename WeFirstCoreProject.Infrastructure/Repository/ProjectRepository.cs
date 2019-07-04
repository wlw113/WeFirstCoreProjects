using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeFirstCoreProject.Infrastructure;
using WeFirstCoreProject.Infrastructure.IRepository;
using WeFirstCoreProject.Model;
using WeFirstCoreProject.Model.Map;

namespace WeFirstCoreProject.Application.Interface
{
    public class ProjectRepository<T> : IProjectRepository<T> where T : EntityBase
    {
        private readonly FirstProjectContext _context;
        public ProjectRepository(FirstProjectContext context)
        {
            _context = context;
        }
        public virtual async Task<T> GetByIdAsync(int id) => await _context.Set<T>().FindAsync(id);

        public virtual async Task<T> TableAsQueryable()
    }
}
