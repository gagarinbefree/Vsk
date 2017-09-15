using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VskEntities
{
    public class Kit : CompoundUnit
    {
        public override void Add(IUnit unit)
        {
            Children.Add(unit);
        }        
    }
}
