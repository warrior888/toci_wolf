using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Rescue.Integrator.Interfaces
{
    interface ICompany : IEntity
    {
        string field { get; set; }
        int max_emploees { get; set; }
        IEstate address {get;set; }
    }
}
