﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Rescue.Integrator.Interfaces
{
    interface IIntegrator
    {
        IIntegratorEntity Collocate(List<IIntegratorEntity> set);

        //dalszy kod
    }
}
