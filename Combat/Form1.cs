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
    public partial class RPG : Form
    {
        public RPG()
        {
            InitializeComponent();

        }

        [Serializable]
        public class UnitInfo 
        {
            public float defense,
                        health,
                        maxHealth,
                        speed,
                        strength;
            public bool alive;
            public string name;

            public UnitInfo(string n, float maxhp, float def, float spd, float str)
            {
                name = n;
                maxHealth = maxhp;
                health = maxHealth;
                defense = def;
                speed = spd;
                strength = str;
                alive = true;
            }
            public UnitInfo() { }
        }
        

        private void ChangeAttribute(object sender, EventArgs e)
        {
            Button b = sender as Button;
            Control parent = b.Parent;
            Panel p = parent as Panel;
            Label attValue = new Label();
            Label points = new Label();

            foreach (Control c in parent.Parent.Controls)
            {
                if (c.Name == "RemainingPoints" && c is Label)
                    points = c as Label;
                //
            }

            foreach (Control ch in p.Controls)
            {
                if (ch is Label)
                {
                    attValue = ch as Label;
                    break;
                }
            }

            int val = int.Parse(attValue.Text);
            int pointValue = int.Parse(points.Text);

            if ((b.Text == "<") && (val > 0) && (pointValue <= 15))
            {
                val--;
                pointValue++;
            }

            if ((b.Text == ">") && (val >= 0) && (pointValue > 0))
            {
                val++;
                pointValue--;
            }
            attValue.Text = val.ToString();
            points.Text = pointValue.ToString();
        }

        private void SaveAttributes(object sender, EventArgs e)
        {
            Button b = sender as Button;
            Control parent = b.Parent;
            Panel panelGroup = parent as Panel;

            float str = 0f, def = 0f, spd = 0f;
            string name = "John";

            foreach(Control c in parent.Controls)
            {
                if(c is Panel)
                    foreach( Control c2 in c.Controls)
                        if (c2 is Label)
                        {
                            int val = int.Parse(c2.Text);

                            if (c2.Name == "StrengthValue")
                                str = val;
                            if (c2.Name == "DefenseValue")
                                def = val;
                            if (c2.Name == "SpeedValue")
                                spd = val;
                        }
                if (c is TextBox)
                    name = c.Text;

            }
            /// out of all those checks

            UnitInfo temp = new UnitInfo(name, 20, def, spd, str );

            Utilities.SerializeXML("SavedFiles", name, temp);
        }
        
    }
}
