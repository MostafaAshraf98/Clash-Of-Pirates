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
    public partial class Game_Over : Form
    {
        Battle_Of_Ships GrandParent;
        Game MyParent;
        string Player;
        public Game_Over(Battle_Of_Ships GP, Game p, string Player_name)
        {
            InitializeComponent();
            MyParent = p;
            GrandParent = GP;
            Player = Player_name;
            Score.Text = Convert.ToString(p.Score_Player);
            Highscore.Text = Convert.ToString(GP.HighScore);
            if (GrandParent.HighScore < MyParent.Score_Player)
                GrandParent.HighScore = MyParent.Score_Player;

        }

        private void Restart_Game_Click(object sender, EventArgs e)
        {
            this.Close();
            Game G = new Game(GrandParent, Player);
            G.Size = MyParent.Size;
            G.StartPosition = FormStartPosition.CenterParent;
            G.WindowState = MyParent.WindowState;
            G.Show();
            MyParent.Close();
        }

        private void Return_To_Main_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
            GrandParent.WindowState = MyParent.WindowState;
            GrandParent.Location = MyParent.Location;
            GrandParent.Size = MyParent.Size;
            MyParent.Close();
            GrandParent.Show();
        }

        private void Exit_Game_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
