using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Rescue.Integrator.Interfaces
{
    interface IEstate : IEntity
    {
        string street { get; set; }
        int building_number { get; set; }
        int office_number { get; set; }
        string zip_Code { get; set; }
        string city_name { get; set; }
        string country { get; set; }

        public void IEstate(string street, int building_number, int office_number, string zip_Code, string city_name, string country)
        {
            this.street = street;
            this.building_number = building_number;
            this.office_number = office_number;
            this.zip_Code = zip_Code;
            this.city_name = city_name;
            this.country = country;
        }
    }
}
