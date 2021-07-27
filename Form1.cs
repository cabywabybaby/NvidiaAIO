using System;
using System.IO;
using System.Net;
using System.Linq;
using Microsoft.Win32;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace Nvidia_AIO
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            //Disable UAC on launch incase user is dumb and does not already have disabled
            RegistryKey UAC = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", true);
            UAC.SetValue("EnableLUA", 0, RegistryValueKind.DWord);

            Process MD = new Process();
            MD.StartInfo.FileName = "cmd.exe";
            MD.StartInfo.Arguments = (@"/c mkdir %AppData%\NvidiaAIO");
            MD.StartInfo.UseShellExecute = false;
            MD.StartInfo.RedirectStandardInput = true;
            MD.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            MD.Start();
            MD.WaitForExit();

            tweaks1.Show();
            programss1.Hide();

        }
         
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tweaks1.Show();
            programss1.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tweaks1.Hide();
            programss1.Show();
        }

        private void programss1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
