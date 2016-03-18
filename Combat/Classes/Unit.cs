using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Combat.Interfaces;

namespace Combat.Classes
{
    [Serializable()]
    class Unit : Interfaces.IUnit
    {
        private float   defense,
                        health,
                        maxHealth,
                        speed,
                        strength;
        private bool    alive;
        private string  name;

        public List<Interfaces.IAbility> Abilities;
        
        #region Constructors
        public Unit(string n, float maxhp, float hp, float def, float spd, float str)
        {
            name        = n;
            maxHealth   = maxhp;
            health      = hp;
            defense     = def;
            speed       = spd;
            strength    = str;
            alive       = true;
            Abilities   = new List<IAbility>();
        }
        #endregion

        public void AddAbility(Ability a)
        {
            if(!Abilities.Contains(a))  // Check to make sure it doesn't already exist
                Abilities.Add(a);
        }

        #region IUnit Implementation

        #region IAttributes Implamentation 
        public float Defense
        {
            get
            {
                return defense;
            }

            set
            {
                defense = value;
            }
        }

        public float Health
        {
            get
            {
                return health;
            }

            set
            {
                health = value;
            }
        }

        public float MaxHealth
        {
            get
            {
                return maxHealth;
            }

            set
            {
                maxHealth = value;
            }
        }

        public float Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        public float Stength
        {
            get
            {
                return strength;
            }

            set
            {
                strength = value;
            }
        }
        #endregion

        #region IDamageable Implamentation
        public void OnDamaged()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IKillable Implamentation
        public bool Alive
        {
            get
            {
                return alive;
            }

            set
            {
                alive = value;
            }
        }

        public void OnDeath()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IUnit specific Implementation  
        string IUnit.Name
        {
            get
            {
                return name;
            }
        }
        #endregion

        #endregion
    }
}
