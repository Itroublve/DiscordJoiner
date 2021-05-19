using Leaf.xNet;
using System;
using System.IO;
using System.Linq;
using System.Security.Authentication;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itroublve_Joiner_v3
{
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
        public static void SendFriendReq(string Username, string Token)
        {
            Parallel.ForEach(Regex.Matches(Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}").Cast<Match>(), async (token, state) =>
            {
                if (Username.Contains("#"))
                {
                    try
                    {
                        HttpRequest r = new HttpRequest();
                        r.KeepTemporaryHeadersOnRedirect = false;
                        r.ClearAllHeaders();
                        r.EnableMiddleHeaders = false;
                        r.AllowEmptyHeaderValues = false;
                        r.AddHeader("Accept", "*/*");
                        r.AddHeader("Accept-Encoding", "gzip, deflate, br");
                        r.AddHeader("Accept-Language", "en-US");
                        r.AddHeader("Authorization", Token);
                        r.AddHeader("Connection", "keep-alive");
                        r.AddHeader("Cookie", $"__cfduid={RandomCookie(43)}; __dcfduid={RandomCookie(32)}; locale=en-US");
                        r.AddHeader("DNT", "1");
                        r.AddHeader("origin", "https://discord.com");
                        r.AddHeader("Referer", "https://discord.com/channels/@me");
                        r.AddHeader("TE", "Trailers");
                        r.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:88.0) Gecko/20100101 Firefox/88.0");
                        r.AddHeader("X-Super-Properties", "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiRGlzY29yZCBDbGllbnQiLCJyZWxlYXNlX2NoYW5uZWwiOiJzdGFibGUiLCJjbGllbnRfdmVyc2lvbiI6IjEuMC45MDAxIiwib3NfdmVyc2lvbiI6IjEwLjAuMTkwNDIiLCJvc19hcmNoIjoieDY0Iiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiY2xpZW50X2J1aWxkX251bWJlciI6ODMwNDAsImNsaWVudF9ldmVudF9zb3VyY2UiOm51bGx9");
                        r.SslProtocols = SslProtocols.Tls12;
                        r.Post("https://discord.com/api/v9/users/@me/relationships", $"{{\"username\": \"{Username.Split('#')[0]}\", \"discriminator\": \"{Username.Split('#')[1]}\"}}", "application/json");
                        r?.Dispose();
                    }
                    catch
                    { }
                }
                else
                {
                    try
                    {
                        HttpRequest r = new HttpRequest();
                        r.KeepTemporaryHeadersOnRedirect = false;
                        r.ClearAllHeaders();
                        r.EnableMiddleHeaders = false;
                        r.AllowEmptyHeaderValues = false;
                        r.AddHeader("Accept", "*/*");
                        r.AddHeader("Accept-Encoding", "gzip, deflate, br");
                        r.AddHeader("Accept-Language", "en-US");
                        r.AddHeader("Authorization", Token);
                        r.AddHeader("Connection", "keep-alive");
                        r.AddHeader("Cookie", $"__cfduid={RandomCookie(43)}; __dcfduid={RandomCookie(32)}; locale=en-US");
                        r.AddHeader("DNT", "1");
                        r.AddHeader("origin", "https://discord.com");
                        r.AddHeader("Referer", "https://discord.com/channels/@me");
                        r.AddHeader("TE", "Trailers");
                        r.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:88.0) Gecko/20100101 Firefox/88.0");
                        r.AddHeader("X-Super-Properties", "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiRGlzY29yZCBDbGllbnQiLCJyZWxlYXNlX2NoYW5uZWwiOiJzdGFibGUiLCJjbGllbnRfdmVyc2lvbiI6IjEuMC45MDAxIiwib3NfdmVyc2lvbiI6IjEwLjAuMTkwNDIiLCJvc19hcmNoIjoieDY0Iiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiY2xpZW50X2J1aWxkX251bWJlciI6ODMwNDAsImNsaWVudF9ldmVudF9zb3VyY2UiOm51bGx9");
                        r.SslProtocols = SslProtocols.Tls12;
                        r.Put($"https://discord.com/api/v9/users/@me/relationships/{Username}", "{}", "application/json");
                        r?.Dispose();
                    }
                    catch
                    { }
                }
                state.Break();
            });
        }
        #endregion
        #region Block Friend
        public static void BlockFriend(string Username, string Token)
        {
            Parallel.ForEach(Regex.Matches(Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}").Cast<Match>(), async (token, state) =>
            {
                if (Username.Contains("#"))
                {
                    MessageBox.Show("You must enter the USER ID.", "Friend Options");
                    //try
                    //{
                    //    HttpRequest r = new HttpRequest();
                    //    r.KeepTemporaryHeadersOnRedirect = false;
                    //    r.ClearAllHeaders();
                    //    r.EnableMiddleHeaders = false;
                    //    r.AllowEmptyHeaderValues = false;
                    //    r.AddHeader("Accept", "*/*");
                    //    r.AddHeader("Accept-Encoding", "gzip, deflate, br");
                    //    r.AddHeader("Accept-Language", "en-US");
                    //    r.AddHeader("Authorization", Token);
                    //    r.AddHeader("Connection", "keep-alive");
                    //    r.AddHeader("Cookie", $"__cfduid={RandomCookie(43)}; __dcfduid={RandomCookie(32)}; locale=en-US");
                    //    r.AddHeader("DNT", "1");
                    //    r.AddHeader("origin", "https://discord.com");
                    //    r.AddHeader("Referer", "https://discord.com/channels/@me");
                    //    r.AddHeader("TE", "Trailers");
                    //    r.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:88.0) Gecko/20100101 Firefox/88.0");
                    //    r.AddHeader("X-Super-Properties", "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiRGlzY29yZCBDbGllbnQiLCJyZWxlYXNlX2NoYW5uZWwiOiJzdGFibGUiLCJjbGllbnRfdmVyc2lvbiI6IjEuMC45MDAxIiwib3NfdmVyc2lvbiI6IjEwLjAuMTkwNDIiLCJvc19hcmNoIjoieDY0Iiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiY2xpZW50X2J1aWxkX251bWJlciI6ODMwNDAsImNsaWVudF9ldmVudF9zb3VyY2UiOm51bGx9");
                    //    r.SslProtocols = SslProtocols.Tls12;
                    //    r.Post("https://discord.com/api/v9/users/@me/relationships", $"{{\"username\": \"{Username.Split('#')[0]}\", \"discriminator\": \"{Username.Split('#')[1]}\"}}", "application/json");
                    //    r?.Dispose();
                    //}
                    //catch
                    //{ }
                }
                else
                {
                    try
                    {
                        HttpRequest r = new HttpRequest();
                        r.KeepTemporaryHeadersOnRedirect = false;
                        r.ClearAllHeaders();
                        r.EnableMiddleHeaders = false;
                        r.AllowEmptyHeaderValues = false;
                        r.AddHeader("Accept", "*/*");
                        r.AddHeader("Accept-Encoding", "gzip, deflate, br");
                        r.AddHeader("Accept-Language", "en-US");
                        r.AddHeader("Authorization", Token);
                        r.AddHeader("Connection", "keep-alive");
                        r.AddHeader("Cookie", $"__cfduid={RandomCookie(43)}; __dcfduid={RandomCookie(32)}; locale=en-US");
                        r.AddHeader("DNT", "1");
                        r.AddHeader("origin", "https://discord.com");
                        r.AddHeader("Referer", "https://discord.com/channels/@me");
                        r.AddHeader("TE", "Trailers");
                        r.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:88.0) Gecko/20100101 Firefox/88.0");
                        r.AddHeader("X-Super-Properties", "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiRGlzY29yZCBDbGllbnQiLCJyZWxlYXNlX2NoYW5uZWwiOiJzdGFibGUiLCJjbGllbnRfdmVyc2lvbiI6IjEuMC45MDAxIiwib3NfdmVyc2lvbiI6IjEwLjAuMTkwNDIiLCJvc19hcmNoIjoieDY0Iiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiY2xpZW50X2J1aWxkX251bWJlciI6ODMwNDAsImNsaWVudF9ldmVudF9zb3VyY2UiOm51bGx9");
                        r.SslProtocols = SslProtocols.Tls12;
                        r.Put($"https://discord.com/api/v9/users/@me/relationships/{Username}", "{\"type\":2}", "application/json");
                        r?.Dispose();
                    }
                    catch
                    { }
                }
                state.Break();
            });
        }
        #endregion
        #region Remove Friend
        public static void RemoveFriend(string Username, string Token)
        {
            Parallel.ForEach(Regex.Matches(Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}").Cast<Match>(), async (token, state) =>
            {
                if (Username.Contains("#"))
                {
                    MessageBox.Show("You must enter the USER ID.", "Friend Options");
                    //try
                    //{
                    //    HttpRequest r = new HttpRequest();
                    //    r.KeepTemporaryHeadersOnRedirect = false;
                    //    r.ClearAllHeaders();
                    //    r.EnableMiddleHeaders = false;
                    //    r.AllowEmptyHeaderValues = false;
                    //    r.AddHeader("Accept", "*/*");
                    //    r.AddHeader("Accept-Encoding", "gzip, deflate, br");
                    //    r.AddHeader("Accept-Language", "en-US");
                    //    r.AddHeader("Authorization", Token);
                    //    r.AddHeader("Connection", "keep-alive");
                    //    r.AddHeader("Cookie", $"__cfduid={RandomCookie(43)}; __dcfduid={RandomCookie(32)}; locale=en-US");
                    //    r.AddHeader("DNT", "1");
                    //    r.AddHeader("origin", "https://discord.com");
                    //    r.AddHeader("Referer", "https://discord.com/channels/@me");
                    //    r.AddHeader("TE", "Trailers");
                    //    r.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:88.0) Gecko/20100101 Firefox/88.0");
                    //    r.AddHeader("X-Super-Properties", "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiRGlzY29yZCBDbGllbnQiLCJyZWxlYXNlX2NoYW5uZWwiOiJzdGFibGUiLCJjbGllbnRfdmVyc2lvbiI6IjEuMC45MDAxIiwib3NfdmVyc2lvbiI6IjEwLjAuMTkwNDIiLCJvc19hcmNoIjoieDY0Iiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiY2xpZW50X2J1aWxkX251bWJlciI6ODMwNDAsImNsaWVudF9ldmVudF9zb3VyY2UiOm51bGx9");
                    //    r.SslProtocols = SslProtocols.Tls12;
                    //    r.Delete($"https://discord.com/api/v9/users/@me/relationships/");
                    //    r?.Dispose();
                    //}
                    //catch { }
                }
                else
                {
                    try
                    {
                        HttpRequest r = new HttpRequest();
                        r.KeepTemporaryHeadersOnRedirect = false;
                        r.ClearAllHeaders();
                        r.EnableMiddleHeaders = false;
                        r.AllowEmptyHeaderValues = false;
                        r.AddHeader("Accept", "*/*");
                        r.AddHeader("Accept-Encoding", "gzip, deflate, br");
                        r.AddHeader("Accept-Language", "en-US");
                        r.AddHeader("Authorization", Token);
                        r.AddHeader("Connection", "keep-alive");
                        r.AddHeader("Cookie", $"__cfduid={RandomCookie(43)}; __dcfduid={RandomCookie(32)}; locale=en-US");
                        r.AddHeader("DNT", "1");
                        r.AddHeader("origin", "https://discord.com");
                        r.AddHeader("Referer", "https://discord.com/channels/@me");
                        r.AddHeader("TE", "Trailers");
                        r.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:88.0) Gecko/20100101 Firefox/88.0");
                        r.AddHeader("X-Super-Properties", "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiRGlzY29yZCBDbGllbnQiLCJyZWxlYXNlX2NoYW5uZWwiOiJzdGFibGUiLCJjbGllbnRfdmVyc2lvbiI6IjEuMC45MDAxIiwib3NfdmVyc2lvbiI6IjEwLjAuMTkwNDIiLCJvc19hcmNoIjoieDY0Iiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiY2xpZW50X2J1aWxkX251bWJlciI6ODMwNDAsImNsaWVudF9ldmVudF9zb3VyY2UiOm51bGx9");
                        r.SslProtocols = SslProtocols.Tls12;
                        r.Delete($"https://discord.com/api/v9/users/@me/relationships/{Username}");
                        r?.Dispose();
                    }
                    catch { }
                }
                state.Break();
            });
        }
        #endregion
        #region Change Profile Picture Of Tokens
        public static void ChangePfp(string FilePath, string Token)
        {
            Parallel.ForEach(Regex.Matches(Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}").Cast<Match>(), async (token, state) =>
            {
                string ImgBase64 = GetBase64Data(FilePath);
                if (ImgBase64 != null)
                {
                    try
                    {
                        HttpRequest r = new HttpRequest();
                        r.KeepTemporaryHeadersOnRedirect = false;
                        r.ClearAllHeaders();
                        r.EnableMiddleHeaders = false;
                        r.AllowEmptyHeaderValues = false;
                        r.AddHeader("Accept", "*/*");
                        r.AddHeader("Accept-Encoding", "gzip, deflate, br");
                        r.AddHeader("Accept-Language", "en-US");
                        r.AddHeader("Authorization", Token);
                        r.AddHeader("Connection", "keep-alive");
                        r.AddHeader("Cookie", $"__cfduid={RandomCookie(43)}; __dcfduid={RandomCookie(32)}; locale=en-US");
                        r.AddHeader("DNT", "1");
                        r.AddHeader("origin", "https://discord.com");
                        r.AddHeader("Referer", "https://discord.com/channels/@me");
                        r.AddHeader("TE", "Trailers");
                        r.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:88.0) Gecko/20100101 Firefox/88.0");
                        r.AddHeader("X-Super-Properties", "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiRGlzY29yZCBDbGllbnQiLCJyZWxlYXNlX2NoYW5uZWwiOiJzdGFibGUiLCJjbGllbnRfdmVyc2lvbiI6IjEuMC45MDAxIiwib3NfdmVyc2lvbiI6IjEwLjAuMTkwNDIiLCJvc19hcmNoIjoieDY0Iiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiY2xpZW50X2J1aWxkX251bWJlciI6ODMwNDAsImNsaWVudF9ldmVudF9zb3VyY2UiOm51bGx9");
                        r.SslProtocols = SslProtocols.Tls12;
                        r.Patch("https://discord.com/api/v9/users/@me", $"{{\"avatar\": \"{ImgBase64}\"}}", "application/json");
                        r?.Dispose();
                    }
                    catch { }
                }
                else
                {
                    MessageBox.Show("Unsupported Image Format!");
                }
                state.Break();
            });
        }
        #endregion
    }
}
