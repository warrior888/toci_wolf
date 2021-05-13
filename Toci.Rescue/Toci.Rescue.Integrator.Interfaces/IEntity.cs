using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Rescue.Integrator.Interfaces
{
    public interface IEntity // encja firmy, bezrobotnego i nieruchomosci - bazowy
    {
        int id { get; set; }
        string name { get; set; }
    }
}
