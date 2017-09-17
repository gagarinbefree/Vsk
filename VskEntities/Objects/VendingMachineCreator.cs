using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VskEntities.Objects
{
    public static class VendingMachineCreator
    {
        public static IEntity CreateMarkI()
        {
            IContainer res = new Mix("Автомат");
            IContainer kit = new Mix("Комплект");            
            IContainer foodWithAdditives = new Mix("Еда c добавкми");
            IContainer drinkWithAdditives = new Mix("Напиток c добавкми");
            IContainer drinks = new Mix("Напитки");
            IContainer foods = new Mix("Еда");
            IContainer espresso = new Mix("Эспрессо");
            IContainer latte = new Mix("Латте");
            IContainer cappuccino = new Mix("Капучино");
            IContainer blackTea = new Mix("Черный чай");
            IContainer greenTea = new Mix("Зеленый чай");
            IContainer bread = new Mix("Хлеб");
            IContainer bride = new Mix("Булочка");
            IEntity water = new Product("Вода");
            IEntity milk = new Product("Молоко");
            IEntity milkyFoam = new Product("Молочная пенка");
            IEntity syrup = new Product("Сироп");
            IEntity sugar = new Product("Сахар");
            IEntity ham = new Product("Ветчина");
            IEntity cheese = new Product("Сыр");
            IEntity jam = new Product("Джем");

            res.AddChild(kit);
            kit.AddChild(drinkWithAdditives);
            kit.AddChild(foodWithAdditives);
            drinkWithAdditives.AddChild(drinks);
            foodWithAdditives.AddChild(foods);
            drinks.AddChild(water);
            drinks.AddChild(espresso);
            drinks.AddChild(latte);
            drinks.AddChild(cappuccino);
            latte.AddChild(espresso);
            latte.AddChild(milk);
            cappuccino.AddChild(espresso);
            cappuccino.AddChild(milk);
            cappuccino.AddChild(milkyFoam);
            drinkWithAdditives.AddChild(milk);
            drinkWithAdditives.AddChild(syrup);
            drinkWithAdditives.AddChild(sugar);
            foodWithAdditives.AddChild(ham);
            foodWithAdditives.AddChild(cheese);
            foodWithAdditives.AddChild(jam);

            return res;
        }
    }
}
