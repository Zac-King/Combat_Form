using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combat
{
    public partial class Form1 : Form
    {
        Classes.Unit Jake = new Classes.Unit("Jake", 15, 15, 5, 7, 4);
        Classes.Unit Dane = new Classes.Unit("Dane", 12, 12, 6, 8, 5);

        Classes.Ability Attack = new Classes.Ability("Attack", 5);

        public Form1()
        {
            InitializeComponent();
            Jake.AddAbility(Attack);
            Dane.AddAbility(Attack);
        }

        private void Player1Attack_Click(object sender, EventArgs e)
        {
            Jake.Abilities[0].Exucute(Dane);
        }
    }
}
