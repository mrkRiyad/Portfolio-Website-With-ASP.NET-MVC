using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ScratchWebsite.Areas.Admin.Models.ViewModel;
using ScratchWebsite.Dal;

namespace ScratchWebsite.Areas.Admin.Models
{
    public class ServiceDB : IServiceDB
    {
        // DB Context
        ScratchPortfolioEntities _db = new ScratchPortfolioEntities();

        public ServiceViewModel Add(ServiceViewModel vm)
        {
            Services service = new Services();
            service.ServiceName = vm.ServiceName;
            service.ServiceDescription = vm.ServiceDescription;
            service.Icon = vm.Icon;
            service.DisplayOrder = vm.DisplayOrder;
            service.IsActive = vm.IsActive;

            _db.Services.Add(service);
            _db.SaveChanges();
            vm.ServiceID = _db.Services.Max(s => s.ServiceID);

            return vm;
        }

        public void Delete(int id)
        {
            Services service = _db.Services.First(s => s.ServiceID == id);
            _db.Services.Remove(service);
            _db.SaveChanges();
        }

        public ServiceViewModel Get(int id)
        {
            Services service = _db.Services.First(s => s.ServiceID == id);
            ServiceViewModel vm = new ServiceViewModel();
            vm.ServiceID = service.ServiceID;
            vm.ServiceName = service.ServiceName;
            vm.ServiceDescription = service.ServiceDescription;
            vm.Icon = service.Icon;
            vm.DisplayOrder = service.DisplayOrder;
            vm.IsActive = service.IsActive;

            return vm;
        }

        public IEnumerable<ServiceViewModel> GetAll()
        {
            IEnumerable<ServiceViewModel> data = _db.Services.Select(s => new ServiceViewModel { ServiceID = s.ServiceID, ServiceName = s.ServiceName, ServiceDescription = s.ServiceDescription, Icon = s.Icon, DisplayOrder = s.DisplayOrder, IsActive = s.IsActive });
            return data;
        }

        public ServiceViewModel Update(ServiceViewModel vm)
        {
            Services service = _db.Services.Find(vm.ServiceID);
            service.ServiceName = vm.ServiceName;
            service.ServiceDescription = vm.ServiceDescription;
            service.Icon = vm.Icon;
            service.DisplayOrder = vm.DisplayOrder;
            service.IsActive = vm.IsActive;

            _db.SaveChanges();

            return vm;
        }
    }
}