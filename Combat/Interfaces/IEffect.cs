using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat.Interfaces
{
    public interface IEffect
    {
        // Properties
        string  Name { get; }       // Effect Name
        int Duration { get; }       // How many Ticks the Effect last
        float  Value { get; }       // How much to alter per tick
        EffectTypes Type { get; }   // What 
        // Functions
        void OnTick();  // Effect's Turn
    }
}
