using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battle_Of_Ships
{
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
            Tutorial_label.Text = ". It is an assembly educational game , The player controls a ship that is attacked by pirates." + Environment.NewLine
+ ". Controls:" + Environment.NewLine
+ Environment.NewLine
+ "UP arrow: Ship moves up." + Environment.NewLine
+ "DOWN arrow: Ship moves down." + Environment.NewLine
+ "RIGHT arrow: Ship moves right." + Environment.NewLine
+ "LEFT arrow: Ship moves left." + Environment.NewLine
+ "SPACE: Shoots canon." + Environment.NewLine
+ "ESC: Opens In_Game Menu." + Environment.NewLine
 + Environment.NewLine
+ ". The Player's ammunition is limited. when it reaches 0, Refuel appears." + Environment.NewLine
+ Environment.NewLine
+ ". The player health decreases when pirates reaches the ship. If the health is less than 30 Healing powerup appears." + Environment.NewLine
+ Environment.NewLine
+ ". Treasure, additional Score, appears every while to increase the player's score by 5." + Environment.NewLine
+ Environment.NewLine
+ ". All these powerups to be collected, the ship must pass over them." + Environment.NewLine
+ Environment.NewLine
+ ". Once the ship passes over a powerup an assembly question pops up and the player has 1 minute to solve it" + Environment.NewLine
+ " If he answeres correctly, powerup's effect occurs." + Environment.NewLine
+ Environment.NewLine
+ ". If he answeres wrong , the correct answer appears but powerup's effect doesn't occur." + Environment.NewLine
+ Environment.NewLine
+ ". The Target is to get the highest possible score." + Environment.NewLine
+ Environment.NewLine
+ ". There are 3 Levels in the game, it gets harder over time, the pirates' speed and their number increase." + Environment.NewLine;

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tutorial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.Enter)
                this.Close();
        }
    }
}
