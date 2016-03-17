using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat.Classes
{

    class Ability : Interfaces.IAbility
    {
        private string name;


        Ability(string n)
        {
            name = n;
        }


        public string Name
        {
            get
            {
                return name;
            }
        }

        public void Exucute()
        {
            throw new NotImplementedException();
        }
    }
}
