namespace DesignPatterns.Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new();
            Comrade comrade1 = new(mediator, "Comrade 1");
            Comrade comrade2 = new(mediator, "Comrade 2");
            Comrade comrade3 = new(mediator, "Comrade 3");
            mediator.Register(comrade1);
            mediator.Register(comrade2);
            mediator.Register(comrade3);
            comrade1.Send("Hello, comrades!");
            // OUTPUT:
            /*
             *  Comrade 1 sends message: Hello, comrades!
             *  Comrade 2 received message: Hello, comrades!
             *  Comrade 3 received message: Hello, comrades!
             * 
             */
        }
    }
}
