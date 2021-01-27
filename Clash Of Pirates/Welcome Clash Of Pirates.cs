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
    public partial class Battle_Of_Ships : Form
    {
        public int HighScore = 0;

        public Battle_Of_Ships()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Message msg = new Message(null, this,null, "Are you sure you want to exit?", 2);
            msg.StartPosition = FormStartPosition.CenterParent;
            msg.ShowDialog(this);
            return;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Form FormBackGround = new Form();
            try
            {
                using (Start_Game SG = new Start_Game(this,HighScore))
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

                    SG.StartPosition = FormStartPosition.CenterParent;
                    SG.Owner = FormBackGround;
                    SG.ShowDialog();
                    FormBackGround.Dispose();
                }
            }
            catch(Exception ex)
            {
                Message msg = new Message(null, this,null, ex.Message, 0);
                msg.StartPosition = FormStartPosition.CenterParent;
                msg.ShowDialog(this);

            }
            finally
            {
                FormBackGround.Dispose();
            }
        }

        private void Tutorial_Click(object sender, EventArgs e)
        {
            Form FormBackGround = new Form();
            try
            {
                using (Tutorial T = new Tutorial())
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

                    T.StartPosition = FormStartPosition.CenterParent;
                    T.Owner = FormBackGround;
                    T.ShowDialog();
                    FormBackGround.Dispose();
                }
            }
            catch (Exception ex)
            {
                Message msg = new Message(null, this, null, ex.Message, 0);
                msg.StartPosition = FormStartPosition.CenterParent;
                msg.ShowDialog(this);

            }
            finally
            {
                FormBackGround.Dispose();
            }
        }
    }
}
