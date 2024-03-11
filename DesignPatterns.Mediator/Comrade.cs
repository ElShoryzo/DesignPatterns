using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    internal class Comrade : Person
    {
        public Comrade(IMediator mediator, string name) : base(mediator, name)
        {
        }
        public override void Send(string message)
        {
            Console.WriteLine($"{Name} sends message: {message}");
            mediator.SendMessage(message, this);
        }
        public override void Receive(string message)
        {
            Console.WriteLine($"{Name} received message: {message}");
        }
    }
}
