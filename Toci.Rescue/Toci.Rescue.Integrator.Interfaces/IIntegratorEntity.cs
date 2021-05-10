using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Rescue.Integrator.Interfaces
{
    public interface IIntegratorEntity
    {
        Dictionary<string, ICompany> Companies { get; set; }

        Dictionary<string, IUnemployed> Unemployed { get; set; }

        Dictionary<string, IEstate> Estates { get; set; }
    }
}
