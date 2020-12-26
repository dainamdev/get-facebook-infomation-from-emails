using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using xNet;
using HttpRequest;

namespace fbgif_pro
{   public class Facebook
    {
        /// <summary>
        /// email to get info
        /// </summary>
        public string Email;
        /// <summary>
        /// id facebook
        /// </summary>
        public string ID;
        /// <summary>
        /// id page
        /// </summary>
        public string IdPage;
        /// <summary>
        /// cookie fb
        /// </summary>
        public string Cookie;
        /// <summary>
        /// uid of cookie
        /// </summary>
        public string Uidclone;
        /// <summary>
        /// token
        /// </summary>
        public string Token;
        /// <summary>
        /// name of facebook
        /// </summary>
        public string FbName;
        /// <summary>
        /// fb code
        /// </summary>
        public string fb_dtsg;
        /// <summary>
        /// fb code
        /// </summary>
        public string jazoest;
        /// <summary>
        /// fb code
        /// </summary>
        public string fb_av;
        /// <summary>
        /// fb code
        /// </summary>
        public string fb_eav;
        /// <summary>
        /// birthday
        /// </summary>
        public string BirthDay;
        /// <summary>
        /// như tên
        /// </summary>
        public string HomeTown;
        /// <summary>
        /// number friends of fb
        /// </summary>
        public string Friend_Count;
        /// <summary>
        /// number follows of fb
        /// </summary>
        public string Follow_Count;
        /// <summary>
        /// date created fb
        /// </summary>
        public string CreatedDay;
        /// <summary>
        /// như tên
        /// </summary>
        public string LatsOnline;
        /// <summary>
        /// lists id pages
        /// </summary>
        public List<string> Listidpage = new List<string> { };
        /// <summary>
        /// init app
        /// </summary>
        AppExtension app = new AppExtension();
        /// <summary>
        /// :/
        /// </summary>
        public bool isonlyuid = false;
        /// <summary>
        /// Get infomation facebook from email
        /// </summary>
       public void FaceBookInfomation()
       {
            try
            {
                RequestService requestService = new RequestService(this.Cookie, FacebookInfo.UserAgentGetcre);
                //RequestService requestService = new RequestService(FacebookInfo.UserAgentGetcre);
                string ResponsePageAdmin = requestService.RequestGet(FacebookInfo.FacebookAdminPage + IdPage + "&eav=" + fb_eav + "&q=" + Email + "&session_id=undefined&m_sess=&fb_dtsg_ag=" + fb_dtsg + "&jazoest=" + jazoest + "&__user=" + Uidclone);
                if (requestService.GetUrl().Contains("checkpoint/block/"))
                {
                    this.FbName = "checkpoint";
                    return;
                }
                if (ResponsePageAdmin.Contains("uid"))
                {
                    this.ID = Regex.Match(ResponsePageAdmin, "uid.*?(\\d+)").Groups[1].Value;
                    this.FbName = Regex.Match(ResponsePageAdmin, "text\":\"(.*?)\",").Groups[1].Value;
                    this.FbName = Regex.Unescape(this.FbName);
                }
                else
                {
                    this.FbName = "not_id"; // Nguyen Dac Tai // Code đến bao giờ ???
                    return;
                }
                if (isonlyuid == true)
                {
                    this.CreatedDay = "0";
                    this.HomeTown = "0";
                    this.Friend_Count = "0";
                    this.Follow_Count = "0";
                    this.LatsOnline = "0";
                    this.BirthDay = "0";
                    return;
                }
                string FacebookInfoAccount = requestService.RequestGet(FacebookInfo.FacebookGraph + this.ID + "?access_token=" + this.Token);
                string FriendCount = requestService.RequestGet(FacebookInfo.FacebookGraph + this.ID + FacebookInfo.FriendPath + this.Token);
                string FollowCount = requestService.RequestGet(FacebookInfo.FacebookGraph + this.ID + FacebookInfo.FollowPath + this.Token);
                string LastOnlinerq = requestService.RequestGet(FacebookInfo.FacebookGraph + this.ID + FacebookInfo.AlbumPath + this.Token + "&limit=1");
                string timestampcre = FacebookDateCreated(ID, fb_dtsg);
                if (timestampcre == "error")
                {
                    this.CreatedDay = "0";
                }
                else { this.CreatedDay = AppExtension.TimeStampConvert(Convert.ToInt32(timestampcre)); }
                if (FacebookInfoAccount.Contains("birthday"))
                {
                    this.BirthDay = JsonConvert(FacebookInfoAccount, "birthday");
                }
                else { this.BirthDay = "0"; }
                if (FacebookInfoAccount.Contains("hometown"))
                {
                    this.HomeTown = JObject.Parse(FacebookInfoAccount)["hometown"]["name"].ToString();
                }
                else { this.HomeTown = "private"; }
                if (FriendCount.Contains("id"))
                {
                    if (!FriendCount.Contains("sentry_block_data"))
                    {
                        this.Friend_Count = JObject.Parse(FriendCount)["data"].Count().ToString();
                    }
                    else { this.Friend_Count = "0"; }
                }
                else { this.Friend_Count = "0"; }
                if (LastOnlinerq.Contains("updated_time"))
                {
                    this.LatsOnline = Regex.Match(LastOnlinerq, FacebookInfo.RegexLastOn).Groups[1].Value;
                }
                else { this.LatsOnline = "0"; }
                this.Follow_Count = JObject.Parse(FollowCount)["summary"]["total_count"].ToString();
            }
            catch (Exception ex)
            { 
                this.FbName = "error";
                app.ExportError(ex.Message);
                return; 
            }
       }
        /// <summary>
        /// FacebookIdentifyCode generator // fb_dtsg : jazoest : av : eav
        /// </summary>
        /// <returns></returns>
        public string FacebookIdentifyCode()
        {
            try
            {
                RequestService requestService = new RequestService(this.Cookie, FacebookInfo.UserAgentGetcre);
                string Response = requestService.RequestGet(FacebookInfo.FacebookHomePage);
                if (!Response.Contains("fb_dtsg"))
                {
                    return "die";
                }
                this.fb_dtsg = Regex.Match(Response, "name=\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
                this.jazoest = Regex.Match(Response, "name=\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
                this.fb_av = Regex.Match(Response, "av=(\\d+)&").Groups[1].Value;
                this.fb_eav = Regex.Match(Response, "eav=(.*?)&").Groups[1].Value;
                return "sucess";
            }
            catch { return "error"; }
        }
        /// <summary>
        /// get facebook pages id from tokens
        /// </summary>
        /// <returns></returns>
        public string FacebookPageid()
        {
            try
            {
                RequestService requestService = new RequestService(this.Cookie, FacebookInfo.UserAgentGetcre);
                string Response = requestService.RequestGet(FacebookInfo.FacebookPageApi + this.Token);
                if (!Response.Contains("data"))
                {
                    return "die";
                }
                int CountIdPage = JObject.Parse(Response)["data"].Count();
                if (CountIdPage <= 0)
                {
                    return "not_a_page";
                }    
                for (int i = 0; i < CountIdPage; i++)
                {
                    Listidpage.Add(JObject.Parse(Response)["data"][i]["id"].ToString());
                }
                return "success";
            }
            catch (Exception ex) { return "error"; }
        }
        /// <summary>
        /// get normal facebook token wit cookie
        /// </summary>
        /// <returns></returns>
        public string FacebookTokenNormal()
        {
            try
            {
                RequestService requestService = new RequestService(this.Cookie, FacebookInfo.UserAgentGetcre);
                string Response = requestService.RequestGet(FacebookInfo.FacebookTokenNormal);
                if (!Response.Contains("accessToken"))
                {
                    return "die";
                }
                this.Token = Regex.Match(Response, "EAAA[a-zA-Z0-9]{100,220}").Groups[0].Value;
                return "success";
            }
            catch { return "error"; }
        }
        /// <summary>
        /// get token facebook bussiness
        /// </summary>
        /// <returns></returns>
        public string FacebookTokenBussine()
        {
            try
            {
                RequestService requestService = new RequestService(this.Cookie, FacebookInfo.UserAgentGetcre);
                string Response = requestService.RequestGet(FacebookInfo.FacebookBussineToken);
                if (!Response.Contains("accessToken"))
                {
                    return "die";
                }
                Regex reg = new Regex("EAAG[a-zA-Z0-9]{100,220}");
                var match = reg.Match(Response);
                if (match.Success)
                {
                    this.Token = match.Groups[0].Value;
                    return "sucess";
                }
                else { return "error"; }
            }
            catch { return "error"; }
        }
        /// <summary>
        /// get the date created of facebook by UID
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="Fbdtg"></param>
        /// <returns></returns>
        public string FacebookDateCreated(string uid, string Fbdtg)
        {
            try
            {
                RequestHTTP request_api = new RequestHTTP();
                request_api.SetSSL(System.Net.SecurityProtocolType.Tls12);
                request_api.SetKeepAlive(true);
                request_api.SetDefaultHeaders(new string[] { "content-type: Text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
                string get_created_time = request_api.Request("POST", "https://www.facebook.com/api/graphql", null, Encoding.UTF8.GetBytes("fb_dtsg=" + Fbdtg + "&q=node(" + uid + "){created_time}"));
                return Regex.Match(get_created_time, "created_time.*?(\\d+)").Groups[1].Value;
            }
            catch { return "error"; }
        }
        /// <summary>
        /// nghịch thôi chứ ko có gì hết á :v
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="Fbdtg"></param>
        /// <returns></returns>
        public static string FacebookDateCreatedTest(string uid, string Fbdtg)
        {
            try
            {
                RequestHTTP request_api = new RequestHTTP();
                request_api.SetSSL(System.Net.SecurityProtocolType.Tls12);
                request_api.SetKeepAlive(true);
                request_api.SetDefaultHeaders(new string[] { "content-type: Text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36" });
                string get_created_time = request_api.Request("POST", "https://www.facebook.com/api/graphql", null, Encoding.UTF8.GetBytes("fb_dtsg=" + Fbdtg + "&q=node(" + uid + ")hometown{name}{friends{count},subscribers{count},groups{count},created_time,timeline_feed_units.first(500){page_info,edges{node{url,feedback{reactors{count},comments{count}}}}}}}"));
                return Regex.Match(get_created_time, "created_time.*?(\\d+)").Groups[1].Value;
            }
            catch { return "error"; }
        }
        /// <summary>
        /// 1 hàm json convert nhưng ít được dùng
        /// </summary>
        /// <param name="Object"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public string JsonConvert(string Object, string key)
        {
            JObject jObject = JObject.Parse(Object);
            return jObject[key].ToString();
        }

    }
}
