using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VskEntities
{
    public class CompoundUnit : Unit, ICompoundUnit
    {
        private List<IUnit> _children { get; set; } = new List<IUnit>();

        public void Add(IUnit unit)
        {
            _children.Add(unit);
            unit.Parent = this;
        }

        public override int CalcPrice()
        {
            return _children.Sum(f => f.Price);
        }

        public override IUnit FindChildByTitle(string title)
        {
            if (this.Title == title)
                return this;

            foreach (IUnit unit in _children)
            {
                IUnit child = unit.FindChildByTitle(title);
                if (child != null)
                    return child;
            }

            return null;
        }
    }
}
