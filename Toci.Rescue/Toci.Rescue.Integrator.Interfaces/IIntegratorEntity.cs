using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Rescue.Integrator.Interfaces
{
    interface IIntegratorEntity
    {
        Dictionary<string, ICompany> Companies { get; set; }
        Dictionary<string, IUnemployed> Unemployed { get; set; }
        Dictionary<string, IEstate> Estate { get; set; }

        // dalszy kod
        public void IIntegratorEntity(Dictionary<string, ICompany> Companies, Dictionary<string, IUnemployed> Unemployed, Dictionary<string, IEstate> Estate)
        {
            this.Companies = Companies;
            this.Unemployed = Unemployed;
            this.Estate = Estate;
        }
    }
}
