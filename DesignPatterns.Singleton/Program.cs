namespace DesignPatterns.Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton instance1 = Singleton.Instance;
            Singleton instance2 = Singleton.Instance;
            // Son la misma instancia a pesar de que se crearon dos objetos
            if (instance1 == instance2)
            {
                System.Console.WriteLine("Objects are the same instance");
            }
            else
            {
                System.Console.WriteLine("Objects are different instances");
            }
            instance1.Method();
        }
    }
}
