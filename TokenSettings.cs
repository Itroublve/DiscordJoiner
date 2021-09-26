using Leaf.xNet;
using System;
using System.IO;
using System.Linq;
using System.Security.Authentication;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Http;
using Discord.WebSocket;
using System.Threading;
using System.Runtime.InteropServices;
using WebSocketSharp.Net;
using WebSocketSharp;
using System.Text;

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
            r.AddHeader("Cookie", $"__dcfduid={TokenSettings.RandomCookie(43)}; __sdcfduid={TokenSettings.RandomCookie(32)}; locale=en-US");
            r.AddHeader("DNT", "1");
            r.AddHeader("Origin", $"{TokenSettings.domains[new Random(Guid.NewGuid().GetHashCode()).Next(TokenSettings.domains.Length)]}");
            r.AddHeader("X-Fingerprint", $"{TokenSettings.RandomNumber(18)}.{TokenSettings.RandomCookie(27)}");
            r.AddHeader("Referer", $"{TokenSettings.domains[new Random(Guid.NewGuid().GetHashCode()).Next(TokenSettings.domains.Length)]}/channels/@me");
            r.AddHeader("TE", "Trailers");
            r.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) discord/1.0.9001 Chrome/83.0.4103.122 Electron/9.3.5 Safari/537.36");
            r.AddHeader("X-Super-Properties", "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiRGlzY29yZCBDbGllbnQiLCJyZWxlYXNlX2NoYW5uZWwiOiJzdGFibGUiLCJjbGllbnRfdmVyc2lvbiI6IjEuMC45MDAxIiwib3NfdmVyc2lvbiI6IjEwLjAuMTkwNDIiLCJvc19hcmNoIjoieDY0Iiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiY2xpZW50X2J1aWxkX251bWJlciI6ODMwNDAsImNsaWVudF9ldmVudF9zb3VyY2UiOm51bGx9");
            r.SslProtocols = SslProtocols.Tls12;
        }
    }
    #endregion

    public class TokenSettings
    {
        #region GUI
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        #endregion
        #region Domains & Cookie
        public static string[] domains =
        {
            "https://discord.com",
            "https://discordapp.com",
            "https://ptb.discord.com",
            "https://canary.discord.com",
            "https://canary.discordapp.com"
        };
        public static Random random = new Random(Guid.NewGuid().GetHashCode());
        public static string RandomCookie(int a)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789"; //Chars to choose from
            return new string(Enumerable.Repeat(chars, a)
              .Select(s => s[random.Next(s.Length)]).ToArray()); //Enumrate random char
        }
        public static string RandomNumber(int a)
        {
            const string nr = "01234456789";
            return new string(Enumerable.Repeat(nr, a)
                .Select(x => x[random.Next(x.Length)]).ToArray());
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
                    r.Post($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(6, 9)}/users/@me/relationships", $"{{\"username\": \"{Username.Split('#')[0]}\", \"discriminator\": \"{Username.Split('#')[1]}\"}}", "application/json");
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
                    r.Put($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(6, 9)}/users/@me/relationships/{Username}", "{}", "application/json");
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
                r.Put($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(6, 9)}/users/@me/relationships/{Username}", "{\"type\":2}", "application/json");
                r?.Dispose();
            }
            catch
            { }
        }
        #endregion
        #region Remove Friend
        public static async Task RemoveFriend(string Username, string Token, bool proxied, string proxy)
        {
            HttpRequest r = new HttpRequest();
            if (proxied)
            {
                r.Proxy = HttpProxyClient.Parse(proxy);
            }
            r.Settings(Token);
            r.Delete($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(6, 9)}/users/@me/relationships/{Username}");
        }
        #endregion
        #region Change Profile Picture of Tokens
        public static async Task ChangePfp(string FilePath, string Token, bool proxied, string proxy = null)
        {
            string ImgBase64 = GetBase64Data(FilePath);
            if (ImgBase64 != null)
            {
                HttpRequest r = new HttpRequest();
                try
                {
                    r.Settings(Token);
                    if (proxied)
                        r.Proxy = HttpProxyClient.Parse(proxy);
                    r.Patch($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(6, 9)}/users/@me", $"{{\"avatar\": \"{ImgBase64}\"}}", "application/json");
                }
                catch
                { }
            }
            else
            {
                MessageBox.Show("Unsupported Image Format!");
            }
        }
        #endregion
        #region WSS Requests
        #region DiscordConfig
        public static DiscordSocketClient _UserToken = new DiscordSocketClient(new DiscordSocketConfig
        {
            LogLevel = Discord.LogSeverity.Debug
        });
        #endregion
        #region Send Token Online
        public static async Task SendOnline(string _Token)
        {
            #region
            //try
            //{
            //    await _UserToken.LoginAsync(0, _Token).ConfigureAwait(false);
            //    await _UserToken.StartAsync().ConfigureAwait(false);
            //    await _UserToken.SetActivityAsync(new Discord.Game("Tokens.rip", Discord.ActivityType.Playing, Discord.ActivityProperties.Join, "Cheap Discord Tokens & Members"));
            //}
            //catch
            //{
            //    return;
            //}
            #endregion 
            using (var WebServerWSS = new WebSocket($"wss://gateway.discord.gg/?v=9&encoding=json"))
            {
                string WssResponse = "Still null";
                string json = @"{
        'op': 2,
        'd': {
                    'token': 'ODkwOTE3MTQ3MjU2MTcyNTY3.YU2xTA.3xwynDmpArqjPeu0K6TNK-tHGI8',
            'properties': {
                        '$os': 'Windows',
                '$browser': 'Chrome',
                '$device': 'Android Device'
            },
            'presence': {
                        'game': 'fkn',
                'status': 'online',
                'since': 0,
                'afk': False
            }
                },
        's': None,
        't': None
        }";
            WebServerWSS.OnMessage += (sender, e) =>
                {
                    MessageBox.Show(e.Data);
                    WssResponse = e.Data;
                };
                WebServerWSS.OnOpen += (sender, e) =>
                {
                    MessageBox.Show(json);
                    WebServerWSS.Send(json);
                };
                WebServerWSS.OnClose += (sender, e) =>
                {
                    Console.WriteLine(e.Code);
                };
                WebServerWSS.OnError += (sender, e) =>
                {
                    Console.WriteLine(e.Message);
                };
                WebServerWSS.Connect();
                MessageBox.Show(WssResponse + " This is working now?");
                //dynamic ResponseJson = JsonConvert.DeserializeObject(WssResponse);
                //Console.WriteLine(ResponseJson);
                //int sleep = ResponseJson.d.heartbeat_interval;
                //Console.WriteLine(WssResponse);
                //Console.Write(sleep);
            }
            #region
            //HttpListener httpListener = new HttpListener();
            //httpListener.Prefixes.Add($"wss://gateway.discord.gg/?v={new Random(Guid.NewGuid().GetHashCode()).Next(6, 9)}&encoding=json");
            //httpListener.Start();
            //HttpListenerContext ctx = await httpListener.GetContextAsync();
            //if (ctx.Request.IsWebSocketRequest)
            //{
            //    HttpListenerWebSocketContext wssCtx = await ctx.AcceptWebSocketAsync(null);
            //    WebSocket webSocket = wssCtx.WebSocket;
            //    const int maxSize = 1024;
            //    byte[] rBuffer = new byte[maxSize];
            //    while (webSocket.State == WebSocketState.Open) 
            //    {
            //        WebSocketReceiveResult receiveResult = await webSocket.ReceiveAsync(new ArraySegment<byte>(rBuffer), CancellationToken.None);
            //        int count = receiveResult.Count;
            //        while (!receiveResult.EndOfMessage)
            //        {
            //            receiveResult = await webSocket.ReceiveAsync(new ArraySegment<byte>(rBuffer, count, maxSize - count), CancellationToken.None);
            //            count += receiveResult.Count;
            //        }
            //        var receivedMessage = Encoding.UTF8.GetString(rBuffer, 0, count);
            //        MessageBox.Show(receivedMessage);
            //        ArraySegment<byte> buffer = new ArraySegment<byte>(Encoding.UTF8.GetBytes("x"));
            //    }
            //}
            #endregion
        }
        #endregion
        #region Join VC
        public static async void JoinVoiceAsync()
        {
        }
        #endregion
            #region Leave VC
        public static async void LeaveVoiceAsync()
        {

        }
        #endregion
        #endregion
        #region Change Nickname [Guild]
        public static async void ChangeNicknameAsync(string NewNickName, string Token, string GuildId, bool Proxied = false, string Proxy = null)
        {
            var request = new HttpRequest();
            try
            {
                request.Settings(Token);
                request.Patch($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(6, 9)}/guilds/{GuildId}/members/@me", $"{{\"nick\": \"{NewNickName}\"}}");
            }
            catch { }
        }
        #endregion
        #region Join Guild
        public static async Task JoinServer(string Token, string invite, bool proxied, string proxy, Color btnColor)
        {
            try
            {
                HttpRequest r = new HttpRequest();
                r.Settings(Token);
                if (proxied)
                {
                    r.Proxy = HttpProxyClient.Parse(proxy);
                }
                r.Post($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(6, 9)}/invites/" + invite);
                if (btnColor == Color.FromArgb(105, 105, 205))
                {
                    var request = new HttpClient();
                    request.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", Token);
                    try
                    {
                        r.Get($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(6, 9)}/invites/{invite}");
                        dynamic info = JsonConvert.DeserializeObject(r.Response.ToString());
                        string guildId = info.guild.id.ToString();
                        await Task.Delay(500);
                        var response = await request.GetAsync($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(6, 9)}/guilds/{guildId}/member-verification?with_guild=false");
                        dynamic form = JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                        string msg = form.form_fields.ToString();
                        msg = msg.Replace("\n", "").Replace("\r", "");
                        msg = msg.Replace("}]", "");
                        string date = response.Content.ReadAsStringAsync().Result.Substring(13, 32);
                        var bypass = new HttpRequest();
                        bypass.Settings(Token);
                        bypass.Put($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(6, 9)}/guilds/{guildId}/requests/@me", $"{{\"version\":\"{date}\",\"form_fields\":{msg},\"response\":true}}]}}", "application/json");
                    }
                    catch { }
                }
            }
            catch {}
        }
        #endregion
        #region Leave Guild
        public static async Task LeaveServer(string Token, string guildId, bool proxied, string proxy)
        {
            var pain = new HttpRequest();
            pain.Settings(Token);
            pain.IgnoreProtocolErrors = false;
            try
            {
                if (proxied)
                    pain.Proxy = HttpProxyClient.Parse(proxy);
                pain.Delete($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(6, 9)}/users/@me/guilds/{guildId}");
            }
            catch (Exception x)
            {
                try
                {
                    pain.Settings(Token);
                    if (x.Message.Contains("400"))
                        pain.Post($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(6, 9)}/guilds/{guildId}/delete", "{}", "application/json");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.IsNullOrWhiteSpace(ex.Message) == false ? ex.Message : x.Message);
                }
            }
        }
        #endregion
        #region Change Username
        public static async Task ChangeUsername(string Token, string Password, string Username, bool proxied, string proxy = null)
        {
            Username = Username.Replace("\n", "").Replace("\r", "");
            try
            {
                var r = new HttpRequest();
                r.Settings(Token);
                if (proxied)
                {
                    r.Proxy = HttpProxyClient.Parse(proxy);
                }
                r.Patch($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v9/users/@me", $"{{\"username\":\"{Username}\",\"password\":\"{Password}\"}}", "application/json");
            }
            catch 
            {
                var r = new HttpRequest();
                r.Settings(Token);
                if (proxied)
                {
                    r.Proxy = HttpProxyClient.Parse(proxy);
                }
                try
                {
                    r.Patch($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v9/users/@me", $"{{\"username\":\"{Username}\",\"password\":\"{Password}\"}}", "application/json");
                }
                catch { }
            }
        }
        #region Get Random Username
        public static async Task GetRandomUsername()
        {
            var gayness = new HttpRequest();
            gayness.Get("https://story-shack-cdn-v2.glitch.me/generators/username-generator");
            dynamic gay = JsonConvert.DeserializeObject(gayness.Response.ToString());
        }
        #endregion
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
                r.Get($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(6, 9)}/users/@me/guilds");
                r.Dispose();
                return Token;
            }
            catch (Exception x)
            {
                if (x.Message.Contains("401") || x.Message.Contains("403"))
                {
                    return null;
                }
                try
                {
                    //MessageBox.Show(Token);
                    var r = new HttpRequest();
                    r.Settings(Token);
                    if (!string.IsNullOrEmpty(Proxy)) r.Proxy = HttpProxyClient.Parse(Proxy);
                    r.IgnoreProtocolErrors = false;
                    r.Post($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(7,9)}/invites/jskIjsk");
                    r.Dispose();
                    return Token;
                }
                catch
                {
                    try
                    {
                        Thread.Sleep(1000);
                        var r = new HttpRequest();
                        r.Settings(Token);
                        if (!string.IsNullOrEmpty(Proxy)) r.Proxy = HttpProxyClient.Parse(Proxy);
                        r.IgnoreProtocolErrors = false;
                        r.Post($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(7, 9)}/invites/jskIjsk");
                        r.Dispose();
                        return Token;
                    }
                    catch { return null; }
                }
            }
        }
        #endregion
        #region Add Reaction
        /// <summary>
        /// Add reaction to message with token(s).
        /// </summary>
        /// <param name="Token"></param>
        /// <param name="ChannelId"></param>
        /// <param name="MessageId"></param>
        /// <param name="EmojiName"></param>
        /// <param name="EmojiId"></param>
        /// <param name="Proxy"></param>
        public static async Task AddReaction(string Token, string ChannelId, string MessageId, string Emoji, bool proxied, string Proxy = null)
        {
            try
            {
                var r = new HttpRequest();
                r.Settings(Token);
                if (proxied) r.Proxy = HttpProxyClient.Parse(Proxy);
                r.Put($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(6, 9)}/channels/{ChannelId}/messages/{MessageId}/reactions/{Emoji}/@me");
                MessageBox.Show(r.Response.ToString());
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }
        #endregion
        #region Change Hypesquad
        /// <summary>
        /// Change HypeSquad of token
        /// </summary>
        /// <param name="Token"></param>
        /// <param name="HypeSquad"></param>
        /// <param name="proxied"></param>
        /// <param name="proxy"></param>
        public static async Task ChangeHypesquad(string Token, int HypeSquad = default, bool proxied = false, string proxy = null)
        {
            var r = new HttpRequest();
            r.Settings(Token);
            if (proxied)
            {
                r.Proxy = HttpProxyClient.Parse(proxy);
            }
            r.Patch($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v9/hypesquad/online", $"{{\"house_id\":{(HypeSquad == default ? new Random(Guid.NewGuid().GetHashCode()).Next(1, 4) : HypeSquad)}}}", "application/json");
        }
        #endregion
        #region Add about me/Bio
        /// <summary>
        /// Add About Me information
        /// </summary>
        /// <param name="Token"></param>
        /// <param name="Proxy"></param>
        public static async void AddBio(string Token, string AboutMe = null, bool Proxied = false, string Proxy = null)
        {
            var r = new HttpRequest();
            r.Settings(Token);
            if (Proxied)
                r.Proxy = HttpProxyClient.Parse(Proxy);
            r.Patch($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(6, 9)}/users/@me", $"{{\"bio\": \"{AboutMe}\"}}", "application/json");
        }
        #endregion
        #region Send Message
        /// <summary>
        /// Send Message To Channel Using Token
        /// </summary>
        /// <param name="Token"></param>
        /// <param name="ChannelId"></param>
        /// <param name="Message"></param>
        /// <param name="Proxies"></param>
        public static async void SendMsg(string Token, string ChannelId, string Message, bool TTS = false, string refId = null, bool Proxied = false, string Proxies = null)
        {
            var r = new HttpRequest();
            if (Proxied) r.Proxy = HttpProxyClient.Parse(Proxies);
            try
            {
                dynamic msgToSpam;
                if (refId == "Message Reference Id" | refId == null | string.IsNullOrEmpty(refId)) msgToSpam = $"{{\"content\":\"{Message}\",\"tts\":{TTS.ToString().ToLower()}}}";
                else msgToSpam = $"{{\"content\":\"{Message}\",\"tts\":{TTS.ToString().ToLower()}, \"message_reference\":{{\"channel_id\":\"{ChannelId}\",\"message_id\":\"{refId}\"}}}}";
                r.Settings(Token);
                r.AddHeader("content-type", "application/json");
                r.Post($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(6, 9)}/channels/{ChannelId}/messages", msgToSpam, "application/json");
            }
            catch (Exception x) { MessageBox.Show(x.Message);  }
        }
        #endregion
    }
}
