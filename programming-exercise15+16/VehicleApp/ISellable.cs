﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    public interface ISellable
    {
        string MakeSale();
        double CalculateInterest();
    }
}
