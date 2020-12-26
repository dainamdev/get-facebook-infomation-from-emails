using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using xNet;
namespace fbgif_pro
{
    public class RequestService
    {
        private xNet.HttpRequest request;

        public RequestService(string cookie = "", string userAgent = "", string proxy = "", int typeProxy = 0)
        {
            InitializationRequest(cookie, userAgent, proxy, typeProxy);
        }
        public void InitializationRequest(string cookie = "", string userAgent = "", string proxy = "", int typeProxy = 0)
        {
            if (userAgent == "")
            {
                userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36";
            }
            this.request = new xNet.HttpRequest()
            {
                KeepAlive = true,
                AllowAutoRedirect = true,
                Cookies = new CookieDictionary(false),
                UserAgent = userAgent
            };
            request.SslProtocols = SslProtocols.Tls12;
            this.request.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
            this.request.AddHeader("Accept-Language", "en-US,en;q=0.9");
            if (cookie != "")
            {
                this.AddCookie(cookie);
            }
            if (proxy != "")
            {
                switch (proxy.Split(new char[] { ':' }).Count<string>())
                {
                    case 1:
                        {
                            this.request.Proxy = Socks5ProxyClient.Parse(string.Concat("127.0.0.1:", proxy));
                            break;
                        }
                    case 2:
                        {
                            if (typeProxy != 0)
                            {
                                this.request.Proxy = Socks5ProxyClient.Parse(proxy);
                            }
                            else
                            {
                                this.request.Proxy = HttpProxyClient.Parse(proxy);
                            }
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    case 4:
                        {
                            this.request.Proxy = new HttpProxyClient(proxy.Split(new char[] { ':' })[0], Convert.ToInt32(proxy.Split(new char[] { ':' })[1]), proxy.Split(new char[] { ':' })[2], proxy.Split(new char[] { ':' })[3]);
                            break;
                        }
                    default:
                        {
                            goto case 3;
                        }
                }
            }
        }
        public void AddCookie(string cookie)
        {
            string[] strArrays = cookie.Split(new char[] { ';' });
            for (int i = 0; i < (int)strArrays.Length; i++)
            {
                string str = strArrays[i];
                string[] strArrays1 = str.Split(new char[] { '=' });
                if (strArrays1.Count<string>() > 1)
                {
                    try
                    {
                        this.request.Cookies.Add(strArrays1[0], strArrays1[1]);
                    }
                    catch (Exception ex)
                    {
                        File.AppendAllText("ErrorLog.txt", ex.ToString() + "\r\n");
                    }
                }
            }
        }

        public byte[] GetBytes(string url)
        {
            return this.request.Get(url, null).ToBytes();
        }

        public string GetCookie()
        {
            return this.request.Cookies.ToString();
        }

        public string RequestGet(string url)
        {
            return this.request.Get(url, null).ToString();
        }

        public string RequestPost(string url, string data = "", string contentType = "application/x-www-form-urlencoded")
        {
            bool flag = data == "" || contentType == "";
            string result;
            if (flag)
            {
                result = this.request.Post(url).ToString();
            }
            else
            {
                byte[] lll = Encoding.UTF8.GetBytes(data);
                result = this.request.Post(url, lll, contentType).ToString();
            }
            return result;

        }
        public string GetUrl()
        {
            return request.Response.Address.AbsoluteUri.ToString();
        }
        public void CloseRequest()
        {
            request.Close();
        }
    }
}
