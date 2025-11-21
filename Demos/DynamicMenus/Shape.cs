using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicMenus
{
    public abstract class Shape
    {
        // What does this method actually do?
        // How big is a “shape”?  No idea.
        // But we need it here so we can override
        // (because *all* shapes do have an area…)
        public abstract double CalculateArea();
    }
}
