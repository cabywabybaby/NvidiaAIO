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
    public partial class Tweaks : UserControl
    {
        public Tweaks()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Nip less than 457.30

            WebClient NIP = new WebClient();
            NIP.DownloadFile("https://cdn.discordapp.com/attachments/781708820803092521/868907374633689108/CalebBelowNIP.nip", "C:\\Windows\\Temp\\CalebBelowNIP.nip");
            WebClient inspector = new WebClient();
            inspector.DownloadFile("https://cdn.discordapp.com/attachments/781708820803092521/868909170064240710/nvidiaProfileInspector.exe", "C:\\Windows\\Temp\\nvidiaProfileInspector.exe");





            Process NVSTTINGS = new Process();
            NVSTTINGS.StartInfo.FileName = "C:\\Windows\\Temp\\nvidiaProfileInspector.exe";
            NVSTTINGS.StartInfo.Arguments = "C:\\Windows\\Temp\\CalebBelowNIP.nip";
            NVSTTINGS.StartInfo.UseShellExecute = false;
            NVSTTINGS.StartInfo.RedirectStandardInput = true;
            NVSTTINGS.Start();
            NVSTTINGS.WaitForExit();

            Process deleteNIP = new Process();
            deleteNIP.StartInfo.FileName = "cmd.exe";
            deleteNIP.StartInfo.Arguments = @"/c del /f C:\Windows\Temp\CalebBelowNIP.nip";
            deleteNIP.StartInfo.UseShellExecute = false;
            deleteNIP.StartInfo.RedirectStandardInput = true;
            deleteNIP.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            deleteNIP.Start();
            deleteNIP.WaitForExit();

            Process DELinp = new Process();
            DELinp.StartInfo.FileName = "cmd.exe";
            DELinp.StartInfo.Arguments = @"/c del /f C:\Windows\Temp\nvidiaProfileInspector.exe";
            DELinp.StartInfo.UseShellExecute = false;
            DELinp.StartInfo.RedirectStandardInput = true;
            DELinp.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            DELinp.Start();
            DELinp.WaitForExit();




        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Nip above 457.30

            WebClient NIP = new WebClient();
            NIP.DownloadFile("https://cdn.discordapp.com/attachments/781708820803092521/868907389531869245/catAbove.nip", "C:\\Windows\\Temp\\catAbove.nip");
            WebClient inspector = new WebClient();
            inspector.DownloadFile("https://cdn.discordapp.com/attachments/781708820803092521/868909170064240710/nvidiaProfileInspector.exe", "C:\\Windows\\Temp\\nvidiaProfileInspector.exe");





            Process NVSTTINGS = new Process();
            NVSTTINGS.StartInfo.FileName = "C:\\Windows\\Temp\\nvidiaProfileInspector.exe";
            NVSTTINGS.StartInfo.Arguments = "C:\\Windows\\Temp\\catAbove.nip";
            NVSTTINGS.StartInfo.UseShellExecute = false;
            NVSTTINGS.StartInfo.RedirectStandardInput = true;
            NVSTTINGS.Start();
            NVSTTINGS.WaitForExit();

            Process deleteNIP = new Process();
            deleteNIP.StartInfo.FileName = "cmd.exe";
            deleteNIP.StartInfo.Arguments = @"/c del /f C:\Windows\Temp\catAbove.nip";
            deleteNIP.StartInfo.UseShellExecute = false;
            deleteNIP.StartInfo.RedirectStandardInput = true;
            deleteNIP.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            deleteNIP.Start();
            deleteNIP.WaitForExit();

            Process DELinp = new Process();
            DELinp.StartInfo.FileName = "cmd.exe";
            DELinp.StartInfo.Arguments = @"/c del /f C:\Windows\Temp\nvidiaProfileInspector.exe";
            DELinp.StartInfo.UseShellExecute = false;
            DELinp.StartInfo.RedirectStandardInput = true;
            DELinp.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            DELinp.Start();
            DELinp.WaitForExit();


        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Reset Nvidia Settings

            WebClient DefaultSettings = new WebClient();
            DefaultSettings.DownloadFile("https://cdn.discordapp.com/attachments/781708820803092521/832630250042294312/DefaultSettings.bat", "C:\\Windows\\Temp\\DefaultSettings.bat");

            Process revert = new Process();
            revert.StartInfo.FileName = "C:\\Windows\\Temp\\DefaultSettings.bat";
            revert.StartInfo.UseShellExecute = false;
            revert.StartInfo.RedirectStandardInput = true;
            revert.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            revert.Start();
            revert.WaitForExit();
            MessageBox.Show("Defaulted Nvidia settings");

            Process deletebat = new Process();
            deletebat.StartInfo.FileName = "cmd.exe";
            deletebat.StartInfo.Arguments = @"/c del /f C:\Windows\Temp\DefaultSettings.bat";
            deletebat.StartInfo.UseShellExecute = false;
            deletebat.StartInfo.RedirectStandardInput = true;
            deletebat.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            deletebat.Start();
            deletebat.WaitForExit();

        }

        private void button10_Click(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
        {
            //Unrestrict CLock Policy

            WebClient DefaultSettings = new WebClient();
            DefaultSettings.DownloadFile("https://cdn.discordapp.com/attachments/781708820803092521/832642578947113030/UnrestrictClock.bat", "C:\\Windows\\Temp\\UnrestrictClock.bat");

            Process unr = new Process();
            unr.StartInfo.FileName = "C:\\Windows\\Temp\\UnrestrictClock.bat";
            unr.StartInfo.UseShellExecute = false;
            unr.StartInfo.RedirectStandardInput = true;
            unr.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            unr.Start();
            unr.WaitForExit();
            MessageBox.Show("Set an Unrestricted Clock Policy");

            Process deletebat = new Process();
            deletebat.StartInfo.FileName = "cmd.exe";
            deletebat.StartInfo.Arguments = @"/c del /f C:\Windows\Temp\UnrestrictClock.bat";
            deletebat.StartInfo.UseShellExecute = false;
            deletebat.StartInfo.RedirectStandardInput = true;
            deletebat.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            deletebat.Start();
            deletebat.WaitForExit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Restrict Clock Policy

            WebClient DefaultSettings = new WebClient();
            DefaultSettings.DownloadFile("https://cdn.discordapp.com/attachments/781708820803092521/832642584744558683/ZRestrictCock.bat", "C:\\Windows\\Temp\\ZRestrictCock.bat");

            Process unr = new Process();
            unr.StartInfo.FileName = "C:\\Windows\\Temp\\ZRestrictCock.bat";
            unr.StartInfo.UseShellExecute = false;
            unr.StartInfo.RedirectStandardInput = true;
            unr.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            unr.Start();
            unr.WaitForExit();
            MessageBox.Show("Set Restricted Clock Policy");

            Process deletebat = new Process();
            deletebat.StartInfo.FileName = "cmd.exe";
            deletebat.StartInfo.Arguments = @"/c del /f C:\Windows\Temp\ZRestrictCock.bat";
            deletebat.StartInfo.UseShellExecute = false;
            deletebat.StartInfo.RedirectStandardInput = true;
            deletebat.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            deletebat.Start();
            deletebat.WaitForExit();
        }

        

        private void button15_Click_1(object sender, EventArgs e)
        {
            // Block Host File telemetry

           










            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //launch Control Panel

            // C:\Program Files\NVIDIA Corporation\Control Panel Client

            Process Cont = new Process();
            Cont.StartInfo.FileName = "C:\\Program Files\\Nvidia Corporation\\Control Panel Client\\nvcplui.exe";
            Cont.StartInfo.UseShellExecute = false;
            Cont.StartInfo.RedirectStandardInput = true;
            Cont.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Cont.Start();
            

        }

        private void button11_Click(object sender, EventArgs e)
        {

            //Other nvidia settings
            MessageBox.Show("warning. This will restart your GPU driver 2-3 times");


            WebClient LAZY = new WebClient();
           LAZY.DownloadFile("https://cdn.discordapp.com/attachments/846483420489056296/869071188863885322/TooLazy.bat", "C:\\Windows\\Temp\\TooLazy.bat");

            Process yo = new Process();
            yo.StartInfo.FileName = "C:\\Windows\\Temp\\TooLazy.bat";
            yo.StartInfo.UseShellExecute = false;
            yo.StartInfo.RedirectStandardInput = true;
            yo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            yo.Start();
            yo.WaitForExit();
            

            Process deletebat = new Process();
            deletebat.StartInfo.FileName = "cmd.exe";
            deletebat.StartInfo.Arguments = @"/c del /f C:\Windows\Temp\TooLazy.bat";
            deletebat.StartInfo.UseShellExecute = false;
            deletebat.StartInfo.RedirectStandardInput = true;
            deletebat.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            deletebat.Start();
            deletebat.WaitForExit();

            RegistryKey NVTweak = Registry.LocalMachine.CreateSubKey(@"System\CurrentControlSet\Services\nvlddmkm\Global\NVTweak", RegistryKeyPermissionCheck.ReadWriteSubTree);
            RegistryKey CP = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Nvidia Corporation\Global\NVTweak", RegistryKeyPermissionCheck.ReadWriteSubTree);
            CP.SetValue("Gestalt", "1", RegistryValueKind.DWord);
            NVTweak.SetValue("RmProfilingAdminOnly", "0", RegistryValueKind.DWord);
            NVTweak.SetValue("NvDevToolsVisible", "1", RegistryValueKind.DWord);
            NVTweak.SetValue("NvCplPhysxAuto", "0", RegistryValueKind.DWord);

            WebClient restart = new WebClient();
            restart.DownloadFile("https://cdn.discordapp.com/attachments/781708820803092521/832445757671473182/restart64.exe", "C:\\Windows\\Temp\\restart64.exe");

            Process restart64 = new Process();
            restart64.StartInfo.FileName = "C:\\Windows\\Temp\\restart64.exe";
            restart64.StartInfo.Arguments = "/q";
            restart64.StartInfo.UseShellExecute = false;
            restart64.StartInfo.RedirectStandardInput = true;
            restart64.Start();
            restart64.WaitForExit();




            CP.SetValue("Gestalt", "513", RegistryValueKind.DWord);


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



            MessageBox.Show("Applied Settings");












            // nvidia settings besides main ones that the .nip does

            // dwords to add         NvDevToolsVisible value 1        NvCplPhysxAuto value 0 
            // RegistryKey Cclass = Registry.LocalMachine.CreateSubKey(@"System\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000", RegistryKeyPermissionCheck.ReadWriteSubTree);
            ////   RegistryKey NVTweak = Registry.LocalMachine.CreateSubKey(@"System\CurrentControlSet\Services\nvlddmkm\Global\NVTweak", RegistryKeyPermissionCheck.ReadWriteSubTree);
            //  RegistryKey CP = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Nvidia Corporation\Global\NVTweak", RegistryKeyPermissionCheck.ReadWriteSubTree);
            //  RegistryKey Coler = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Nvidia Corporation\Global\NVTweak\Devices\344251435-0\Color", RegistryKeyPermissionCheck.ReadWriteSubTree);

            // Cclass.SetValue("_User_Video_Active_Device", "2147483648", RegistryValueKind.DWord);
            // Cclass.SetValue("_User_SUB0_DFP2_VAL_Brightness", "0", RegistryValueKind.DWord);
            //  Cclass.SetValue("_User_SUB0_DFP2_XEN_Brightness", "2147483649", RegistryValueKind.DWord);
            //  Cclass.SetValue("_User_SUB0_DFP2_VAL_RGB_Gamma_B", "100", RegistryValueKind.DWord);
            //  Cclass.SetValue("_User_SUB0_DFP2_XEN_RGB_Gamma_B", "2147483649", RegistryValueKind.DWord);
            //   Cclass.SetValue("_User_SUB0_DFP2_VAL_Saturation", "100", RegistryValueKind.DWord);
            //   Cclass.SetValue("_User_SUB0_DFP2_XEN_Saturation", "2147483649", RegistryValueKind.DWord);
            //   Cclass.SetValue("_User_SUB0_DFP2_VAL_Contrast", "100", RegistryValueKind.DWord);
            //   Cclass.SetValue("_User_SUB0_DFP2_XEN_Contrast", "2147483649", RegistryValueKind.DWord);
            ////   Cclass.SetValue("_User_SUB0_DFP2_VAL_RGB_Gamma_R", "100", RegistryValueKind.DWord);
            //   Cclass.SetValue("_User_SUB0_DFP2_XEN_RGB_Gamma_R", "2147483649", RegistryValueKind.DWord);
            //   Cclass.SetValue("_User_SUB0_DFP2_XALG_Color_Range", new byte[] { 0x0, 0x0, 0x0, 0x8 }, RegistryValueKind.Binary);
            //umd.SetValue("TFQ", new byte[] { 32, 0x0 }, RegistryValueKind.Binary);

            //CP.SetValue("Gestalt", "1", RegistryValueKind.DWord);
            //after restart run CP.SetValue("Gestalt", "513", RegistryValueKind.DWord);
            //NVTweak.SetValue("RmProfilingAdminOnly", "0", RegistryValueKind.DWord);







        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Preemption
            // HKEY_LOCAL_MACHINE\SOFTWARE\NVAIO
            //nvlddmkm.SetValue("LogWarningEntries", "0", RegistryValueKind.DWord);
            RegistryKey nvlddmkm2 = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\NVAIO", RegistryKeyPermissionCheck.ReadWriteSubTree);
            RegistryKey nvlddmkm = Registry.LocalMachine.CreateSubKey(@"System\CurrentControlSet\Services\nvlddmkm", RegistryKeyPermissionCheck.ReadWriteSubTree);
            RegistryKey Scheduler = Registry.LocalMachine.CreateSubKey(@"System\CurrentControlSet\Control\GraphicsDrivers\Scheduler", RegistryKeyPermissionCheck.ReadWriteSubTree);
            try
            {
                
                if (nvlddmkm2.GetValue("Preemption") != null)
                {
                    if (nvlddmkm2.GetValue("Preemption").ToString() == "1")
                    {
                        if (MessageBox.Show("Preemption is already Disabled. Do you want to enable?", "Preemption", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            nvlddmkm2.DeleteValue("Preemption");
                            nvlddmkm.DeleteValue("PerfAnalyzeMidBufferPreemption");
                            nvlddmkm.DeleteValue("EnableMidBufferPreemption");
                            nvlddmkm.DeleteValue("EnableAsyncMidBufferPreemption");
                            nvlddmkm.DeleteValue("DisablePreemption");
                            nvlddmkm.DeleteValue("DisableCudaContextPreemption");
                            Scheduler.DeleteValue("EnablePreemption");




                            MessageBox.Show("Preemption Dwords have been deleted.", "Preemption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    nvlddmkm2.SetValue("Preemption", "1", RegistryValueKind.DWord);
                    Scheduler.SetValue("EnablePreemption", "0", RegistryValueKind.DWord);
                    nvlddmkm.SetValue("PerfAnalyzeMidBufferPreemption", "0", RegistryValueKind.DWord);
                    nvlddmkm.SetValue("EnableMidBufferPreemption", "0", RegistryValueKind.DWord);
                    nvlddmkm.SetValue("EnableAsyncMidBufferPreemption", "1", RegistryValueKind.DWord);
                    nvlddmkm.SetValue("DisablePreemption", "1", RegistryValueKind.DWord);
                    nvlddmkm.SetValue("DisableCudaContextPreemption", "1", RegistryValueKind.DWord);
                    MessageBox.Show("Disabled Preemption.", "Preemption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }

        private void Tweaks_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey nvlddmkm1 = Registry.LocalMachine.CreateSubKey(@"System\CurrentControlSet\Services\nvlddmkm", RegistryKeyPermissionCheck.ReadWriteSubTree);
                if (nvlddmkm1.GetValue("DisableWriteCombining") != null)
                {
                    if (nvlddmkm1.GetValue("DisableWriteCombining").ToString() == "1")
                    {
                        if (MessageBox.Show("WriteCombining is already Disabled. Do you want to revert the setting?", "WriteCombining", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            nvlddmkm1.DeleteValue("DisableWriteCombining");
                            MessageBox.Show("DisableWriteCombining has been reverted", "WriteCombining", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    nvlddmkm1.SetValue("DisableWriteCombining", "1", RegistryValueKind.DWord);
                    MessageBox.Show("Disabled WriteCombining.", "WriteCombining", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // HDCP
            //credit TimeCard
            RegistryKey Cclass = Registry.LocalMachine.CreateSubKey(@"System\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000", RegistryKeyPermissionCheck.ReadWriteSubTree);
            RegistryKey nvlddmkm2 = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\NVAIO", RegistryKeyPermissionCheck.ReadWriteSubTree);
            try
            {
               
                if (nvlddmkm2.GetValue("HDCP") != null)
                {
                    if (nvlddmkm2.GetValue("HDCP").ToString() == "1")
                    {
                        if (MessageBox.Show("HDCP is already Disabled. Do you want to revert??", "HDCP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            nvlddmkm2.DeleteValue("HDCP");
                            Cclass.DeleteValue("RMHdcpKeyglobZero");

                            MessageBox.Show("HCDCP has been enabled", "HDCP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    nvlddmkm2.SetValue("HDCP", "1", RegistryValueKind.DWord);
                    Cclass.SetValue("RMHdcpKeyglobZero", "1", RegistryValueKind.DWord);

                    MessageBox.Show("Disabled HDCP.", "HDCP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void button14_Click(object sender, EventArgs e)
        {
            // logging
            RegistryKey nvlddmkm2 = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\NVAIO", RegistryKeyPermissionCheck.ReadWriteSubTree);
            RegistryKey nvlddmkm = Registry.LocalMachine.CreateSubKey(@"System\CurrentControlSet\Services\nvlddmkm", RegistryKeyPermissionCheck.ReadWriteSubTree);
            //"LogWarningEntries"=dword:00000000
           // "LogPagingEntries" = dword:00000000
           // "LogEventEntries" = dword:00000000
            // "LogErrorEntries" = dword:00000000

            try
            {

                if (nvlddmkm2.GetValue("Logging") != null)
                {
                    if (nvlddmkm2.GetValue("Logging").ToString() == "1")
                    {
                        if (MessageBox.Show("Logging is already Disabled. Do you want to revert?", "Logging", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            nvlddmkm2.DeleteValue("Logging");
                            nvlddmkm.DeleteValue("LogWarningEntries");
                            nvlddmkm.DeleteValue("LogPagingEntries");
                            nvlddmkm.DeleteValue("LogEventEntries");
                            nvlddmkm.DeleteValue("LogErrorEntries");



                            MessageBox.Show("Logging has been reverted to default.", "Logging", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    nvlddmkm2.SetValue("Logging", "1", RegistryValueKind.DWord);
                    nvlddmkm.SetValue("LogWarningEntries", "0", RegistryValueKind.DWord);
                    nvlddmkm.SetValue("LogPagingEntries", "0", RegistryValueKind.DWord);
                    nvlddmkm.SetValue("LogEventEntries", "0", RegistryValueKind.DWord);
                    nvlddmkm.SetValue("LogErrorEntries", "0", RegistryValueKind.DWord);

                    MessageBox.Show("Disabled Logging.", "Logging", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            // PowerMizer Dwords (kboost)

            RegistryKey Cclass = Registry.LocalMachine.CreateSubKey(@"System\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000", RegistryKeyPermissionCheck.ReadWriteSubTree);
            RegistryKey nvlddmkm2 = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\NVAIO", RegistryKeyPermissionCheck.ReadWriteSubTree);
            //"PerfLevelSrc"=dword:00002222
            //"EnableMClkSlowdown" = dword:00000000
            // "EnableNVClkSlowdown" = dword:00000000
               // "PowerMizerLevelAC" = dword:00000001
             //"PowerMizerEnable" = dword:00000001
            //"PowerMizerLevel" = dword:00000001
           //"EnableCoreSlowdown" = dword:00000000
            try
            {

                if (nvlddmkm2.GetValue("PowerMizer") != null)
                {
                    if (nvlddmkm2.GetValue("PowerMizer").ToString() == "1")
                    {
                        if (MessageBox.Show("PowerMizer Dwords have already been enabled. Do you want to Revert them?", "PowerMizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            nvlddmkm2.DeleteValue("PowerMizer");
                            Cclass.DeleteValue("PerfLevelSrc");
                            Cclass.DeleteValue("EnableMClkSlowdown");
                            Cclass.DeleteValue("EnableNVClkSlowdown");
                            Cclass.DeleteValue("PowerMizerLevelAC");
                            Cclass.DeleteValue("PowerMizerEnable");
                            Cclass.DeleteValue("PowerMizerLevel");
                            Cclass.DeleteValue("EnableCoreSlowdown");

                            MessageBox.Show("PowerMizer Dwords have been deleted", "PowerMizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    nvlddmkm2.SetValue("PowerMizer", "1", RegistryValueKind.DWord);
                    Cclass.SetValue("EnableMClkSlowdown", "0", RegistryValueKind.DWord);
                    Cclass.SetValue("EnableNVClkSlowdown", "0", RegistryValueKind.DWord);
                    Cclass.SetValue("PowerMizerLevelAC", "1", RegistryValueKind.DWord);
                    Cclass.SetValue("PowerMizerEnable", "1", RegistryValueKind.DWord);
                    Cclass.SetValue("PowerMizerLevel", "1", RegistryValueKind.DWord);
                    Cclass.SetValue("EnableCoreSlowdown", "0", RegistryValueKind.DWord);
                    Cclass.SetValue("PerfLevelSrc", "8738", RegistryValueKind.DWord);

                    MessageBox.Show("Imported PowerMizer Dwords.", "PowerMizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Disable Scaling // needs fix //
            WebClient DefaultSettings = new WebClient();
            DefaultSettings.DownloadFile("https://cdn.discordapp.com/attachments/833399334019530814/845056590972452870/real_display_scaling.bat", "C:\\Windows\\Temp\\real_display_scaling.bat");

            Process unr = new Process();
            unr.StartInfo.FileName = "C:\\Windows\\Temp\\real_display_scaling.bat";
            unr.StartInfo.UseShellExecute = false;
            unr.StartInfo.RedirectStandardInput = true;
            unr.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            unr.Start();
            unr.WaitForExit();
            MessageBox.Show("No Scaling has been succesfully set!", "Real Scaling", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Process deletebat = new Process();
            deletebat.StartInfo.FileName = "cmd.exe";
            deletebat.StartInfo.Arguments = @"/c del /f C:\Windows\Temp\real_display_scaling.bat";
            deletebat.StartInfo.UseShellExecute = false;
            deletebat.StartInfo.RedirectStandardInput = true;
            deletebat.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            deletebat.Start();
            deletebat.WaitForExit();


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Misc Dwords
            RegistryKey Cclass = Registry.LocalMachine.CreateSubKey(@"System\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000", RegistryKeyPermissionCheck.ReadWriteSubTree);
            RegistryKey nvlddmkm2 = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\NVAIO", RegistryKeyPermissionCheck.ReadWriteSubTree);
            RegistryKey nvlddmkm = Registry.LocalMachine.CreateSubKey(@"System\CurrentControlSet\Services\nvlddmkm", RegistryKeyPermissionCheck.ReadWriteSubTree);
            RegistryKey Scheduler = Registry.LocalMachine.CreateSubKey(@"System\CurrentControlSet\Control\GraphicsDrivers\Scheduler", RegistryKeyPermissionCheck.ReadWriteSubTree);
            RegistryKey NVTweak = Registry.LocalMachine.CreateSubKey(@"System\CurrentControlSet\Services\nvlddmkm\Global\NVTweak", RegistryKeyPermissionCheck.ReadWriteSubTree);

            try
            {

                if (nvlddmkm2.GetValue("MISC") != null)
                {
                    if (nvlddmkm2.GetValue("MISC").ToString() == "1")
                    {
                        if (MessageBox.Show("Dwords Have already been applied, Do you want to revert?", "Misc", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            nvlddmkm2.DeleteValue("MISC");
                            nvlddmkm.DeleteValue("EnableMemoryTiling");
                            nvlddmkm.DeleteValue("EnableSystemMemoryTiling");
                            Cclass.DeleteValue("EnableTiledDisplay");
                            Cclass.DeleteValue("RmDisableHwFaultBuffer");
                            Cclass.DeleteValue("EnableRuntimePowerManagement");
                            Cclass.DeleteValue("DisableOverlay");
                            NVTweak.DeleteValue("DisplayPowerSaving");




                            MessageBox.Show("Dwords Deleted.", "Misc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    nvlddmkm2.SetValue("MISC", "1", RegistryValueKind.DWord);
                    nvlddmkm.SetValue("EnableMemoryTiling", "0", RegistryValueKind.DWord);
                    nvlddmkm.SetValue("EnableSystemMemoryTiling", "0", RegistryValueKind.DWord);
                    Cclass.SetValue("EnableTiledDisplay", "0", RegistryValueKind.DWord);
                    Cclass.SetValue("RmDisableHwFaultBuffer", "1", RegistryValueKind.DWord);
                    Cclass.SetValue("EnableRuntimePowerManagement", "0", RegistryValueKind.DWord);
                    Cclass.SetValue("DisableOverlay", "1", RegistryValueKind.DWord);
                    NVTweak.SetValue("DisplayPowerSaving", "0", RegistryValueKind.DWord);



                    MessageBox.Show("Added Dwords.", "Misc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }





        }
    }
}
