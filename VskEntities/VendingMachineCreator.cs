using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VskEntities
{
    public static class VendingMachineCreator
    {
        public static VendingMachine CreateMarkI()
        {
            VendingMachine res = new VendingMachine();

            res.OneOrder = _createOrder();
            CompoundUnit Kit = _createKit();
            CompoundUnit DrinkMix = _createMix("Напиток и добавка");
            CompoundUnit FoodMix = _createMix("Еда и добавка");

            Kit.Add(DrinkMix);
            Kit.Add(FoodMix);

            res.OneOrder.Add(Kit);

            return res;
        }

        private static Order _createOrder()
        {
            Order res = new Order();            
            res.Title = "Заказ";

            return res;
        }

        private static CompoundUnit _createKit()
        {
            CompoundUnit res = new Kit();
            res.Title = "Комплект";

            return res;
        }

        private static CompoundUnit _createMix(string name)
        {
            CompoundUnit res = new Mix();
            res.Title = name;

            return res;
        }
    }
}
