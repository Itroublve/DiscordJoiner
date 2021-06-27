using Leaf.xNet;
using System;
using System.IO;
using System.Linq;
using System.Security.Authentication;
using System.Threading.Tasks;
using Discord.WebSocket;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Http;
using System.Net;

namespace Tokens.rip_Token_Manager
{
    #region Header and setting
    public static class Request
    {
        public static void Settings(this HttpRequest r, string Authorization)
        {
            r.IgnoreProtocolErrors = true;
            r.KeepTemporaryHeadersOnRedirect = false;
            r.ClearAllHeaders();
            r.EnableMiddleHeaders = false;
            r.AllowEmptyHeaderValues = false;
            r.AddHeader("Accept", "*/*");
            r.AddHeader("Accept-Encoding", "gzip, deflate, br");
            r.AddHeader("Accept-Language", "en-US");
            r.AddHeader("Authorization", Authorization);
            r.AddHeader("Connection", "keep-alive");
            r.AddHeader("Cookie", $"__cfduid={TokenSettings.RandomCookie(43)}; __dcfduid={TokenSettings.RandomCookie(32)}; locale=en-US");
            r.AddHeader("DNT", "1");
            r.AddHeader("origin", "https://discord.com");
            r.AddHeader("Referer", "https://discord.com/channels/@me");
            r.AddHeader("TE", "Trailers");
            r.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) discord/1.0.9001 Chrome/83.0.4103.122 Electron/9.3.5 Safari/537.36");
            r.AddHeader("X-Super-Properties", "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiRGlzY29yZCBDbGllbnQiLCJyZWxlYXNlX2NoYW5uZWwiOiJzdGFibGUiLCJjbGllbnRfdmVyc2lvbiI6IjEuMC45MDAxIiwib3NfdmVyc2lvbiI6IjEwLjAuMTkwNDIiLCJvc19hcmNoIjoieDY0Iiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiY2xpZW50X2J1aWxkX251bWJlciI6ODMwNDAsImNsaWVudF9ldmVudF9zb3VyY2UiOm51bGx9");
            r.SslProtocols = SslProtocols.Tls12;
        }
    }
    #endregion

    public class TokenSettings
    {
        #region Gen RandomString Cookie
        private static Random random = new Random();
        public static string RandomCookie(int a)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789"; //Chars to choose from
            return new string(Enumerable.Repeat(chars, a)
              .Select(s => s[random.Next(s.Length)]).ToArray()); //Enumrate random char
        }
        #endregion
        #region Convert Image To Base64
        public static string GetBase64Data(string _Img)
        {
            if (_Img.ToLower().EndsWith(".jpg"))
            {
                return "data:image/jpg;base64," + Convert.ToBase64String(File.ReadAllBytes(_Img));
            }
            else if (_Img.ToLower().EndsWith(".png"))
            {
                return "data:image/png;base64," + Convert.ToBase64String(File.ReadAllBytes(_Img));
            }
            else
            {
                return null;
            }
        }
        #endregion
        #region Send Friend Request
        public static async Task SendFriendReq(string Username, string Token, bool proxied, string proxy = null)
        {
            if (Username.Contains("#"))
            {
                try
                {
                    HttpRequest r = new HttpRequest();
                    r.Settings(Token);
                    if (proxied)
                    {
                        r.Proxy = HttpProxyClient.Parse(proxy);
                    }
                    r.Post($"https://discord.com/api/v{new Random().Next(6, 9)}/users/@me/relationships", $"{{\"username\": \"{Username.Split('#')[0]}\", \"discriminator\": \"{Username.Split('#')[1]}\"}}", "application/json");
                }
                catch
                { }
            }
            else
            {
                try
                {
                    HttpRequest r = new HttpRequest();
                    r.Settings(Token);
                    if (proxied)
                    {
                        r.Proxy = HttpProxyClient.Parse(proxy);
                    }
                    r.Put($"https://discord.com/api/v{new Random().Next(6, 9)}/users/@me/relationships/{Username}", "{}", "application/json");
                }
                catch
                {
                }
            }
        }
        #endregion
        #region Block Friend
        public static async Task BlockFriend(string Username, string Token, bool proxied, string proxy)
        {
            try
            {
                HttpRequest r = new HttpRequest();
                if (proxied)
                {
                    r.Proxy = HttpProxyClient.Parse(proxy);
                }
                r.Settings(Token);
                r.Put($"https://discord.com/api/v{new Random().Next(6, 9)}/users/@me/relationships/{Username}", "{\"type\":2}", "application/json");
                r?.Dispose();
            }
            catch
            { }
        }
        #endregion
        #region Remove Friend
        public static async Task RemoveFriend(string Username, string Token, bool proxied, string proxy)
        {
            try
            {
                HttpRequest r = new HttpRequest();
                if (proxied)
                {
                    r.Proxy = HttpProxyClient.Parse(proxy);
                }
                r.Settings(Token);
                r.Delete($"https://discord.com/api/v{new Random().Next(6, 9)}/users/@me/relationships/{Username}");
            }
            catch { }
        }
        #endregion
        #region Change Profile Picture Of Tokens
        public static async Task ChangePfp(string FilePath, string Token, bool proxied, string proxy = null)
        {
            string ImgBase64 = GetBase64Data(FilePath);
            if (ImgBase64 != null)
            {
                try
                {
                    HttpRequest r = new HttpRequest();
                    r.Settings(Token);
                    if (proxied)
                    {
                        r.Proxy = HttpProxyClient.Parse(proxy);
                    }
                    r.Patch($"https://discord.com/api/v{new Random().Next(6, 9)}/users/@me", $"{{\"avatar\": \"{ImgBase64}\"}}", "application/json");
                }
                catch { }
            }
            else
            {
                MessageBox.Show("Unsupported Image Format!");
            }
        }
        #endregion
        #region Send Token Online
        public static async void SendOnline(string _Token)
        {
            var _UserToken = new DiscordSocketClient(new DiscordSocketConfig
            {
                LogLevel = Discord.LogSeverity.Debug
            });
            try
            {
                await _UserToken.LoginAsync(0, _Token).ConfigureAwait(false);
                await _UserToken.StartAsync().ConfigureAwait(false);
                await _UserToken.SetActivityAsync(new Discord.Game("Tokens.rip", Discord.ActivityType.Playing, Discord.ActivityProperties.Join, "Cheap Discord Tokens & Members"));
            }
            catch
            {
                return;
            }
        }
        #endregion
        #region Join Guild
        public static async void JoinServer(string Token, string invite, bool proxied, string proxy, Color btnColor)
        {
            try
            {
                HttpRequest r = new HttpRequest();
                r.Settings(Token);
                if (proxied)
                {
                    r.Proxy = HttpProxyClient.Parse(proxy);
                }
                r.Post($"https://discord.com/api/v{new Random().Next(6, 9)}/invites/" + invite);
                if (btnColor == Color.FromArgb(105, 105, 205))
                {
                    var request = new HttpClient();
                    request.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", Token);
                    try
                    {
                        r.Get($"https://discord.com/api/v{new Random().Next(6, 9)}/invites/{invite}");
                        dynamic info = JsonConvert.DeserializeObject(r.Response.ToString());
                        string guildId = info.guild.id.ToString();
                        await Task.Delay(500);
                        var response = await request.GetAsync($"https://discord.com/api/v{new Random().Next(6, 9)}/guilds/{guildId}/member-verification?with_guild=false");
                        dynamic form = JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                        string msg = form.form_fields.ToString();
                        msg = msg.Replace("\n", "").Replace("\r", "");
                        msg = msg.Replace("}]", "");
                        string date = response.Content.ReadAsStringAsync().Result.Substring(13, 32);
                        var bypass = new HttpRequest();
                        bypass.Settings(Token);
                        bypass.Put($"https://discord.com/api/v{new Random().Next(6, 9)}/guilds/{guildId}/requests/@me", $"{{\"version\":\"{date}\",\"form_fields\":{msg},\"response\":true}}]}}", "application/json");
                    }
                    catch { }
                }
            }
            catch
            {
            }
        }
        #endregion
        #region Leave Guild
        public static async void LeaveServer(string Token, string guildId, bool proxied, string proxy)
        {
            try
            {
                var pain = new HttpRequest();
                pain.Settings(Token);
                if (proxied)
                    pain.Proxy = HttpProxyClient.Parse(proxy);
                pain.Delete($"https://discord.com/api/v{new Random().Next(6, 9)}/users/@me/guilds/{guildId}");
            }
            catch { }
        }
        #endregion
        #region Change Username
        public static async void ChangeUsername(string Token, string Password, string Username, bool proxied, string proxy = null)
        {
            try
            {
                var r = new HttpRequest();
                r.Settings(Token);
                if (proxied)
                {
                    r.Proxy = HttpProxyClient.Parse(proxy);
                }
                r.Patch($"https://discord.com/api/v{new Random().Next(6,9)}/users/@me", $"{{\"username\":\"{Username}\",\"password\":\"{Password}\"}}", "application/json");
                //if (r.Response.ToString().Contains("PASSWORD_DOES_NOT_MATCH")) new CustomMsgBox("Incorrect Password...", "Nickname").Show();
                //else if (r.Response.ToString().Contains("DISCRIMINATOR_TAKEN")) new CustomMsgBox("This username is commonly used.", "Nickname").Show();
            }
            catch
            { }
        }
        #endregion
        #region Check Token
        public static async Task<string> CheckToken(string Token, string Proxy)
        {
            try
            {
                var r = new HttpRequest();
                r.Settings(Token);
                if (!string.IsNullOrEmpty(Proxy)) r.Proxy = HttpProxyClient.Parse(Proxy);
                r.AddHeader("Content-Type", "application/json");
                r.IgnoreProtocolErrors = false;
                r.Get($"https://discord.com/api/v{new Random().Next(6,9)}/users/@me/guilds");
                return Token;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region Get Users
        //public static async void GetUser(string _Token)
        //{
        //    var _UserToken = new DiscordSocketClient(new DiscordSocketConfig
        //    {
        //        LogLevel = Discord.LogSeverity.Debug
        //    });
        //    try
        //    {
        //        await _UserToken.LoginAsync(0, _Token).ConfigureAwait(false);
        //        await _UserToken.StartAsync().ConfigureAwait(false);
        //        await _UserToken.SetActivityAsync(new Discord.Game("Tokens.rip", Discord.ActivityType.Playing, Discord.ActivityProperties.Join, "Cheap Discord Tokens & Members"));
        //        await _UserToken.GetGuild(854518247504347146).DownloadUsersAsync();
        //        if (_UserToken.GetGuild(854518247504347146).DownloaderPromise.IsCompleted)
        //        {
        //            foreach (var user in _UserToken.GetGuild(854518247504347146).Users)
        //            {
        //                MessageBox.Show(user.Id.ToString());
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        return;
        //    }
        //}
        #endregion
    }
}
