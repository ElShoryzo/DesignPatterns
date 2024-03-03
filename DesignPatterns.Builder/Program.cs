namespace DesignPatterns.Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IPizzaBuilder firstPizzaBuilder = new PizzaBuilder();
            Cook cookFirstPizza = new Cook(firstPizzaBuilder);
            cookFirstPizza.MakeMeatPizza();
            Pizza firstPizza = firstPizzaBuilder.GetPizza();
            Console.WriteLine($"First pizza ingredients: {firstPizza}");

            IPizzaBuilder secondPizzaBuilder = new PizzaBuilder();
            Cook cookSecondPizza = new Cook(secondPizzaBuilder);
            // Se pueden llamar los metodos y se agregan al mismo objeto
            cookSecondPizza.MakeVeggiePizza();
            cookSecondPizza.MakeSeafoodPizza();
            Pizza secondPizza = secondPizzaBuilder.GetPizza();
            Console.WriteLine($"Second pizza ingredients: {secondPizza}");
        }
    }
}
