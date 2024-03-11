using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    internal interface IMediator
    {
        void SendMessage(string message, Person sender);
    }
}
