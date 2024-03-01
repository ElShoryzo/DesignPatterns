using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Players
{
    // Crear interfaz que tendra metodos que pueden cambiar su comportamiento en implementaciones
    public interface IPlayer
    {
        int GetRemainingHP();
        int GetTotalDamage();
        int GetTotalDefense();
        void AttackPlayer(IPlayer enemy);
        void Defend(int incomingAttack);
    }
}
