using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    internal class Mediator : IMediator
    {
        private Dictionary<string, Comrade> _comrades = new();
        public void Register(Comrade comrade)
        {
            if (!_comrades.ContainsValue(comrade))
            {
                _comrades[comrade.Name] = comrade;
            }
        }
        public void SendMessage(string message, Person sender)
        {
            foreach (var comrade in _comrades.Values)
            {
                if (comrade != sender)
                {
                    comrade.Receive(message);
                }
            }
        }
    }
}
