using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VskEntities
{
    public interface IUnit
    {
        IUnit Parent { get; set; }

        string Title { get; set; }

        int Price { get; set; }

        int CalcPrice();

        IUnit FindChildByTitle(string title);
    }
}
