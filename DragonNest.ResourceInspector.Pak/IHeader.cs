﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonNest.ResourceInspector.Pak
{
    public interface IHeader
    {
        String Path { get; }
        String Name { get; }
    }
}
