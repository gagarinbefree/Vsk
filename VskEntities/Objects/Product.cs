using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VskEntities.Objects
{
    class Product : Entity
    {
        public Product(string name) : base(name)
        {

        }

        public override void Add()
        {
            throw new NotImplementedException();
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
