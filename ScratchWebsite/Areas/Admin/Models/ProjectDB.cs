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

        public ProjectViewModel Get(int id)
        {
            var data = from pp in _db.Projects
                       join pj in
                         (from pc in
                              (from p in _db.Projects
                               join cp in _db.CatProjectRef on p.ProjectID equals cp.fkProjectID
                               join c in _db.Categories on cp.fkCategoryID equals c.CategoryID
                               select new
                               {
                                   ProjectID = p.ProjectID,
                                   ProjectName = p.ProjecName,
                                   ProjectTechnology = p.ProjectTechnology,
                                   CategoryID = c.CategoryID,
                                   ProjectCategory = c.CatName,
                                   DisplayOrder = p.DisplayOrder,
                                   IsActive = p.IsActive
                               }
                              )
                          group pc by new { pc.ProjectID, pc.ProjectName, pc.ProjectTechnology, pc.DisplayOrder, pc.IsActive } into g
                          select new
                          {
                              ProjectID = g.Key.ProjectID,
                              ProjectName = g.Key.ProjectName,
                              ProjectTechnology = g.Key.ProjectTechnology,
                              DisplayOrder = g.Key.DisplayOrder,
                              IsActive = g.Key.IsActive,
                              Category = g.Select(c => new
                              {
                                  CategoryID = c.CategoryID,
                                  CategoryName = c.ProjectCategory
                              }).ToList()
                                }
                            ) on
                            pp.ProjectID equals pj.ProjectID
                            join md in

                            (from mg in 
                                 (from p in _db.Projects
                                    join pg in _db.ProductGalleryRef on p.ProjectID equals pg.fkProjectID
                                    join m in _db.MediaGalleries on pg.fkMGID equals m.MGID
                                    select new
                                    {
                                        ProjectID = p.ProjectID,
                                        MGID = m.MGID,
                                        Caption = m.Caption,
                                        FilePath = m.FilePathOrLink,
                                        FileName = m.FileName,
                                        FileFormat = m.FileFormat,
                                        ThumbnailUrl = m.ThumbnailUrl,
                                        PGRID = pg.PGRID,
                                        IsDefault = pg.IsDefault,
                                        ImageSize = pg.ImageSize
                                    }
                                )
                            group mg by mg.ProjectID into i
                                select new
                                {
                                    ProjectID = i.Key,
                                    Media = i.Select(x => new
                                    {
                                        MGID = x.MGID,
                                        PGRID = x.PGRID,
                                        FilePath = x.FilePath,
                                        Caption = x.Caption,
                                        FileName = x.FileName,
                                        FileFormat = x.FileFormat,
                                        ThumbnailUrl = x.ThumbnailUrl,
                                        IsDefault = x.IsDefault,
                                        ImageSize = x.ImageSize
                                    })
                                }
                            ) on

                       pj.ProjectID equals md.ProjectID
                       select new
                       {
                           pj.ProjectID,
                           pj.ProjectName,
                           pp.ProjectDescription,
                           pj.ProjectTechnology,
                           pj.Category,
                           md.Media,
                           pj.DisplayOrder,
                           pj.IsActive
                       };
            ProjectViewModel project = (ProjectViewModel)data.Select(p => new ProjectViewModel
            {
                ProjectID = p.ProjectID,
                ProjecName = p.ProjectName,
                ProjectDescription = p.ProjectDescription,
                ProjectTechnology = p.ProjectTechnology,
                Category = p.Category.Select(c => new CategoryViewModel { CategoryID = c.CategoryID, CategoryName = c.CategoryName }),
                Media = p.Media.Select(m => new MediaGalleryViewModel { MGID = m.MGID, Caption = m.Caption, FilePathOrLink = m.FilePath, FileFormat = m.FileFormat, FileName = m.FileName, ThumbnailUrl = m.ThumbnailUrl, PGRID = m.PGRID, ImageSize = m.ImageSize, IsDefault = m.IsDefault }),
                DisplayOrder = p.DisplayOrder,
                IsActive = p.IsActive
            }).Where(p => p.ProjectID == id);

            return project;
        }

        public void Delete(int id)
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
                                       CategoryID = c.CategoryID,
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
                           CategoryName = g.Select(c => new
                           {
                               CategoryID = c.CategoryID,
                               CategoryName = c.ProjectCategory
                           }).ToList() };
                            

            IEnumerable<ProjectViewModel> project = data.Select(p => new ProjectViewModel {
                ProjectID = p.ProjectID,
                ProjecName = p.ProjectName,
                ProjectTechnology = p.ProjectTechnology,
                Category = p.CategoryName.Select(c => new CategoryViewModel { CategoryID = c.CategoryID, CategoryName = c.CategoryName }),
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