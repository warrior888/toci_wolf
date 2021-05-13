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
        Dictionary<string, IEstate> Estate { get; set; }

        // dalszy kod
        public void IIntegratorEntity(Dictionary<string, ICompany> Companies, Dictionary<string, IUnemployed> Unemployed, Dictionary<string, IEstate> Estate)
        {
            this.Companies = Companies;
            this.Unemployed = Unemployed;
            this.Estate = Estate;
        }

        public void addCompany(string Key,ICompany Company)
        {
            this.Companies.Add(Key, Company);
        }

        public void addUnemployed(string Key, IUnemployed Unemployed)
        {
            this.Unemployed.Add(Key, Unemployed);
        }

        public void addEstate(string Key, IEstate Estate)
        {
            this.Estate.Add(Key, Estate);
        }

    }
}
