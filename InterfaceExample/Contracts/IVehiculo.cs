﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Contracts
{
    public interface IVehiculo
    {
        void Drive();
        bool Refuel(int amount);
    }
}
