using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Rescue.Integrator.Interfaces
{
    public interface IUnemployed : IEntity
    {
        string surname { get; set; }
        string[] skills { get; set; }
    }
}
