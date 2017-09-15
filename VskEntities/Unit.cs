using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VskEntities
{
    public abstract class Unit : IUnit
    {
        public IUnit Parent { get; set; }

        public string Title { get; set; }

        public int Price { get; set; }

        public abstract int CalcPrice();

        public virtual IUnit FindChildByTitle(string title)
        {
            return (this.Title == title) ? this : null;
        }
    }
}
