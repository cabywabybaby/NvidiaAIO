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
    public partial class Programss : UserControl
    {
        public Programss()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //DDU

            try
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\DDU\DDU\Display Driver Uninstaller.exe"))
                {
                    WebClient DDU = new WebClient();
                    DDU.DownloadFile("https://cdn.discordapp.com/attachments/846483420489056296/847174333684121640/DDU.zip", Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\DDU.zip");
                    WebClient i7zG = new WebClient();
                    i7zG.DownloadFile("https://cdn.discordapp.com/attachments/846483420489056296/847169213919002684/7zG.exe", "C:\\Windows\\Temp\\7zG.exe");


                    Process extract = new Process();
                    extract.StartInfo.FileName = "C:\\Windows\\Temp\\7zG.exe";
                    extract.StartInfo.Arguments = "x \"" + Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\DDU.zip" + "\" -o" + Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\DDU";
                    extract.StartInfo.UseShellExecute = false;
                    extract.StartInfo.RedirectStandardInput = true;
                    extract.Start();
                    extract.WaitForExit();


                    Process DDUOPEN = new Process();
                    DDUOPEN.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\DDU\DDU\Display Driver Uninstaller.exe";
                    DDUOPEN.StartInfo.UseShellExecute = false;
                    DDUOPEN.StartInfo.RedirectStandardInput = true;
                    DDUOPEN.Start();


                    Process Delete1 = new Process();
                    Delete1.StartInfo.FileName = "cmd.exe";
                    Delete1.StartInfo.Arguments = @"/c del /f C:\Windows\Temp\7zG.exe";
                    Delete1.StartInfo.UseShellExecute = false;
                    Delete1.StartInfo.RedirectStandardInput = true;
                    Delete1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    Delete1.Start();
                    Delete1.WaitForExit();


                }
                else
                {
                    Process DDUOPEN1 = new Process();
                    DDUOPEN1.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\DDU\DDU\Display Driver Uninstaller.exe";
                    DDUOPEN1.StartInfo.UseShellExecute = false;
                    DDUOPEN1.StartInfo.RedirectStandardInput = true;
                    DDUOPEN1.Start();

                }

            }
            catch (Exception nice)
            {
                MessageBox.Show(nice.ToString());
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //After Burner

            //https://drive.google.com/uc?id=1x7kKdUnPdd9W4V0Z4itvT3osGnlQ26V7&export=download
            try
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\Afterburner\Afterburner\MSIAfterburner.exe"))
                {
                    {

                        WebClient MSI = new WebClient();
                        MSI.DownloadFile("https://drive.google.com/uc?id=1x7kKdUnPdd9W4V0Z4itvT3osGnlQ26V7&export=download", Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\Afterburner.7z");

                        WebClient i7zG = new WebClient();
                        i7zG.DownloadFile("https://cdn.discordapp.com/attachments/846483420489056296/847169213919002684/7zG.exe", "C:\\Windows\\Temp\\7zG.exe");

                    }
                    Process extract = new Process();
                    extract.StartInfo.FileName = "C:\\Windows\\Temp\\7zG.exe";
                    extract.StartInfo.Arguments = "x \"" + Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\Afterburner.7z" + "\" -o" + Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\Afterburner";
                    extract.StartInfo.UseShellExecute = false;
                    extract.StartInfo.RedirectStandardInput = true;
                    extract.Start();
                    extract.WaitForExit();


                    Process Afterburner = new Process();
                    Afterburner.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\Afterburner\Afterburner\MSIAfterburner.exe";
                    Afterburner.StartInfo.UseShellExecute = false;
                    Afterburner.StartInfo.RedirectStandardInput = true;
                    Afterburner.Start();


                    Process Delete7 = new Process();
                    Delete7.StartInfo.FileName = "cmd.exe";
                    Delete7.StartInfo.Arguments = @"/c del /f C:\Windows\Temp\7zG.exe";
                    Delete7.StartInfo.UseShellExecute = false;
                    Delete7.StartInfo.RedirectStandardInput = true;
                    Delete7.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    Delete7.Start();
                    Delete7.WaitForExit();


                }
                else
                {
                    Process Afterburner1 = new Process();
                    Afterburner1.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\Afterburner\Afterburner\MSIAfterburner.exe";
                    Afterburner1.StartInfo.UseShellExecute = false;
                    Afterburner1.StartInfo.RedirectStandardInput = true;
                    Afterburner1.Start();

                }
            }
            catch (Exception Afterburner)
            {
                MessageBox.Show(Afterburner.ToString());
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            //affinity policy tool

            try
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\InterruptAffinity.exe"))
                {
                    WebClient InterruptAffinity1 = new WebClient();
                    InterruptAffinity1.DownloadFile("https://cdn.discordapp.com/attachments/846483420489056296/851828696633180190/InterruptAffinity.exe", Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\InterruptAffinity.exe");

                    Process InterruptAffinityOPEN = new Process();
                    InterruptAffinityOPEN.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\InterruptAffinity.exe";
                    InterruptAffinityOPEN.StartInfo.UseShellExecute = false;
                    InterruptAffinityOPEN.StartInfo.RedirectStandardInput = true;
                    InterruptAffinityOPEN.Start();


                }
                else
                {
                    Process InterruptAffinity1OPEN = new Process();
                    InterruptAffinity1OPEN.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\InterruptAffinity.exe";
                    InterruptAffinity1OPEN.StartInfo.UseShellExecute = false;
                    InterruptAffinity1OPEN.StartInfo.RedirectStandardInput = true;
                    InterruptAffinity1OPEN.Start();

                }

            }
            catch (Exception InterruptAffinity)
            {
                MessageBox.Show(InterruptAffinity.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Affinity Checker
            try
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\InterruptChecker.exe"))
                {
                    WebClient InterruptChecker1 = new WebClient();
                    InterruptChecker1.DownloadFile("https://cdn.discordapp.com/attachments/846483420489056296/851828717156433920/InterruptChecker.exe", Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\InterruptChecker.exe");

                    Process InterruptCheckerOPEN = new Process();
                    InterruptCheckerOPEN.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\InterruptChecker.exe";
                    InterruptCheckerOPEN.StartInfo.UseShellExecute = false;
                    InterruptCheckerOPEN.StartInfo.RedirectStandardInput = true;
                    InterruptCheckerOPEN.Start();


                }
                else
                {
                    Process InterruptChecker1OPEN = new Process();
                    InterruptChecker1OPEN.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\InterruptChecker.exe";
                    InterruptChecker1OPEN.StartInfo.UseShellExecute = false;
                    InterruptChecker1OPEN.StartInfo.RedirectStandardInput = true;
                    InterruptChecker1OPEN.Start();

                }

            }
            catch (Exception InterruptChecker)
            {
                MessageBox.Show(InterruptChecker.ToString());
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //power mizer

            try
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\NVPMManagerUni.exe"))
                {
                    WebClient Powermizer1 = new WebClient();
                    Powermizer1.DownloadFile("https://cdn.discordapp.com/attachments/846483420489056296/869061786240962640/NVPMManagerUni.exe", Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\NVPMManagerUni.exe");

                    Process PowermizerOPEN = new Process();
                    PowermizerOPEN.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\NVPMManagerUni.exe";
                    PowermizerOPEN.StartInfo.UseShellExecute = false;
                    PowermizerOPEN.StartInfo.RedirectStandardInput = true;
                    PowermizerOPEN.Start();


                }
                else
                {
                    Process Powermizer1OPEN = new Process();
                    Powermizer1OPEN.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\NVPMManagerUni.exe";
                    Powermizer1OPEN.StartInfo.UseShellExecute = false;
                    Powermizer1OPEN.StartInfo.RedirectStandardInput = true;
                    Powermizer1OPEN.Start();

                }

            }
            catch (Exception Powermizer)
            {
                MessageBox.Show(Powermizer.ToString());
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //MSI mode util via MBK

            try
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\MSIv3.exe"))
                {
                    WebClient MSIv31 = new WebClient();
                    MSIv31.DownloadFile("https://cdn.discordapp.com/attachments/846483420489056296/851828189202350130/MSIv3.exe", Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\MSIv3.exe");

                    Process MSIv3OPEN = new Process();
                    MSIv3OPEN.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\MSIv3.exe";
                    MSIv3OPEN.StartInfo.UseShellExecute = false;
                    MSIv3OPEN.StartInfo.RedirectStandardInput = true;
                    MSIv3OPEN.Start();


                }
                else
                {
                    Process MSIv31OPEN = new Process();
                    MSIv31OPEN.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\MSIv3.exe";
                    MSIv31OPEN.StartInfo.UseShellExecute = false;
                    MSIv31OPEN.StartInfo.RedirectStandardInput = true;
                    MSIv31OPEN.Start();

                }

            }
            catch (Exception MSIv3)
            {
                MessageBox.Show(MSIv3.ToString());
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //GPU-Z

            try
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\zGPU.exe"))
                {
                    WebClient zGPU1 = new WebClient();
                    zGPU1.DownloadFile("https://cdn.discordapp.com/attachments/846483420489056296/851818453605285949/zGPU.exe", Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\zGPU.exe");

                    Process zGPUOPEN = new Process();
                    zGPUOPEN.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\zGPU.exe";
                    zGPUOPEN.StartInfo.UseShellExecute = false;
                    zGPUOPEN.StartInfo.RedirectStandardInput = true;
                    zGPUOPEN.Start();


                }
                else
                {
                    Process zGPU1OPEN = new Process();
                    zGPU1OPEN.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\zGPU.exe";
                    zGPU1OPEN.StartInfo.UseShellExecute = false;
                    zGPU1OPEN.StartInfo.RedirectStandardInput = true;
                    zGPU1OPEN.Start();

                }

            }
            catch (Exception zGPU)
            {
                MessageBox.Show(zGPU.ToString());
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //HWINFO64

            try
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\HWiNFO64.exe"))
                {
                    WebClient HWiNFO641 = new WebClient();
                    HWiNFO641.DownloadFile("https://cdn.discordapp.com/attachments/846483420489056296/851822558550425600/HWiNFO64.exe", Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\HWiNFO64.exe");

                    Process HWiNFO64OPEN = new Process();
                    HWiNFO64OPEN.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\HWiNFO64.exe";
                    HWiNFO64OPEN.StartInfo.UseShellExecute = false;
                    HWiNFO64OPEN.StartInfo.RedirectStandardInput = true;
                    HWiNFO64OPEN.Start();


                }
                else
                {
                    Process HWiNFO641OPEN = new Process();
                    HWiNFO641OPEN.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\HWiNFO64.exe";
                    HWiNFO641OPEN.StartInfo.UseShellExecute = false;
                    HWiNFO641OPEN.StartInfo.RedirectStandardInput = true;
                    HWiNFO641OPEN.Start();

                }

            }
            catch (Exception HWiNFO64)
            {
                MessageBox.Show(HWiNFO64.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Thermspy

            try
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\ThermSpy.exe"))
                {
                    WebClient ThermSpy1 = new WebClient();
                    ThermSpy1.DownloadFile("https://cdn.discordapp.com/attachments/846483420489056296/851821619932692510/ThermSpy.exe", Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\ThermSpy.exe");

                    Process ThermSpyOPEN = new Process();
                    ThermSpyOPEN.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\ThermSpy.exe";
                    ThermSpyOPEN.StartInfo.UseShellExecute = false;
                    ThermSpyOPEN.StartInfo.RedirectStandardInput = true;
                    ThermSpyOPEN.Start();


                }
                else
                {
                    Process ThermSpy1OPEN = new Process();
                    ThermSpy1OPEN.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\ThermSpy.exe";
                    ThermSpy1OPEN.StartInfo.UseShellExecute = false;
                    ThermSpy1OPEN.StartInfo.RedirectStandardInput = true;
                    ThermSpy1OPEN.Start();

                }

            }
            catch (Exception ThermSpy)
            {
                MessageBox.Show(ThermSpy.ToString());
            }


        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Everything

            try
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\Everything\Everything.exe"))
                {
                    WebClient ET = new WebClient();
                    ET.DownloadFile("https://cdn.discordapp.com/attachments/846483420489056296/851824741400445038/Everything.zip", Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\Everything.zip");
                    WebClient i7zG = new WebClient();
                    i7zG.DownloadFile("https://cdn.discordapp.com/attachments/846483420489056296/847169213919002684/7zG.exe", "C:\\Windows\\Temp\\7zG.exe");


                    Process extract = new Process();
                    extract.StartInfo.FileName = "C:\\Windows\\Temp\\7zG.exe";
                    extract.StartInfo.Arguments = "x \"" + Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\Everything.zip" + "\" -o" + Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\Everything";
                    extract.StartInfo.UseShellExecute = false;
                    extract.StartInfo.RedirectStandardInput = true;
                    extract.Start();
                    extract.WaitForExit();


                    Process ETOPEN = new Process();
                    ETOPEN.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\Everything\Everything.exe";
                    ETOPEN.StartInfo.UseShellExecute = false;
                    ETOPEN.StartInfo.RedirectStandardInput = true;
                    ETOPEN.Start();

                    Process DeleteET = new Process();
                    DeleteET.StartInfo.FileName = "cmd.exe";
                    DeleteET.StartInfo.Arguments = @"/c del /f C:\Windows\Temp\7zG.exe";
                    DeleteET.StartInfo.UseShellExecute = false;
                    DeleteET.StartInfo.RedirectStandardInput = true;
                    DeleteET.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    DeleteET.Start();
                    DeleteET.WaitForExit();


                }
                else
                {
                    Process ETOPEN1 = new Process();
                    ETOPEN1.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\Everything\Everything.exe";
                    ETOPEN1.StartInfo.UseShellExecute = false;
                    ETOPEN1.StartInfo.RedirectStandardInput = true;
                    ETOPEN1.Start();

                }

            }
            catch (Exception nice)
            {
                MessageBox.Show(nice.ToString());
            }


        }

        private void button11_Click(object sender, EventArgs e)
        {
            //CRU

            try
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\CRU.exe"))
                {
                    WebClient CRU1 = new WebClient();
                    CRU1.DownloadFile("https://cdn.discordapp.com/attachments/846483420489056296/846483781610504212/CRU.exe", Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\CRU.exe");

                    Process CRUOPEN = new Process();
                    CRUOPEN.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\CRU.exe";
                    CRUOPEN.StartInfo.UseShellExecute = false;
                    CRUOPEN.StartInfo.RedirectStandardInput = true;
                    CRUOPEN.Start();


                }
                else
                {
                    Process CRUOPEN = new Process();
                    CRUOPEN.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\CRU.exe";
                    CRUOPEN.StartInfo.UseShellExecute = false;
                    CRUOPEN.StartInfo.RedirectStandardInput = true;
                    CRUOPEN.Start();

                }

            }
            catch (Exception CRU)
            {
                MessageBox.Show(CRU.ToString());
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {

            //Reset All


            try
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("AppData") + @"\Caleb\resset-all.exe"))
                {
                    WebClient Restart64 = new WebClient();
                    Restart64.DownloadFile("https://cdn.discordapp.com/attachments/846483420489056296/846503709146873876/reset-all.exe", Environment.GetEnvironmentVariable("AppData") + @"\Caleb\reset-all.exe");

                    Process reset = new Process();
                    reset.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\Caleb\reset-all.exe";
                    reset.StartInfo.Arguments = "/q";
                    reset.StartInfo.UseShellExecute = false;
                    reset.StartInfo.RedirectStandardInput = true;
                    reset.Start();


                    ;
                    if (MessageBox.Show("Restart GPU Driver?", "Do this so changes take place", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            if (!File.Exists(Environment.GetEnvironmentVariable("AppData") + @"\Caleb\restart64.exe"))
                            {
                                WebClient Restart645 = new WebClient();
                                Restart645.DownloadFile("https://cdn.discordapp.com/attachments/846483420489056296/846503691066277918/restart64.exe", Environment.GetEnvironmentVariable("AppData") + @"\Caleb\restart64.exe");

                                Process OPEN64 = new Process();
                                OPEN64.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\Caleb\restart64.exe";
                                OPEN64.StartInfo.Arguments = "/q";
                                OPEN64.StartInfo.UseShellExecute = false;
                                OPEN64.StartInfo.RedirectStandardInput = true;
                                OPEN64.Start();


                            }
                            else
                            {
                                Process OPEN642 = new Process();
                                OPEN642.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\Caleb\restart64.exe";
                                OPEN642.StartInfo.Arguments = "/q";
                                OPEN642.StartInfo.UseShellExecute = false;
                                OPEN642.StartInfo.RedirectStandardInput = true;
                                OPEN642.Start();

                            }

                        }
                        catch (Exception sixtyfour)
                        {
                            MessageBox.Show(sixtyfour.ToString());
                        }
                    }

                }
                else
                {
                    Process reset1 = new Process();
                    reset1.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\Caleb\reset-all.exe";
                    reset1.StartInfo.Arguments = "/q";
                    reset1.StartInfo.UseShellExecute = false;
                    reset1.StartInfo.RedirectStandardInput = true;
                    reset1.Start();

                }

            }
            catch (Exception reset)
            {
                MessageBox.Show(reset.ToString());
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Restart GPU DRIVER

            WebClient restart = new WebClient();
            restart.DownloadFile("https://cdn.discordapp.com/attachments/781708820803092521/832445757671473182/restart64.exe", "C:\\Windows\\Temp\\restart64.exe");

            Process restart64 = new Process();
            restart64.StartInfo.FileName = "C:\\Windows\\Temp\\restart64.exe";
            restart64.StartInfo.Arguments = "/q";
            restart64.StartInfo.UseShellExecute = false;
            restart64.StartInfo.RedirectStandardInput = true;
            restart64.Start();
            restart64.WaitForExit();

            Process delete64 = new Process();
            delete64.StartInfo.FileName = "cmd.exe";
            delete64.StartInfo.Arguments = @"/c del /f C:\Windows\Temp\restart64.exe";
            delete64.StartInfo.UseShellExecute = false;
            delete64.StartInfo.RedirectStandardInput = true;
            delete64.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            delete64.Start();
            delete64.WaitForExit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //NVCleanstall 1.10   // //https://cdn.discordapp.com/attachments/846483420489056296/869065613862113320/NVCleanstall.exe


            try
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\NVCleanstall.exe"))
                {
                    WebClient NV1 = new WebClient();
                    NV1.DownloadFile("https://cdn.discordapp.com/attachments/846483420489056296/869065613862113320/NVCleanstall.exe", Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\NVCleanstall.exe");

                    Process NVOPEN = new Process();
                    NVOPEN.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\NVCleanstall.exe";
                    NVOPEN.StartInfo.UseShellExecute = false;
                    NVOPEN.StartInfo.RedirectStandardInput = true;
                    NVOPEN.Start();


                }
                else
                {
                    Process NVOPEN = new Process();
                    NVOPEN.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\NVCleanstall.exe";
                    NVOPEN.StartInfo.UseShellExecute = false;
                    NVOPEN.StartInfo.RedirectStandardInput = true;
                    NVOPEN.Start();

                }

            }
            catch (Exception NV)
            {
                MessageBox.Show(NV.ToString());
            }




        }

        private void button13_Click(object sender, EventArgs e)
        {
            //NVSlimmer
            //https://cdn.discordapp.com/attachments/846483420489056296/869066085209616405/NVSlimmer.zip
            try
            {
                if (!File.Exists(Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\NVSlimmer\NVSlimmer.exe"))
                {
                    WebClient SLIM = new WebClient();
                    SLIM.DownloadFile("https://cdn.discordapp.com/attachments/846483420489056296/869066085209616405/NVSlimmer.zip", Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\NVSlimmer.zip");
                    WebClient i7zG = new WebClient();
                    i7zG.DownloadFile("https://cdn.discordapp.com/attachments/846483420489056296/847169213919002684/7zG.exe", "C:\\Windows\\Temp\\7zG.exe");


                    Process extract = new Process();
                    extract.StartInfo.FileName = "C:\\Windows\\Temp\\7zG.exe";
                    extract.StartInfo.Arguments = "x \"" + Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\NVSlimmer.zip" + "\" -o" + Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\NVSlimmer";
                    extract.StartInfo.UseShellExecute = false;
                    extract.StartInfo.RedirectStandardInput = true;
                    extract.Start();
                    extract.WaitForExit();


                    Process SLIMOPEN = new Process();
                    SLIMOPEN.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\NVSlimmer\NVSlimmer.exe";
                    SLIMOPEN.StartInfo.UseShellExecute = false;
                    SLIMOPEN.StartInfo.RedirectStandardInput = true;
                    SLIMOPEN.Start();


                    Process Delete1 = new Process();
                    Delete1.StartInfo.FileName = "cmd.exe";
                    Delete1.StartInfo.Arguments = @"/c del /f C:\Windows\Temp\7zG.exe";
                    Delete1.StartInfo.UseShellExecute = false;
                    Delete1.StartInfo.RedirectStandardInput = true;
                    Delete1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    Delete1.Start();
                    Delete1.WaitForExit();


                }
                else
                {
                    Process SLIMOPEN1 = new Process();
                    SLIMOPEN1.StartInfo.FileName = Environment.GetEnvironmentVariable("AppData") + @"\NvidiaAIO\NVSlimmer\NVSlimmer.exe";
                    SLIMOPEN1.StartInfo.UseShellExecute = false;
                    SLIMOPEN1.StartInfo.RedirectStandardInput = true;
                    SLIMOPEN1.Start();

                }

            }
            catch (Exception nice)
            {
                MessageBox.Show(nice.ToString());
            }


        }
    }
}
