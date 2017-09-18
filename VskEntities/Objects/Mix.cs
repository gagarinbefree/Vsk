using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VskEntities.Objects
{
    public class Mix : Entity, IContainer
    {
        private List<IEntity> _children = new List<IEntity>();

        public Mix(string name) : base(name)
        {
        }

        public override void Add()
        {
            Cnt = 1;
        }

        public void  AddChild(IEntity entity)
        {            
            _children.Add(entity);
            entity.Parent = this;
        }

        public override void CalcPrice()
        {
            throw new NotImplementedException();
        }

        public override void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
