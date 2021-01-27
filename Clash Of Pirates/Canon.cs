using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Battle_Of_Ships
{
    class Canon
    {
        public string direction;
        public int canonLeft;
        public int canonTop;
        private int speed = 10;
        private PictureBox canon = new PictureBox();
        private Timer canonTimer = new Timer();
        Form Myparent;


        public void MakeCanon(Form form) // When we call this method we take as an argument the form " Game " and we add a control "PictureBox" that we defined of a bullet with the following specifications and the passed left and top positions
        {
            canon.Image = Properties.Resources.Fire;
            canon.BackColor = System.Drawing.Color.Transparent;
            canon.SizeMode = PictureBoxSizeMode.Zoom;
            canon.Size = new Size(10, 10);
            canon.Tag = "canon";
            canon.Left = canonLeft;
            canon.Top = canonTop;
            canon.BringToFront();
            Myparent = form;

            form.Controls.Add(canon);

            canonTimer.Interval = 30;
            canonTimer.Tick += new EventHandler(CanonTimerEvent);
            canonTimer.Start();
        }

        private void CanonTimerEvent(object sender, EventArgs e) // With the Timer Set, with every interval we trigger this event which moves the bullet in the passed direction with the speed we defined
        {
            if (direction == "left")
            {
                canon.Left -= speed;
            }
            if (direction == "right")
            {
                canon.Left += speed;
            }
            if (direction == "up")
            {
                canon.Top -= speed;
            }
            if (direction == "down")
            {
                canon.Top += speed;
            }
            //Here We dispose the canon if there it passed the screen boundaries
            if (canon.Left < 10 || (canon.Left + canon.Width) > Myparent.ClientSize.Width || canon.Top < 10 || canon.Top + canon.Height > Myparent.ClientSize.Height)
            {
                canonTimer.Stop();
                canonTimer.Dispose();
                canon.Dispose();
                canonTimer = null;
                canon = null;
            }
        }
    }
}
