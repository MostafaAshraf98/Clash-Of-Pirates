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
    public partial class Game : Form
    {
        int level = 1;
        Battle_Of_Ships Myparent;
        string Player_Name;
        public int Score_Player = 0;
        bool GoUp, GoRight, GoDown, GoLeft, GameOver;
        string facing = "up";
        int PlayerHealth = 100;
        int speed = 10;
        int ammunition = 10;
        int PiratesSpeed = 3;
        bool Ammunition_Appeared = false;
        bool Health_Appeared = false;
        bool Treasure_Appeared = false;
        Random randNum = new Random();

        List<PictureBox> PiratesList = new List<PictureBox>(); // List is like an array which we will fill with the pirates in the screen

        public Game(Battle_Of_Ships p, string Player1_Name)
        {
            InitializeComponent();
            GameTimer.Start();
            Myparent = p;
            this.Player_Name = Player1_Name;

            Player_Label.Text = this.Player_Name;
            Score.Text = Convert.ToString(this.Score_Player);



            Player_Label.BackColor = System.Drawing.Color.Transparent;
            Score_Label.BackColor = System.Drawing.Color.Transparent;
            Score.BackColor = System.Drawing.Color.Transparent;
            Ammunition_Label.BackColor = System.Drawing.Color.Transparent;
            Ammunition.BackColor = System.Drawing.Color.Transparent;
            Health_Label.BackColor = System.Drawing.Color.Transparent;
            ESC_Label.BackColor = System.Drawing.Color.Transparent;
            Ship.BackColor = System.Drawing.Color.Transparent;

            for (int i = 0; i < 3; i++)
            {
                MakePirates();
            }
        }



        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (GameOver == true)
                return;
            if (e.KeyCode == Keys.Escape)
            {
                Form FormBackGround = new Form();
                try
                {
                    using (In_Game_Menu GM = new In_Game_Menu(Myparent, this, Player_Name))
                    {
                        FormBackGround.StartPosition = FormStartPosition.Manual;
                        FormBackGround.FormBorderStyle = FormBorderStyle.None;
                        FormBackGround.Opacity = .70d;
                        FormBackGround.BackColor = Color.Black;
                        FormBackGround.WindowState = FormWindowState.Maximized;
                        FormBackGround.TopMost = true;
                        FormBackGround.Location = this.Location;
                        FormBackGround.ShowInTaskbar = false;
                        FormBackGround.Show();

                        GM.WindowClosed += ChildIsClosed;
                        GM.Owner = FormBackGround;
                        GM.StartPosition = FormStartPosition.CenterParent;
                        GameTimer.Stop();
                        GM.ShowDialog();
                        FormBackGround.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    Message msg = new Message(null, this, null, ex.Message, 0);
                    msg.StartPosition = FormStartPosition.CenterParent;
                    msg.ShowDialog();

                }
                finally
                {
                    FormBackGround.Dispose();
                }

            }
            if (e.KeyCode == Keys.Left)
            {
                GoLeft = true;
                facing = "left";
                Ship.Image = Properties.Resources.Ship_Left;
            }
            if (e.KeyCode == Keys.Right)
            {
                GoRight = true;
                facing = "right";
                Ship.Image = Properties.Resources.Ship_Right;
            }
            if (e.KeyCode == Keys.Up)
            {
                GoUp = true;
                facing = "up";
                Ship.Image = Properties.Resources.Ship_Up;
            }
            if (e.KeyCode == Keys.Down)
            {
                GoDown = true;
                facing = "down";
                Ship.Image = Properties.Resources.Ship_Down;
            }
        }

        private void ChildIsClosed()
        {
            GameTimer.Start();
        }

        private void QuestionIsClosed(bool answer, int type)
        {
            GameTimer.Start();
            if (answer == true)
            {
                if (type == 0) // ammo
                    ammunition += 5;
                if (type == 1) // health
                    PlayerHealth += 20;
                if (type == 2)
                    Score_Player += 5;
            }


        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            Ammunition.Text = Convert.ToString(ammunition);
            Score.Text = Convert.ToString(Score_Player);

            if (PlayerHealth > 1)
            {
                HealthBar.Value = PlayerHealth;

            }
            else
            {

                GameOver = true;
                Ship.Image = Properties.Resources.Wreck;
                Ship.Size = new Size(120, 90);
                GameTimer.Stop();
                Form FormBackGround = new Form();
                try
                {
                    using (Game_Over GO = new Game_Over(Myparent, this, Player_Name))
                    {
                        FormBackGround.StartPosition = FormStartPosition.Manual;
                        FormBackGround.FormBorderStyle = FormBorderStyle.None;
                        FormBackGround.Opacity = .70d;
                        FormBackGround.BackColor = Color.Black;
                        FormBackGround.WindowState = FormWindowState.Maximized;
                        FormBackGround.TopMost = true;
                        FormBackGround.Location = this.Location;
                        FormBackGround.ShowInTaskbar = false;
                        FormBackGround.Show();

                        GO.Owner = FormBackGround;
                        GO.StartPosition = FormStartPosition.CenterParent;
                        GO.ShowDialog();
                        FormBackGround.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    Message msg = new Message(null, this, null, ex.Message, 0);
                    msg.StartPosition = FormStartPosition.CenterParent;
                    msg.ShowDialog();

                }
                finally
                {
                    FormBackGround.Dispose();
                }

            }
            if (Score_Player >= 25 && level != 2)
            {
                level = 2;
                MakePirates();
                PiratesSpeed += 1;
            }
            if (Score_Player >= 50 && level != 3)
            {
                level = 3;
                MakePirates();
                PiratesSpeed += 1;
            }


            if (GoLeft == true && Ship.Left > 0)
            {
                Ship.Left -= speed;
            }
            if (GoRight == true && (Ship.Left + Ship.Width < this.ClientSize.Width))
            {
                Ship.Left += speed;
            }
            if (GoUp == true && Ship.Top > 50)
            {
                Ship.Top -= speed;
            }
            if (GoDown == true && (Ship.Top + Ship.Height < this.ClientSize.Height))
            {
                Ship.Top += speed;
            }

            if (ammunition < 1 && Ammunition_Appeared == false)
                DropAmmunition();

            if (PlayerHealth <= 30 && Health_Appeared == false)
                DropHealth();

            if (Score_Player % 20 == 0 && Treasure_Appeared == false)
                DropTreasure();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (Ship.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        Ammunition_Appeared = false;
                        GameTimer.Stop();
                        Question Q = new Question(this, 0);
                        Q.WindowClosed += QuestionIsClosed;
                        Q.StartPosition = FormStartPosition.CenterParent;
                        Q.ShowDialog();
                        GoLeft = false;
                        GoRight = false;
                        GoUp = false;
                        GoDown = false;

                    }
                }
                if (x is PictureBox && (string)x.Tag == "health")
                {
                    if (Ship.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        Health_Appeared = false;
                        GameTimer.Stop();
                        Question Q = new Question(this, 1);
                        Q.WindowClosed += QuestionIsClosed;
                        Q.StartPosition = FormStartPosition.CenterParent;
                        Q.ShowDialog();
                        GoLeft = false;
                        GoRight = false;
                        GoUp = false;
                        GoDown = false;

                    }
                }
                if (x is PictureBox && (string)x.Tag == "treasure")
                {
                    if (Ship.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        Treasure_Appeared = false;
                        GameTimer.Stop();
                        Question Q = new Question(this, 2);
                        Q.WindowClosed += QuestionIsClosed;
                        Q.StartPosition = FormStartPosition.CenterParent;
                        Q.ShowDialog();
                        GoLeft = false;
                        GoRight = false;
                        GoUp = false;
                        GoDown = false;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "pirate")
                {
                    if (Ship.Bounds.IntersectsWith(x.Bounds))
                    {
                        PlayerHealth -= 1;
                    }

                    if (x.Left > Ship.Left)
                    {
                        if (x.Left - Ship.Left < 3)
                            x.Left = Ship.Left;
                        else
                            x.Left -= PiratesSpeed;
                        ((PictureBox)x).Image = Properties.Resources.P_Left;
                    }
                    if (x.Left < Ship.Left)
                    {
                        if (Ship.Left - x.Left < 3)
                            x.Left = Ship.Left;
                        else
                            x.Left += PiratesSpeed;
                        ((PictureBox)x).Image = Properties.Resources.P_Right;
                    }
                    if (x.Top > Ship.Top)
                    {
                        if (x.Top - Ship.Top < 3)
                            x.Top = Ship.Top;
                        else
                            x.Top -= PiratesSpeed;
                        ((PictureBox)x).Image = Properties.Resources.P_Up;
                    }
                    if (x.Top < Ship.Top)
                    {
                        if (Ship.Top - x.Top < 3)
                            x.Top = Ship.Top;
                        else
                            x.Top += PiratesSpeed;
                        ((PictureBox)x).Image = Properties.Resources.P_Down;
                    }
                }
                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "canon" && x is PictureBox && (string)x.Tag == "pirate")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            Score_Player++;
                            this.Controls.Remove(j);
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            ((PictureBox)j).Dispose();
                            PiratesList.Remove((PictureBox)x);
                            MakePirates();
                        }
                    }
                }
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (GameOver == true)
                return;
            if (e.KeyCode == Keys.Left)
            {
                GoLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                GoRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                GoUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                GoDown = false;
            }
            if (e.KeyCode == Keys.Space && ammunition > 0)
            {
                ammunition--;
                ShootCanon(facing);
            }


        }

        private void ShootCanon(string Direction)
        {
            Canon canon = new Canon();
            canon.direction = Direction;
            canon.canonLeft = Ship.Left + (Ship.Width) / 2; // Canon Orgines from the middle of the ship
            canon.canonTop = Ship.Top + (Ship.Height) / 2;
            canon.MakeCanon(this);
        }
        private void MakePirates()
        {
            PictureBox pirate = new PictureBox();
            pirate.Tag = "pirate";
            pirate.Image = Properties.Resources.P_Down;
            pirate.Size = new Size(95, 110);
            pirate.Left = randNum.Next(0, this.ClientSize.Width + 50);
            pirate.Top = randNum.Next(0, this.ClientSize.Height + 50);
            pirate.SizeMode = PictureBoxSizeMode.StretchImage;
            pirate.BackColor = System.Drawing.Color.Transparent;
            PiratesList.Add(pirate);
            this.Controls.Add(pirate);
            Ship.BringToFront();
        }

        private void DropAmmunition() // the ammunition refuel
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.Ammo;
            ammo.BackColor = System.Drawing.Color.Transparent;
            ammo.SizeMode = PictureBoxSizeMode.StretchImage;
            ammo.Size = new Size(50, 50);
            ammo.Left = randNum.Next(50, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(100, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            Ammunition_Appeared = true;
            ammo.BringToFront();
            Ship.BringToFront();
        }

        private void DropHealth() // the ammunition refuel
        {
            PictureBox Health = new PictureBox();
            Health.Image = Properties.Resources.Health;
            Health.BackColor = System.Drawing.Color.Transparent;
            Health.SizeMode = PictureBoxSizeMode.StretchImage;
            Health.Size = new Size(50, 50);
            Health.Left = randNum.Next(50, this.ClientSize.Width - Health.Width);
            Health.Top = randNum.Next(100, this.ClientSize.Height - Health.Height);
            Health.Tag = "health";
            this.Controls.Add(Health);
            Health_Appeared = true;
            Health.BringToFront();
            Ship.BringToFront();
        }

        private void DropTreasure() // the ammunition refuel
        {
            PictureBox Treasure = new PictureBox();
            Treasure.Image = Properties.Resources.treasure_chest_96px;
            Treasure.BackColor = System.Drawing.Color.Transparent;
            Treasure.SizeMode = PictureBoxSizeMode.StretchImage;
            Treasure.Size = new Size(50, 50);
            Treasure.Left = randNum.Next(50, this.ClientSize.Width - Treasure.Width);
            Treasure.Top = randNum.Next(100, this.ClientSize.Height - Treasure.Height);
            Treasure.Tag = "treasure";
            this.Controls.Add(Treasure);
            Treasure_Appeared = true;
            Treasure.BringToFront();
            Ship.BringToFront();
        }

    }
}
