using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VskEntities.Objects
{
    public interface IContainer : IEntity
    {        
        void AddChild(IEntity entity);        
    }
}
