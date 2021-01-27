using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Battle_Of_Ships
{

    public partial class Message : Form
    {
        Form MyParent;
        Battle_Of_Ships GrandParent;
        Form Menu;
        int choice = -1;
        string Player;
        public Message(Battle_Of_Ships GP, Form P, Form M, string Msg, int choice)
        {
            InitializeComponent();
            MyParent = P;
            GrandParent = GP;
            Menu = M;
            this.ShowInTaskbar = false;
            this.choice = choice;

            label1.Text = Msg;
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = (this.ClientSize.Height - label1.Height) / 2;
            label1.Top -= 20;
            if (choice == 0)
            {
                OK.Visible = true;
                OK.Enabled = true;
            }
            else if (choice == 1)
            {
                RETURN.Visible = true;
                NO.Visible = true;
                RETURN.Enabled = true;
                NO.Enabled = true;
            }
            else
            {
                EXIT.Visible = true;
                NO.Visible = true;
                EXIT.Enabled = true;
                NO.Enabled = true;
            }

        }
        public Message(Battle_Of_Ships GP, Form P, Form M, string Msg, string Player)
        {
            InitializeComponent();
            MyParent = P;
            GrandParent = GP;
            Menu = M;

            label1.Text = Msg;
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = (this.ClientSize.Height - label1.Height) / 2;
            label1.Top -= 20;
            this.Player = Player;

            RESTART.Visible = true;
            NO.Visible = true;
            RESTART.Enabled = true;
            NO.Enabled = true;

        }

        private void RETURN_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu.Close();
            GrandParent.Location = MyParent.Location;
            MyParent.Close();
            GrandParent.Show();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RESTART_Click(object sender, EventArgs e)
        {
            this.Close();
            Game G = new Game(GrandParent, Player);
            G.Size = MyParent.Size;
            G.StartPosition = FormStartPosition.CenterParent;
            G.WindowState = MyParent.WindowState;
            G.Show();
            Menu.Close();
            MyParent.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void NO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }

        #region Shadowing

        #region Fields

        private bool _isAeroEnabled = false;
        private bool _isDraggingEnabled = false;
        private const int WM_NCHITTEST = 0x84;
        private const int WS_MINIMIZEBOX = 0x20000;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private const int CS_DBLCLKS = 0x8;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        #endregion

        #region Structures

        [EditorBrowsable(EditorBrowsableState.Never)]
        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        #endregion

        #region Methods

        #region Public

        [DllImport("dwmapi.dll")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static bool IsCompositionEnabled()
        {
            if (Environment.OSVersion.Version.Major < 6) return false;

            bool enabled;
            DwmIsCompositionEnabled(out enabled);

            return enabled;
        }

        #endregion

        #region Private

        [DllImport("dwmapi.dll")]
        private static extern int DwmIsCompositionEnabled(out bool enabled);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
         );

        private bool CheckIfAeroIsEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);

                return (enabled == 1) ? true : false;
            }
            return false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Overrides

        public void ApplyShadows(Form form)
        {
            var v = 2;

            DwmSetWindowAttribute(form.Handle, 2, ref v, 4);

            MARGINS margins = new MARGINS()
            {
                bottomHeight = 1,
                leftWidth = 0,
                rightWidth = 0,
                topHeight = 0
            };

            DwmExtendFrameIntoClientArea(form.Handle, ref margins);
        }


        #endregion

        #endregion

        #endregion

        private void RETURN_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Menu.Close();
            GrandParent.WindowState = MyParent.WindowState;
            GrandParent.Location = MyParent.Location;
            GrandParent.Size = MyParent.Size;
            MyParent.Close();
            GrandParent.Show();
        }

        private void Message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (choice == -1)
                    RESTART_Click(sender, e);
                if (choice == 0)
                    OK_Click(sender, e);
                if (choice == 1)
                    RETURN_Click(sender, e);
                if (choice == 2)
                    EXIT_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }

}

