using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    // Clase director
    internal class Cook
    {
        private IPizzaBuilder _pizzaBuilder;
        public Cook(IPizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }
        public void MakeMeatPizza()
        {
            _pizzaBuilder.AddCheese();
            _pizzaBuilder.AddPepperoni();
            _pizzaBuilder.AddSausage();
            _pizzaBuilder.AddBacon();
        }
        public void MakeVeggiePizza()
        {
            _pizzaBuilder.AddCheese();
            _pizzaBuilder.AddMushrooms();
            _pizzaBuilder.AddOnions();
            _pizzaBuilder.AddPeppers();
            _pizzaBuilder.AddSpinach();
            _pizzaBuilder.AddTomato();
            _pizzaBuilder.AddOlives();
        }
        public void MakeSeafoodPizza()
        {
            _pizzaBuilder.AddCheese();
            _pizzaBuilder.AddShrimp();
            _pizzaBuilder.AddLobster();
            _pizzaBuilder.AddCrab();
        }
        public void MakeCheesePizza()
        {
            _pizzaBuilder.AddCheese();
        }


    }
}
