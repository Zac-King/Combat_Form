using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat.Classes
{
    class Unit : Interfaces.IAttributes, Interfaces.IDamageable, Interfaces.IKillable
    {
        private float   defense,
                        health,
                        maxHealth,
                        speed,
                        strength;
        private bool    alive;
        public List<Interfaces.IAbility> Abilities;

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

    }
}
