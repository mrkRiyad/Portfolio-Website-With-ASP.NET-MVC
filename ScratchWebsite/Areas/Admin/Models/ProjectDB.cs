using ScratchWebsite.Areas.Admin.Models.ViewModel;
using ScratchWebsite.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScratchWebsite.Areas.Admin.Models
{
    public class ProjectDB : IDbClass<ProjectViewModel>
    {
        // DB Context
        ScratchPortfolioEntities _db = new ScratchPortfolioEntities();

        public ProjectViewModel Add(ProjectViewModel vm)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ProjectViewModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProjectViewModel> GetAll()
        {
            var data = from pc in (from p in _db.Projects
                                   join cp in _db.CatProjectRef on
                                   p.ProjectID equals cp.fkProjectID
                                   join c in _db.Categories on
                                   cp.fkCategoryID equals c.CategoryID
                                   select new {
                                       ProjectID = p.ProjectID,
                                       ProjectName = p.ProjecName,
                                       ProjectTechnology = p.ProjectTechnology,
                                       ProjectCategory = c.CatName,
                                       DisplayOrder = p.DisplayOrder,
                                       IsActive = p.IsActive
                                   })
                       group pc by new {
                           pc.ProjectID,
                           pc.ProjectName,
                           pc.ProjectTechnology,
                           pc.DisplayOrder,
                           pc.IsActive } into g
                       select new {
                           ProjectID = g.Key.ProjectID,
                           ProjectName = g.Key.ProjectName,
                           ProjectTechnology = g.Key.ProjectTechnology,
                           DisplayOrder = g.Key.DisplayOrder,
                           IsActive = g.Key.IsActive,
                           CategoryName = g.Select(c => c.ProjectCategory).ToList() };

            IEnumerable<ProjectViewModel> project = data.Select(p => new ProjectViewModel {
                ProjectID = p.ProjectID,
                ProjecName = p.ProjectName,
                ProjectTechnology = p.ProjectTechnology,
                CatName = p.CategoryName,
                DisplayOrder = p.DisplayOrder,
                IsActive = p.IsActive
            });

            return project;
        }

        public ProjectViewModel Update(ProjectViewModel vm)
        {
            throw new NotImplementedException();
        }
    }
}