using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VskEntities.Objects
{
    public abstract class Entity : IEntity
    {
        public IEntity Parent { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Cnt { get; set; }
        public abstract void CalcPrice();        

        public virtual void Add()
        {
            Cnt = 1;
        }

        public virtual void Remove()
        {
            Cnt = 0;
        }

        public Entity(string name)
        {
            Name = name;
        }
    }
}
