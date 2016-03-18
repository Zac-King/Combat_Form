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
        bool hasInitial, hasEffect;
        float initialValue;
        IEffect effect;

        #region Constructors
        public Ability(string n, float initVal)    // Ability with only an Intial Acting Value
        {
            name = n;
            initialValue = initVal;
            hasInitial = true;
        }

        public Ability(string n, float initVal, IEffect ef)    // Ability With Intial
        {
            name = n;
            initialValue = initVal;
            hasInitial = true;
            effect = ef;
            hasEffect = true;
        }

        public Ability(string n, IEffect ef)
        {
            name = n;
            hasInitial = false;
            effect = ef;
            hasEffect = true;
        }
        #endregion

        #region IAbility Implementation
        public bool HasInitial
        {
            get
            {
                return hasInitial;
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
                return initialValue;
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

        public void Exucute(IUnit target)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
