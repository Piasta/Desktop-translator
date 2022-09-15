using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace Desktop_translator
{
    public partial class Form1 : Form
    {
        // DLL libraries used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        const int MYACTION_HOTKEY_ID = 1;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID)
            {
                var tcp = translateControlPanel1;
                tcp.output_rtbx.Text = tcp.Translate(Clipboard.GetText());
            }
            base.WndProc(ref m);
        }

        public Form1()
        {
            InitializeComponent();
            
            /*
            if (RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 6, (int)Keys.F12))
            {
                Console.WriteLine("123");
            }
            */
        }
        private void translate_bt_Click(object sender, EventArgs e)
        {
            translateControlPanel1.BringToFront();
        }
        private void exit_bt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // DRAGGABLE WINDOW: start
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]

        public static extern bool ReleaseCapture();

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        

        }
        // DRAGGABLE WINDOW: end

        /*
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tcp = translateControlPanel1;

            if (e.KeyChar == 3)
            {
                string clipText = Clipboard.GetText();
                tcp.input_rtbx.Text = clipText;
                tcp.output_rtbx.Text = tcp.Translate(tcp.input_rtbx.Text);
            }
            if(e.KeyChar == 24)
            {
                tcp.input_rtbx.Text = "";
                tcp.output_rtbx.Text = "";
            }
        
        }
        */    
        
        // WINDOW ALWAYS ON TOP: start
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        public Boolean pin_bool = true;
        private void button1_Click(object sender, EventArgs e)
        {

            Image pinOn_image = new Bitmap(Desktop_translator.Properties.Resources.on);
            Image pinOff_image = new Bitmap(Desktop_translator.Properties.Resources.off);

            if (pin_bool == true)
            {
                SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
                button1.BackgroundImage = pinOn_image;
                pin_bool = !pin_bool;
            }
            else
            { 
                SetWindowPos(this.Handle, HWND_NOTOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
                button1.BackgroundImage = pinOff_image;
                pin_bool = !pin_bool;
            }
            // WINDOW ALWAYS ON TOP: end
        }
    }
}


