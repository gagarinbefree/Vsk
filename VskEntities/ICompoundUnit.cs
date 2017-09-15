using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VskEntities
{
    public interface ICompoundUnit : IUnit
    {
        void Add(IUnit unit);
    }
}
