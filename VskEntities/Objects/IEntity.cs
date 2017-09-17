using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VskEntities.Objects
{
    public interface IEntity
    {
        IEntity Parent { get; set; }
        string Name { get; set; }

        int Price { get; set; }

        int Cnt { get; set; }
    }
}
