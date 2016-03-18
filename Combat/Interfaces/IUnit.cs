using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat.Interfaces
{
    public interface IUnit : Interfaces.IAttributes, Interfaces.IDamageable, Interfaces.IKillable
    {
        string Name { get; }
    }
}
