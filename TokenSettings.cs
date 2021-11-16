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
using System.Text;
using Discord.Gateway;
using System.Collections.Generic;
using Discord;
using Color = System.Drawing.Color;

namespace Tokens.rip_Token_Manager
{
    #region Header and setting
    public static class Request
    {
        public static void Settings(this HttpRequest r, string Authorization = "unauthorized")
        {
            r.IgnoreProtocolErrors = true;
            r.KeepTemporaryHeadersOnRedirect = false;
            r.ClearAllHeaders();
            r.EnableMiddleHeaders = false;
            r.AllowEmptyHeaderValues = false;
            r.IgnoreInvalidCookie = true;
            r.AddHeader("Accept", "*/*");
            r.AddHeader("Accept-Encoding", "gzip, deflate, br");
            r.AddHeader("Accept-Language", "en-US");
            r.AddHeader("Authorization", Authorization);
            r.AddHeader("Connection", "keep-alive");
            r.AddHeader("Sec-Ch-Ua", "\"Chromium\";v=\"94\", \"Google Chrome\";v=\"94\", \";Not A Brand\";v=\"99\"");
            r.AddHeader("Sec-Ch-Ua-Mobile", "?0");
            r.AddHeader("Sec-Ch-Ua-Platform", "\"Windows\"");
            r.AddHeader("Sec-Fetch-Dest", "empty");
            r.AddHeader("Sec-Fetch-Mode", "cors");
            r.AddHeader("Sec-Fetch-Site", "same-origin");
            r.AddHeader("X-Debug-Options", "bugReporterEnabled");
            r.AddHeader("Cookie", $"__dcfduid={TokenSettings.RandomCookie(43)}; __sdcfduid={TokenSettings.RandomCookie(32)}; locale=en-US");
            r.AddHeader("DNT", "1");
            r.AddHeader("Origin", $"{TokenSettings.domains[new Random(Guid.NewGuid().GetHashCode()).Next(TokenSettings.domains.Length)]}");
            r.AddHeader("X-Fingerprint", $"{TokenSettings.RandomNumber(18)}.{TokenSettings.RandomCookie(27)}");
            r.AddHeader("Referer", $"{TokenSettings.domains[new Random(Guid.NewGuid().GetHashCode()).Next(TokenSettings.domains.Length)]}/channels/@me");
            r.AddHeader("TE", "Trailers");
            r.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/94.0.4606.61 Safari/537.36");
            r.AddHeader("X-Super-Properties", "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiQ2hyb21lIiwiZGV2aWNlIjoiIiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiYnJvd3Nlcl91c2VyX2FnZW50IjoiTW96aWxsYS81LjAgKFdpbmRvd3MgTlQgMTAuMDsgV2luNjQ7IHg2NCkgQXBwbGVXZWJLaXQvNTM3LjM2IChLSFRNTCwgbGlrZSBHZWNrbykgQ2hyb21lLzk0LjAuNDYwNi42MSBTYWZhcmkvNTM3LjM2IiwiYnJvd3Nlcl92ZXJzaW9uIjoiOTQuMC40NjA2LjYxIiwib3NfdmVyc2lvbiI6IjEwIiwicmVmZXJyZXIiOiIiLCJyZWZlcnJpbmdfZG9tYWluIjoiIiwicmVmZXJyZXJfY3VycmVudCI6IiIsInJlZmVycmluZ19kb21haW5fY3VycmVudCI6IiIsInJlbGVhc2VfY2hhbm5lbCI6InN0YWJsZSIsImNsaWVudF9idWlsZF9udW1iZXIiOjEwMDA1NCwiY2xpZW50X2V2ZW50X3NvdXJjZSI6bnVsbH0=");
            r.SslProtocols = SslProtocols.Tls12;
        }
        #region TokenGen Zone
        public static void RegisterSettings(this HttpRequest r, string Fingerprint, string Email)
        {
            r.IgnoreProtocolErrors = true;
            r.KeepTemporaryHeadersOnRedirect = false;
            r.ClearAllHeaders();
            r.EnableMiddleHeaders = false;
            r.AllowEmptyHeaderValues = false;
            r.AddHeader("Accept", "*/*");
            r.AddHeader("Accept-Encoding", "gzip, deflate, br");
            r.AddHeader("Accept-Language", "en-US");
            r.AddHeader("Connection", "keep-alive");
            r.AddHeader("sec-ch-ua", "\"Chromium\";v=\"94\", \"Google Chrome\";v=\"94\", \";Not A Brand\";v=\"99\"");
            r.AddHeader("sec-ch-ua-mobile", "?0");
            r.AddHeader("sec-fetch-dest", "empty");
            r.AddHeader("sec-fetch-mode", "cors");
            r.AddHeader("sec-fetch-site", "same-origin");
            r.AddHeader("X-Debug-Options", "bugReporterEnabled");
            r.AddHeader("Cookie", $"__dcfduid={TokenSettings.RandomCookie(43)}; __sdcfduid={TokenSettings.RandomCookie(32)};");
            r.AddHeader("DNT", "1");
            r.AddHeader("Origin", "https://discord.com");
            r.AddHeader("Host", "discord.com");
            r.AddHeader("Authorization", "undefined");
            if (Fingerprint is null)
                r.AddHeader("X-Fingerprint", $"{TokenSettings.RandomNumber(18)}.{TokenSettings.RandomCookie(27)}");
            r.AddHeader("X-Fingerprint", Fingerprint);
            r.AddHeader("Referer", $"https://discord.com/register?email={Email}");
            r.AddHeader("TE", "Trailers");
            r.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/94.0.4606.61 Safari/537.36");
            r.AddHeader("X-Super-Properties", "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiQ2hyb21lIiwiZGV2aWNlIjoiIiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiYnJvd3Nlcl91c2VyX2FnZW50IjoiTW96aWxsYS81LjAgKFdpbmRvd3MgTlQgMTAuMDsgV2luNjQ7IHg2NCkgQXBwbGVXZWJLaXQvNTM3LjM2IChLSFRNTCwgbGlrZSBHZWNrbykgQ2hyb21lLzk0LjAuNDYwNi42MSBTYWZhcmkvNTM3LjM2IiwiYnJvd3Nlcl92ZXJzaW9uIjoiOTQuMC40NjA2LjYxIiwib3NfdmVyc2lvbiI6IjEwIiwicmVmZXJyZXIiOiIiLCJyZWZlcnJpbmdfZG9tYWluIjoiIiwicmVmZXJyZXJfY3VycmVudCI6IiIsInJlZmVycmluZ19kb21haW5fY3VycmVudCI6IiIsInJlbGVhc2VfY2hhbm5lbCI6InN0YWJsZSIsImNsaWVudF9idWlsZF9udW1iZXIiOjEwMDA1NCwiY2xpZW50X2V2ZW50X3NvdXJjZSI6bnVsbH0=");
            r.SslProtocols = SslProtocols.Tls12;
            #endregion
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
        /// <summary>
        /// Return random unsorted characters 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string RandomCookie(int a)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, a)
              .Select(s => s[random.Next(s.Length)]).ToArray()); // Return random char string
        }
        /// <summary>
        /// Return random int
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
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
        public static async Task SendFriendReq(string Username, string Token, bool MassGuild, bool proxied, List<string> users = null, string proxy = null)
        {
            if (!MassGuild)
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
            else
            {
                try
                {
                    foreach (string user in users)
                    {
                        HttpRequest r = new HttpRequest();
                        r.Settings(Token);
                        if (proxied)
                        {
                            r.Proxy = HttpProxyClient.Parse(proxy);
                        }
                        r.Put($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(6, 9)}/users/@me/relationships/{user}", "{}", "application/json");
                        r.Dispose();
                    }
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
            public static Discord.WebSocket.DiscordSocketClient _UserToken = new Discord.WebSocket.DiscordSocketClient(new Discord.WebSocket.DiscordSocketConfig
            {
                LogLevel = Discord.LogSeverity.Debug
            });
            #endregion
            #region Send Token Online
            public static async Task SendOnline(string _Token)
            {
                #region Works but trash
                try
                {
                    await _UserToken.LoginAsync(0, _Token).ConfigureAwait(false);
                    await _UserToken.StartAsync().ConfigureAwait(false);
                    await _UserToken.SetActivityAsync(new Discord.Game("Tokens.rip", Discord.ActivityType.Playing, Discord.ActivityProperties.None, "Cheap Discord Tokens & Members"));
                }
                catch
                {
                    return;
                }
                #endregion
                #region Non Working Code
                //    using (var WebServerWSS = new WebSocket($"wss://gateway.discord.gg/?v=9&encoding=json"))
                //    {
                //        string WssResponse = "Still null";
                //        string json = @"{
                //'op': 2,
                //'d': {
                //            'token': 'ODkwOTE3MTQ3MjU2MTcyNTY3.YU2xTA.3xwynDmpArqjPeu0K6TNK-tHGI8',
                //    'properties': {
                //                '$os': 'Windows',
                //        '$browser': 'Chrome',
                //        '$device': 'Android Device'
                //    },
                //    'presence': {
                //                'game': 'fkn',
                //        'status': 'online',
                //        'since': 0,
                //        'afk': False
                //    }
                //        },
                //'s': None,
                //'t': None
                //}";
                //    WebServerWSS.OnMessage += (sender, e) =>
                //        {
                //            MessageBox.Show(e.Data);
                //            WssResponse = e.Data;
                //        };
                //        WebServerWSS.OnOpen += (sender, e) =>
                //        {
                //            MessageBox.Show(json);
                //            WebServerWSS.Send(json);
                //        };
                //        WebServerWSS.OnClose += (sender, e) =>
                //        {
                //            Console.WriteLine(e.Code);
                //        };
                //        WebServerWSS.OnError += (sender, e) =>
                //        {
                //            Console.WriteLine(e.Message);
                //        };
                //        WebServerWSS.Connect();
                //        MessageBox.Show(WssResponse + " This is working now?");
                //        //dynamic ResponseJson = JsonConvert.DeserializeObject(WssResponse);
                //        //Console.WriteLine(ResponseJson);
                //        //int sleep = ResponseJson.d.heartbeat_interval;
                //        //Console.WriteLine(WssResponse);
                //        //Console.Write(sleep);
                //    }
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
        public static async Task JoinServer(string Token, string invite, bool proxied, string proxy, Color Flag)
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
                if (Flag == Color.FromArgb(105, 105, 205))
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
        /// <summary>
        /// Async Task to Change Username of token
        /// </summary>
        /// <param name="Token"></param>
        /// <param name="Password"></param>
        /// <param name="Username"></param>
        /// <param name="proxied"></param>
        /// <param name="proxy"></param>
        /// <returns></returns>
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
                r.Get($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(6, 9)}/users/@me/guild-events");
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
                    var r = new HttpRequest();
                    r.Settings(Token);
                    if (!string.IsNullOrEmpty(Proxy)) r.Proxy = HttpProxyClient.Parse(Proxy);
                    r.IgnoreProtocolErrors = false;
                    r.Post($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(7,9)}/users/@me/guild-events");
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
        /// Change HypeSquad of Token
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
        /// Add \*About Me*\ Information to Token
        /// </summary>
        /// <param name="Token"></param>
        /// <param name="AboutMe"></param>
        /// <param name="Proxied"></param>
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
        #region Join Group
        public static async Task JoinGroup(string Token, string ChannelId, string RecipientID, bool Proxied = false, string Proxy = null, string GroupInvite = null)
        {
            var r = new HttpRequest();
            r.Settings(Token);
            r.IgnoreProtocolErrors = true;
            if (GroupInvite == null)
            {
                if (Proxied)
                {
                    r.Proxy = new HttpProxyClient(Proxy);
                }
                r.Put($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(6,9)}/channels/{ChannelId}/recipients/{RecipientID}");
            }
            else
            {
                await JoinServer(Token, GroupInvite, Proxied, Proxy, Color.Black);
            }
        }
        #endregion
        #region Send Message
        /// <summary>
        /// Send Message To Channel Using Token
        /// </summary>
        /// <param name="Token"></param>
        /// <param name="ChannelId"></param>
        /// <param name="Message"></param>
        /// <param name="TTS"></param>
        /// <param name="refId"></param>
        /// <param name="Proxied"></param>
        /// <param name="Proxies"></param>
        public static async void SendMsg(string Token, string ChannelId, string Message, bool TTS = false, string refId = null, bool Proxied = false, string Proxies = null)
        {
            try
            {
                var JsonMessageFormatting = new System.Net.Http.StringContent($"{{\"content\":\"{Message}\",\"nonce\":\"\",\"tts\":{TTS.ToString().ToLower()}}}", Encoding.UTF8, "application/json");
                try
                {
                    if (refId == "Message Reference Id" | refId == null | string.IsNullOrEmpty(refId))
                        JsonMessageFormatting = new System.Net.Http.StringContent($"{{\"content\":\"{Message}\",\"nonce\":\"\",\"tts\":{TTS.ToString().ToLower()},\"message_reference\":{{\"channel_id\":\"{ChannelId}\",\"message_id\":\"{refId}\"}}}}", Encoding.UTF8, "application/json");
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.Message);
                }
                var r = new HttpRequest();
                var s = new HttpClient();
                var http = new HttpRequestMessage()
                {
                    Method = System.Net.Http.HttpMethod.Post,
                    Content = JsonMessageFormatting,
                    RequestUri = new Uri($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/v{new Random(Guid.NewGuid().GetHashCode()).Next(6,9)}/channels/{ChannelId}/messages")
                };
                s.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", Token);
                var response = await s.SendAsync(http).ConfigureAwait(false);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                #region Leaf.xNet Method
                //r.AddHeader("Authorization", Token);
                //r.Post("https://discord.com/api/v7/channels/894015565054771234/messages", "{\"content\":\"nOu\",\"nonce\":\"\",\"tts\":false}", "application/json");
                //if (Proxied) r.Proxy = HttpProxyClient.Parse(Proxies);
                //dynamic msgToSpam;
                //if (refId == "Message Reference Id" | refId == null | string.IsNullOrEmpty(refId)) msgToSpam = $"{{\"content\":\"{Message}\",\"nonce\":\"\",\"tts\":{TTS.ToString().ToLower()}}}";
                //else msgToSpam = $"{{\"content\":\"{Message}\",\"nonce\":\"\",\"tts\":{TTS.ToString().ToLower()},\"message_reference\":{{\"channel_id\":\"{ChannelId}\",\"message_id\":\"{refId}\"}}}}";
                //r.Settings(Token);
                //r.Post($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(6, 9)}/channels/{ChannelId}/messages", msgToSpam, "application/json");
                #endregion
            }
            catch {}
        }
        #endregion
        #region Parse Guild Users
        public static List<string> FetchUsers(string token, ulong guildId, ulong channelId)
        {
            Discord.Gateway.DiscordSocketClient client = new Discord.Gateway.DiscordSocketClient(null);
            client.Login(token);
            List<string> users = new List<string>();
            foreach (GuildMember member in client.GetGuildChannelMembers(guildId, channelId))
                users.Add(member.User.Id.ToString());
            return users;
        }
        #endregion
        #region Create Account
        public static async void Register(string Captcha, string Username = null, string Email = null, string Password = null)
        {
            #region Client Method
            //try
            //{
            //    var client = new HttpClient();
            //    var request = new HttpRequestMessage
            //    {
            //        Method = System.Net.Http.HttpMethod.Post,
            //        RequestUri = new Uri("https://discord.com/api/v9/auth/register"),
            //        Content = new StringContent($"{{\"consent\":true,\"captcha_key\":\"{Captcha}\",\"username\":\"JustFkWorkThx\",\"fingerprint\":\"876871901266456687.nAOSNIpz8B0hczgZFjcgZ6EvbSg\"}}", Encoding.UTF8, "application/json"),
            //        //Content = new StringContent("{\"consent\":true,\"fingerprint\":\"893558240409960468.epWrrIPx0Z1P3H4m_emXQv52X6I\",\"username\":\"ilovediscordmen\",\"captcha_key\":\"" + Captcha + "\"}", Encoding.UTF8, "application/json"),
            //    };
            //    //dynamic payload = $"{{\"consent\": True, \"captcha_key\": \"{Captcha}\", \"username\": \"JustFkWorkThx\", \"fingerprint\": \"876871901266456687.nAOSNIpz8B0hczgZFjcgZ6EvbSg\",}}";
            //    //client.DefaultRequestHeaders.TryAddWithoutValidation("", "");
            //    var response = await client.SendAsync(request).ConfigureAwait(false);
            //    string respResult = response.Content.ReadAsStringAsync().Result;

            //    Console.WriteLine(respResult);
            //    MessageBox.Show(respResult);
            //}
            //catch (Exception x)
            //{
            //    Console.WriteLine(x.Message);
            //}
            #endregion
            try
            {
                var r = new HttpRequest();
                r.RegisterSettings("893563800370966538.ORGD_0V_2bl83_BdHXt7juV0dCk", "fuckinghe44ll@sfkjasnf.one");
                r.Post($"{domains[new Random(Guid.NewGuid().GetHashCode()).Next(domains.Length)]}/api/v{new Random(Guid.NewGuid().GetHashCode()).Next(6,9)}/auth/register", 
                    $"{{\"fingerprint\":\"893563800370966538.ORGD_0V_2bl83_BdHXt7juV0dCk\",\"email\":\"fuckinghe44ll@sfkjasnf.one\",\"username\":\"whateverqj23ijr302\",\"password\":\"WhyDoYouWorkNow\",\"invite\":\"ZYyM7hug\",\"consent\":true\",date_of_birth\":\"1990-05-14\",\"gift_code_sku_id\":\"\",\"captcha_key\":\"{Captcha}\"}}", 
                    "application/json");
                Console.WriteLine(r.Response.ToString());
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        #endregion
    }
}
