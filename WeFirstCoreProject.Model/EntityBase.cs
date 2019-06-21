using System;
using System.Collections.Generic;
using System.Text;

namespace WeFirstCoreProject.Model
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
        public string LastAction { get; set; }
    }
}
