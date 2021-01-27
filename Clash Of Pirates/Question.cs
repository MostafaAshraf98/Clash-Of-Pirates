using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Battle_Of_Ships
{
    public partial class Question : Form
    {
        public delegate void CloseEvent(bool answer, int type);
        public CloseEvent WindowClosed;
        // windowClosed is a delegate (pointer) to function in parent, i call the delegate when the form closes and trigger along what delegates points to in the parent

        Form MyParent;
        bool answer = false;
        bool Answered_Yet = false;
        System.Timers.Timer t;
        int s = 0;
        Random randNum = new Random();
        int QuestionNum;
        string[] arrayQuestions = new string[20];
        string[] arrayAnswers = new string[20];
        int type;

        public Question(Form p, int type)
        {
            InitializeComponent();
            InitializeQuestions();
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Start();
            MyParent = p;
            this.type = type;

            QuestionNum = randNum.Next(0, 19);
            Correct_Answer_Label.Text = arrayAnswers[QuestionNum];
            Question_Label.Text = arrayQuestions[QuestionNum];
            Question_Label.Left = (this.ClientSize.Width - Question_Label.Width) / 2;
            Question_Label.Top = (this.ClientSize.Height - Question_Label.Height) / 2;
            Question_Label.Top -= 20;
        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s >= 60 && Answered_Yet == false)
                {
                    EventArgs ev = new EventArgs();
                    OK_Click(sender, ev);
                }
                else if (Answered_Yet == false)
                    Time.Text = Convert.ToString(60 - s);
            }
            ));
        }

        private void Close_Click(object sender, EventArgs e)
        {
            WindowClosed(answer, type);
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Answer_Text.Text = Answer_Text.Text.ToUpper();
            Answer_Text.Enabled = false;
            t.Stop();
            Answered_Yet = true;
            OK.Visible = false;
            Continue.Visible = true;
            if (Answer_Text.Text == arrayAnswers[QuestionNum])
            {
                Check.Visible = true;
                Message_Correct_Answer.Visible = true;
                answer = true;
            }
            else
            {
                X_Wrong_Answer.Visible = true;
                Message_Wrong_Answer.Visible = true;
                Display_Correct.Visible = true;
                Correct_Answer_Label.Visible = true;
                answer = false;
            }
        }
        private void InitializeQuestions()
        {
            arrayQuestions[0] = "MOV AX,35H" + Environment.NewLine + "ADD AX,10" + Environment.NewLine + "What is the value in AX (in hexa and without writing H)?";
            arrayQuestions[1] = "MOV AX,5" + Environment.NewLine + "MOV BL,5" + Environment.NewLine +"MUL BL" + Environment.NewLine + "What is the value in AX (in hexa and without writing H)?";
            arrayQuestions[2] = "Write a single instruction Invert bits number 0, 5, 10, and 15 in AX" + Environment.NewLine +"Enter instruction in Hexa and write H at the end";
            arrayQuestions[3] = "Write a single instruction to Divide the content of AX by 16";
            arrayQuestions[4] = "Identify the operand addressing mode used in ADD DX, 15";
            arrayQuestions[5] = "Identify the operand addressing mode used in CMP WORD PTR [BX+DI], 10";
            arrayQuestions[6] = "The folowing instruction gives error or not: MOV SI, offset VAR1"  + Environment.NewLine + "Y for YES, N for NO";
            arrayQuestions[7] = "The folowing instruction gives error or not: REP LOADSB" + Environment.NewLine + "Y for YES, N for NO";
            arrayQuestions[8] = "The folowing instruction gives error or not: MOV CL,[AX]" + Environment.NewLine + "Y for YES, N for NO";
            arrayQuestions[9] = "The folowing instruction gives error or not: MOV AX,BL" + Environment.NewLine + "Y for YES, N for NO";
            arrayQuestions[10] = "The folowing instruction gives error or not:MOV CX, [BP]" + Environment.NewLine + "Y for YES, N for NO";
            arrayQuestions[11] = "The trap flag is NOT used for mathematical operations" + Environment.NewLine + " Y for YES, N for NO";
            arrayQuestions[12] = "If CS = 0701H, SS = 0801H, SI = 0100H and IP = 0108H the physical address of the next instruction is:";
            arrayQuestions[13] = "Which flag does the 80x86 use to check for unsigned arithmetic overflow";
            arrayQuestions[14] = "What is the result in AL in hexa(write H) after executing the following instructions" + Environment.NewLine + "XOR AL, AL" + Environment.NewLine + "OR AL, 80H ";
            arrayQuestions[15] = "If the content of the register SS = 3500H and the content of the register SP= FFFEH,what is the the physical address (write H)";
            arrayQuestions[16] = "Write one line to set the most significant nibble of CX (Using Hexa)";
            arrayQuestions[17] = "The following instruction gives error: MOV num2, num1" + Environment.NewLine + "Y for YES, N for NO";
            arrayQuestions[18] = "Write command to copy the content of bx to cx";
            arrayQuestions[19] = "Write command to put the two bytes of ax in the stack";

            arrayAnswers[0] = "3F";
            arrayAnswers[1] = "19";
            arrayAnswers[2] = "XOR AX,8421H";
            arrayAnswers[3] = "SHR AX,4";
            arrayAnswers[4] = "IMMEDIATE";
            arrayAnswers[5] = "BASED INDEXED RELATIVE";
            arrayAnswers[6] = "N";
            arrayAnswers[7] = "Y";
            arrayAnswers[8] = "Y";
            arrayAnswers[9] = "Y";
            arrayAnswers[10] = "N";
            arrayAnswers[11] = "Y";
            arrayAnswers[12] = "07118H";
            arrayAnswers[13] = "CARRY";
            arrayAnswers[14] = "80H";
            arrayAnswers[15] = "44FFEH";
            arrayAnswers[16] = "OR CX,0F000H";
            arrayAnswers[17] = "Y";
            arrayAnswers[18] = "MOV CX,BX";
            arrayAnswers[19] = "PUSH AX";

        }

        private void Question_Load(object sender, EventArgs e)
        {
            t.Elapsed += OnTimeEvent;
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            WindowClosed(answer, type);
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

        private void Question_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.Enter)
            {
                if (Continue.Visible == true)
                    Continue_Click(sender, e);
                if (OK.Visible == true)
                    OK_Click(sender, e);
            }

        }

        private void Answer_Text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Continue.Visible == true)
                    Continue_Click(sender, e);
                if (OK.Visible == true)
                    OK_Click(sender, e);
            }

        }
    }
}
