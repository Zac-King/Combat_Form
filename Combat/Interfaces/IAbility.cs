using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat.Interfaces
{
    public interface IAbility
    {
        // Properties 
        string  Name            { get; }       // Identifier of Ability
        float   InitialValue    { get; }       // Intial Effecting Value
        bool    HasInitial      { get; }       // Does it apply a value on 
        bool    HasEffect       { get; }       // Does the Abilty Grant an Effect
        IEffect Effect          { get; }       // Appliable Effect
        // Functions
        void Exucute(IUnit target);             // Do the Abilty
        bool Available();                       // Check to see it Ability can be used

    }
}
