using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat.Classes
{
    class Effect : Interfaces.IEffect
    {
        private string name;
        private int duration;
        private float value;
        private EffectTypes type;

        Effect(string n, int d, float v, EffectTypes t)
        {
            this.name       = n;
            this.duration   = d;
            this.value      = v;
            this.type       = t;
        }

#region IEffect Implementation
        public int Duration
        {
            get
            {
                return duration;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public float Value
        {
            get
            {
                return value;
            }
        }

        public EffectTypes Type
        {
            get
            {
                return type;
            }
        }

        public void OnTick()
        {
            /// Do a thing
            throw new NotImplementedException();
        }
        #endregion
    }
}
