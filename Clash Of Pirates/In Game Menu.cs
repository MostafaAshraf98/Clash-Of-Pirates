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
    public partial class In_Game_Menu : Form
    {
        public delegate void CloseEvent();
        public CloseEvent WindowClosed; // windowClosed is a delegate (pointer) to function in parent, i call the delegate when the form closes and trigger along what delegates points to in the parent

        Form Myparent;
        Battle_Of_Ships GrandParent;
        String Player;
        public In_Game_Menu(Battle_Of_Ships GP, Form p, string Player_name)
        {
            InitializeComponent();
            Myparent = p;
            GrandParent = GP;
            Player = Player_name;
        }

        private void Exit_Game_Click(object sender, EventArgs e)
        {
            Message msg = new Message(GrandParent, Myparent,this, "Do you want to Exit the Game?", 2);
            msg.StartPosition = FormStartPosition.CenterParent;
            msg.ShowDialog(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowClosed();
            this.Close();
        }

        private void Restart_Game_Click(object sender, EventArgs e)
        {
            Message msg = new Message(GrandParent, Myparent,this, "Do you want to Restart?", Player);
            msg.StartPosition = FormStartPosition.CenterParent;
            msg.ShowDialog(this);
        }

        private void Return_To_Main_Menu_Click(object sender, EventArgs e)
        {
            Message msg = new Message(GrandParent, Myparent,this, "Do you want to return to Main Menu?", 1);
            msg.StartPosition = FormStartPosition.CenterParent;
            msg.ShowDialog(this);
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

        private void In_Game_Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                WindowClosed();
                this.Close();
            }
        }
    }
}

