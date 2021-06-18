using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace Loader
{
    public partial class Loader : Form
    {
        string dll_name = "sys32";
        int time_to_wait = 40000;

        public Loader()
        {
            InitializeComponent();
        }

        private async void load_Click(object sender, EventArgs e)
        {
            load.Text = "Starting...";

            WebClient wb = new WebClient();
            this.Hide();
            string mainpath = "C:\\Windows\\" + dll_name + ".dll";
            wb.DownloadFile("paste direct download link for dll here", mainpath);

            load.Text = "Running...";

            Process.Start("steam://rungameid/730");
            await Task.Delay(time_to_wait);
            Process csgo = Process.GetProcessesByName("csgo").FirstOrDefault();
            Process[] csgo_array = Process.GetProcessesByName("csgo");
            if (csgo_array.Length != 0)
            {
                load.Text = "Loading...";

                Inject.InjectMethod.Inject(mainpath, "csgo");
                Console.Read();
                csgo.WaitForExit();

                if (File.Exists(mainpath))
                {
                    File.Delete(mainpath);
                }
                Environment.Exit(0);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
