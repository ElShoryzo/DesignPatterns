using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    internal abstract class Person
    {
        protected IMediator mediator;
        public string Name { get; set; }
        public Person(IMediator mediator, string name)
        {
            this.mediator = mediator;
            Name = name;
        }
        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
