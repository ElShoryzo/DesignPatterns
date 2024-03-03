using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    internal class PizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza;
        public PizzaBuilder()
        {
            _pizza = new Pizza();
        }
        public void AddCheese()
        {
            _pizza.Ingredients.Add("Cheese");
        }
        public void AddPepperoni()
        {
            _pizza.Ingredients.Add("Pepperoni");
        }
        public void AddHam()
        {
            _pizza.Ingredients.Add("Ham");
        }
        public void AddMushrooms()
        {
            _pizza.Ingredients.Add("Mushrooms");
        }
        public void AddPineapple()
        {
            _pizza.Ingredients.Add("Pineapple");
        }
        public void AddOnions()
        {
            _pizza.Ingredients.Add("Onions");
        }
        public void AddPeppers()
        {
            _pizza.Ingredients.Add("Peppers");
        }
        public void AddSausage()
        {
            _pizza.Ingredients.Add("Sausage");
        }
        public void AddSpinach()
        {
            _pizza.Ingredients.Add("Spinach");
        }
        public void AddTomato()
        {
            _pizza.Ingredients.Add("Tomato");
        }
        public void AddOlives()
        {
            _pizza.Ingredients.Add("Olives");
        }
        public void AddBacon()
        {
            _pizza.Ingredients.Add("Bacon");
        }
        public void AddChicken()
        {
            _pizza.Ingredients.Add("Chicken");
        }
        public void AddBeef()
        {
            _pizza.Ingredients.Add("Beef");
        }
        public void AddPork()
        {
            _pizza.Ingredients.Add("Pork");
        }
        public void AddShrimp()
        {
            _pizza.Ingredients.Add("Shrimp");
        }
        public void AddLobster()
        {
            _pizza.Ingredients.Add("Lobster");
        }
        public void AddCrab()
        {
            _pizza.Ingredients.Add("Crab");
        }
        public void AddAnchovies()
        {
            _pizza.Ingredients.Add("Anchovies");
        }
        public void AddTuna()
        {
            _pizza.Ingredients.Add("Tuna");
        }
        public void AddSalmon()
        {
            _pizza.Ingredients.Add("Salmon");
        }
        public void AddTrout()
        {
            _pizza.Ingredients.Add("Trout");
        }
        public void AddMackerel()
        {
            _pizza.Ingredients.Add("Mackerel");
        }
        public void AddSardines()
        {
            _pizza.Ingredients.Add("Sardines");
        }
        public void AddHerring()
        {
            _pizza.Ingredients.Add("Herring");
        }
        public void AddCaviar()
        {
            _pizza.Ingredients.Add("Caviar");
        }
        public void AddEgg()
        {
            _pizza.Ingredients.Add("Egg");
        }
            
        public void AddTofu()
        {
            _pizza.Ingredients.Add("Tofu");
        }
        public void AddSeitan()
        {
            _pizza.Ingredients.Add("Seitan");
        }
        public void AddTempeh()
        {
            _pizza.Ingredients.Add("Tempeh");
        }
        public void AddAvocado()
        {
            _pizza.Ingredients.Add("Avocado");
        }
        public void AddArtichoke()
        {
            _pizza.Ingredients.Add("Artichoke");
        }
        public void AddAsparagus()
        {
            _pizza.Ingredients.Add("Asparagus");
        }
            
        public void AddBroccoli()
        {
            _pizza.Ingredients.Add("Broccoli");
        }
        public void AddCauliflower()
        {
            _pizza.Ingredients.Add("Cauliflower");
        }
        public void AddCorn()
        {
            _pizza.Ingredients.Add("Corn");
        }
        public void AddCucumber()
        {
            _pizza.Ingredients.Add("Cucumber");
        }
        public void AddEggplant()
        {
            _pizza.Ingredients.Add("Eggplant");
        }
        public void AddGreenBeans()
        {
            _pizza.Ingredients.Add("GreenBeans");
        }
        public void AddKale()
        {
            _pizza.Ingredients.Add("Kale");
        }
        public void AddLeeks()
        {
            _pizza.Ingredients.Add("Leeks");
        }
        public void AddLettuce()
        {
            _pizza.Ingredients.Add("Lettuce");
        }
        public void AddPotato()
        {
            _pizza.Ingredients.Add("Potato");
        }
        public void AddPumpkin()
        {
            _pizza.Ingredients.Add("Pumpkin");
        }
        public void AddRadish()
        {
            _pizza.Ingredients.Add("Radish");
        }
        public void AddSquash()
        {
            _pizza.Ingredients.Add("Squash");
        }
        public void AddSweetPotato()
        {
            _pizza.Ingredients.Add("SweetPotato");
        }
        public void AddTurnip()
        {
            _pizza.Ingredients.Add("Turnip");
        }
        public void AddZucchini()
        {
            _pizza.Ingredients.Add("Zucchini");
        }
        public void AddApple()
        {
            _pizza.Ingredients.Add("Apple");
        }
        public void AddApricot()
        {
            _pizza.Ingredients.Add("Apricot");
        }
        public void AddBanana()
        {
            _pizza.Ingredients.Add("Banana");
        }
        public void AddBlackberry()
        {
            _pizza.Ingredients.Add("Blackberry");
        }
        public void AddBlueberry()
        {
            _pizza.Ingredients.Add("Blueberry");
        }
        public void AddCherry()
        {
            _pizza.Ingredients.Add("Cherry");
        }
        public void AddCoconut()
        {
            _pizza.Ingredients.Add("Coconut");
        }
        public void AddCranberry()
        {
            _pizza.Ingredients.Add("Cranberry");
        }
        public void AddDate()
        {
            _pizza.Ingredients.Add("Date");
        }
        public void AddDragonfruit()
        {
            _pizza.Ingredients.Add("Dragonfruit");
        }
        public void AddDurian()
        {
            _pizza.Ingredients.Add("Durian");
        }
        public void AddFig()
        {
            _pizza.Ingredients.Add("Fig");
        }
        public void AddGrape()
        {
            _pizza.Ingredients.Add("Grape");
        }
        public Pizza GetPizza()
        {
            return _pizza;
        }
    }
}
