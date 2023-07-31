using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace ViCiDial_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                Application.Exit();
            }
        }
    }
}