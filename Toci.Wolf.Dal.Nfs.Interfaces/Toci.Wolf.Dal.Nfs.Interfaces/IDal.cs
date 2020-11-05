using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Wolf.Dal.Nfs.Interfaces
{
    public interface IDal<TModel>
    {
        bool Insert(TModel model);
        int Update(TModel model);
        int Delete(TModel model);
    }
}
