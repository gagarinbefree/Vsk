using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VskEntities;

namespace VskEntities
{
    public abstract class CompoundUnit : Unit, ICompoundUnit
    {
        public List<IUnit> Children { get; set; } = new List<IUnit>();

        public abstract void Add(IUnit unit);

        public override int CalcPrice()
        {
            return Children.Sum(f => f.Price);
        }
    }
}
