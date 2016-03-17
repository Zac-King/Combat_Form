using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Combat.Interfaces;

namespace Combat.Classes
{

    class Ability : Interfaces.IAbility
    {
        private string name;
        bool damageOnExecute, hasEffect;
        float intialValue;
        IEffect effect;

        Ability(string n, float initVal)    // Ability with only an Intial Acting Value
        {
            name = n;
            intialValue = initVal;
            damageOnExecute = true;
        }

        Ability(string n, float initVal, IEffect ef)    // Ability With Intial
        {
            name = n;
            intialValue = initVal;
            damageOnExecute = true;
            effect = ef;
            hasEffect = true;
        }

        Ability(string n, IEffect ef)
        {
            name = n;
            damageOnExecute = false;
            effect = ef;
            hasEffect = true;
        }

        public bool ActOnExucute
        {
            get
            {
                return damageOnExecute;
            }
        }

        public IEffect Effect
        {
            get
            {
                return effect;
            }
        }

        public bool HasEffect
        {
            get
            {
                return hasEffect;
            }
        }

        public float InitialValue
        {
            get
            {
                return intialValue;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        

        public bool Available()
        {
            throw new NotImplementedException();
        }

        public void Exucute()
        {
            throw new NotImplementedException();
        }
    }
}
