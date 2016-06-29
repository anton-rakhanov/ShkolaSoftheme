using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsignarDataAccessLayer.AzureSQLRepository;
using AsignarDataAccessLayer.PatternRepositoryInterfaces;
using AsignarDataAccessLayer.AzureADBModel;

namespace AsignarDataAccessLayer.AzureSQLRepository
{
    public class ProjectRepository : IRepository<Project>
    {
        private AsignarDBEntities _db;

        
        public ProjectRepository()
        {
            this._db = new AsignarDBEntities();
        }


        public IEnumerable<Project> GetItemsList()
        {
            return _db.Projects.ToList<Project>();
        }


        public Project GetItem(int itemID)
        {
            return _db.Projects.Single(pj => pj.ProjectID.Equals(itemID));
        }


        public void Create(Project item)
        {
            _db.Projects.Add(item);
            Save();
        }


        public void Update(Project item)
        {
            Project proj = _db.Projects.Single(pj => pj.ProjectID.Equals(item.ProjectID));
            proj.Name = item.Name;
            proj.IsDeleted = item.IsDeleted;
            proj.Bugs = item.Bugs;
            proj.UsersToProjects = item.UsersToProjects;
            Save();
        }


        public void Delete(int itemID)
        {
            _db.Projects.Single(pj => pj.ProjectID.Equals(itemID)).IsDeleted = true;
            Save();
        }


        public void Save()
        {
            _db.SaveChanges();
        }


        private bool _disposed = false;


        public virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            this._disposed = true;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
