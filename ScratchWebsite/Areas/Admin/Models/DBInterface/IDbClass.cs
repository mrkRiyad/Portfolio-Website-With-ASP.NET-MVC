using ScratchWebsite.Areas.Admin.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchWebsite.Areas.Admin.Models
{
    interface IDbClass<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        T Add(T vm);
        T Update(T vm);
        void Delete(int id);
    }
}
