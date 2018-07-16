using ScratchWebsite.Areas.Admin.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchWebsite.Areas.Admin.Models
{
    interface IServiceDB
    {
        IEnumerable<ServiceViewModel> GetAll();
        ServiceViewModel Get(int id);
        ServiceViewModel Add(ServiceViewModel vm);
        ServiceViewModel Update(ServiceViewModel vm);
        void Delete(int id);
    }
}
