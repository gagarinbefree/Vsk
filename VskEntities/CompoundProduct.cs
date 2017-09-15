using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VskEntities
{
    public class CompoundProduct : IProduct
    {        
        List<IProduct> Children { get; set; } = new List<IProduct>();

        public int Price { get; set; }

        public int CalcPrice()
        {
            int price = 0;
            foreach(IProduct child in Children)
            {
                price += child.Price;
            }

            return price;
        }

        public void Add(IProduct entity)
        {
            Children.Add(entity);
        }
        public void Remove(IProduct entity)
        {
            Children.Remove(entity);
        }

    }
}
