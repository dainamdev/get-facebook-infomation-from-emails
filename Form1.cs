using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace fbgif_pro
{
    /// <summary>
    /// SOURCE CODE : NGUYỄN ĐẮC TÀI
    /// FAM Software, tienichmmo.net
    /// Enjoy :)
    /// </summary>
    public partial class Form1 : Form
    {
        string TempdataSave;
        string DateFormat;
        private bool isstop;
        string DataSeperator = "|";
        bool isSetupsucces;
        int successCount;
        int FailCount;
        int CheckedCount;
        int TotalCount;
        string userag;
        string user = "";
        string password = "";
        string expdate = "";
        string PathError;
        string PathSuccess;
        public Form1(string user_, string pass_, string expdate_)
        {
            CHeckDir();
            user = user_;
            password = pass_;
            expdate = expdate_;
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void CHeckDir()
        {
            string Pathdata = Application.StartupPath + "\\data";
            string Pathtemp = Application.StartupPath + "\\data\\temp";
            string Pathsuccess = Application.StartupPath + "\\data\\success";
            string PathFail = Application.StartupPath + "\\data\\fail";
            List<string> listpath = new List<string>(){ Pathdata, Pathtemp, Pathsuccess, PathFail };
            foreach (string filepath in listpath)
            {
                if(!File.Exists(filepath))
                {
                    Directory.CreateDirectory(filepath);
                }    
            }    
        }
        private void btnstart_Click(object sender, EventArgs e)
        {
            //AppExtension.MessageBoxShow("thiếu cmn file rồi", 2);
            //AppExtension.MessageBoxShow("good", 1);
            //AppExtension.MessageBoxShow("lỗi gì đó", 3);
            //string namefb = Regex.Match(txtemail.Text, "uid.*?(\\d+)").Groups[1].Value;\
            //string test = Facebook.FacebookDateCreated("100055700742809", "AQHi6kC3ZdPS:AQEQ6yi5NMrE");
            PathError = Application.StartupPath + "\\data\\fail\\" + "error_mail_" + DateFormat + ".txt";
            PathSuccess = Application.StartupPath + "\\data\\success\\" + "success_" + DateFormat + ".txt";
            if (isSetupsucces == false)
            {
                AppExtension.MessageBoxShow("chưa setup data ! vui lòng bấm setup data...", 2);
                return;
            }
            isstop = false;
            btnstart.Enabled = false;
            btnstop.Enabled = true;
            lbstatus.Text = "đang chạy...";
            try
            {
                new Thread(() =>
                {
                    string[] ListEmail = File.ReadAllLines(txtemail.Text);
                    ParallelOptions parallelOptions = new ParallelOptions();
                    parallelOptions.MaxDegreeOfParallelism = Convert.ToInt32(numthread.Value);
                    //  parallelOptions.CancellationToken = cts.Token;
                    int row = 0;
                    Parallel.ForEach(ListEmail, parallelOptions, (string emailLine, ParallelLoopState state) =>
                    {
                        if (isstop == true)
                        {
                            state.Break();
                        }
                        dtgrvdata.Invoke((MethodInvoker)delegate ()
                        {
                            row = dtgrvdata.Rows.Add();
                        });
                        GetInfoFacebook(emailLine, row);
                        AppExtension.DataGridScroll(dtgrvdata);
                        Thread.Sleep(TimeSpan.FromSeconds(Convert.ToDouble(numsleep.Value)));
                    });
                    btnstart.Enabled = true;
                    btnstop.Enabled = false;
                    lbstatus.Text = "chạy xong !";
                }).Start();
            }
            catch
            { }
        }
        private void GetInfoFacebook(string emmail, int row)
        {
            string subemail = emmail;
            if (emmail.Contains(":"))
            {
                subemail = emmail.Split(':')[0].ToString();
            }    
            int trycount = 0;
            int trycountcp = 0;
            try
            {
                startcheck:
                AppExtension appExtension = new AppExtension();
                string datafromrandom = appExtension.RandomData(TempdataSave);
                string Token = datafromrandom.Split('|')[0].ToString();
                string Cookie = datafromrandom.Split('|')[1].ToString();
                string Idpage = datafromrandom.Split('|')[2].ToString();
                string fb_dtg = datafromrandom.Split('|')[3].ToString();
                string jazoet = datafromrandom.Split('|')[4].ToString();
                string fb_av = datafromrandom.Split('|')[5].ToString();
                string fbeav = datafromrandom.Split('|')[6].ToString();
                Facebook facebook = new Facebook();
                if(onlyuid.Checked)
                {
                    facebook.isonlyuid = true;
                }    
                facebook.Token = Token;
                facebook.Cookie = Cookie;
                facebook.IdPage = Idpage;
                facebook.Email = subemail;
                facebook.fb_dtsg = fb_dtg;
                facebook.jazoest = jazoet;
                facebook.Uidclone = fb_av;
                facebook.fb_eav = fbeav;
                facebook.FaceBookInfomation();
                if (facebook.FbName == "not_id")
                {
                    SaveFile(PathError, emmail);
                    appExtension.LoadGrid(row, emmail, dtgrvdata);
                    FailCount += 1;
                    UpdateCount();
                }    
                else if (facebook.FbName == "error")
                {
                    trycount += 1;
                    if(trycount >= 3)
                    {
                        SaveFile(PathError, emmail);
                        appExtension.LoadGrid( row, emmail, dtgrvdata);
                        FailCount += 1;
                        UpdateCount();
                        return;
                    }    
                    goto startcheck;
                } 
                else if (facebook.FbName == "checkpoint")
                {
                    try
                    {
                        trycountcp += 1;
                        if (trycountcp >= 3)
                        {
                            SaveFile(PathError, emmail);
                            appExtension.LoadGrid(row, emmail, dtgrvdata);
                            FailCount += 1;
                            UpdateCount();
                            SaveFile("checkpointcookie.txt", Cookie);
                            //File.AppendAllText("checkpointcookie.txt", Cookie + "\r\n");
                            return;
                        }
                        goto startcheck;
                    }
                    catch { }
                }    
                else
                {
                    SaveFile(PathSuccess, emmail + DataSeperator + facebook.ID + DataSeperator + facebook.FbName + DataSeperator + facebook.BirthDay + DataSeperator + facebook.HomeTown  + DataSeperator  + facebook.Friend_Count + DataSeperator + facebook.Follow_Count + DataSeperator + facebook.CreatedDay + DataSeperator + facebook.LatsOnline);
                    appExtension.LoadGridSuccess(facebook, row, emmail, dtgrvdata);
                    successCount += 1;
                    UpdateCount();
                }
                CheckedCount += 1;
                UpdateCount();
            }
            catch { }
        }
        private void SaveFile(string path, string content)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    File.AppendAllText(path, content + "\r\n");
                });
            }
            catch { }
        }
        
        private void UpdateCount()
        {
            try
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    lbsuccess.Text = successCount.ToString();
                    lbfail.Text = FailCount.ToString();
                    lbprocess.Text = CheckedCount.ToString() + " / " + TotalCount.ToString();
                });
            }
            catch { }
        }
        private void btnopenemail_Click(object sender, EventArgs e)
        {
            string OpenfileStatus = AppExtension.OpenfileDialog("File email á");
            if (OpenfileStatus  == "chưa có mở")
            {
                return;
            }
            txtemail.Text = OpenfileStatus;
            TotalCount = Convert.ToInt32(File.ReadAllLines(OpenfileStatus).Length);
        }

        private void btnopencookie_Click(object sender, EventArgs e)
        {
            string OpenfileStatus = AppExtension.OpenfileDialog("File cookie á");
            if (OpenfileStatus == "chưa có mở")
            {
                return;
            }
            txtcookiefile.Text = OpenfileStatus;
        }

        private void lbquestimesleep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppExtension.MessageBoxShow(AppExtension.ShowFaq(1), 1);
        }

        private void lbquesnumthread_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppExtension.MessageBoxShow(AppExtension.ShowFaq(2), 1);
        }
        private void SetupData()
        {
            isSetupsucces = false;
            DateFormat = DateTime.Now.ToString("dd-mm-yyy hh-mm");
            TempdataSave = Application.StartupPath + "\\data\\temp\\" + "temp_fbdata_" + DateFormat + ".txt";
            string[] CookiesFile = File.ReadAllLines(txtcookiefile.Text);
            string cok = "";
            foreach (string cookie in CookiesFile)
            {
                cok = cookie;
                if(cok.Contains("useragent="))
                {
                   cok = Regex.Replace(cookie, "useragent=([a-zA-Z0-9]{100,300})", "");
                }
                Facebook facebook = new Facebook();
                facebook.Cookie = cok;
                string FacebookIdentifyCodeStatus = facebook.FacebookIdentifyCode();
                if (FacebookIdentifyCodeStatus == "die" || FacebookIdentifyCodeStatus == "error")
                {
                    goto END_W;
                }
                string FacebookTokenStatus = "";
                if(cbbtypetoken.SelectedIndex !=1)
                {
                   FacebookTokenStatus =  facebook.FacebookTokenNormal();
                }
                else { FacebookTokenStatus = facebook.FacebookTokenBussine(); }
                if (FacebookTokenStatus == "die" || FacebookTokenStatus == "error")
                {
                    goto END_W;
                }
                string FacebookIdPageStatus = facebook.FacebookPageid();
                if (FacebookIdPageStatus == "die" || FacebookIdPageStatus == "not_a_page" || FacebookIdPageStatus == "error")
                {
                    goto END_W;
                }
                foreach (string Idpage in facebook.Listidpage)
                {
                    string ContentSave = facebook.Token + DataSeperator + cookie + DataSeperator + Idpage + DataSeperator + facebook.fb_dtsg + DataSeperator + facebook.jazoest + DataSeperator + facebook.fb_av + DataSeperator + facebook.fb_eav;
                    File.AppendAllText(TempdataSave, ContentSave + "\r\n");
                }    
                END_W:;
            }
            if (!File.Exists(TempdataSave))
            {
                isSetupsucces = false;
                AppExtension.MessageBoxShow("lỗi setup ! có thể toàn bộ cookie đã die hoặc không thể lấy data...", 3);
                return;
            }
            else
            {
                int CountData = Convert.ToInt32(File.ReadAllLines(TempdataSave).Length);
                int CountEmail = Convert.ToInt32(File.ReadAllLines(txtemail.Text).Length);
                if (CountEmail >= 50)
                {
                    if(CountData <= 1)
                    {
                        isSetupsucces = false;
                        AppExtension.MessageBoxShow("dữ liệu facebook quá ít ! nhỏ hơn 1, nên không thể chạy ! vui lòng thêm cookie...", 3);
                        return;
                    }    
                }    
            }
            isSetupsucces = true;
            btnstart.PerformClick();
        }
        private void btnsetup_Click(object sender, EventArgs e)
        {
            lbstatus.Text = "đang setup...";
            if (txtcookiefile.Text.Length < 3 || txtemail.Text.Length < 3)
            {
                AppExtension.MessageBoxShow("Thiếu file đầu vào email hoặc cookie !", 3);
                return;
            }
            new Thread(() =>
            {
              SetupData();
            }).Start();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            
            try
            {
                isstop = true;
                //this.Invoke((MethodInvoker)delegate ()
                //{
                //    btnstart.Enabled = true;
                //    btnstop.Enabled = false;
                //});
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            AppExtension.LoadApp(chkuseragent);
            //lbaccount.Text = user;
            //lbexpday.Text = expdate;
        }
        private void LoadData()
        {
            cbbtypetoken.SelectedIndex = 1;
            try
            {
                FacebookInfo.FacebookAdminPage = "https://m.facebook.com/presma/user_search_typeahead/?search_mode=ANYONE_EXCEPT_VERIFIED_ACCOUNT&av=";
                FacebookInfo.FacebookGraph = "https://graph.facebook.com/";
                FacebookInfo.FacebookHomePage = "https://mbasic.facebook.com/";
                FacebookInfo.FacebookPageApi = "https://graph.facebook.com/me/accounts?fields=administrator,name&pretty=1&limit=100&access_token=";
                FacebookInfo.FacebookGraphApiWWW = "https://www.facebook.com/api/graphql";
                FacebookInfo.FacebookTokenNormal = "https://m.facebook.com/composer/ocelot/async_loader/?publisher=feed";
                FacebookInfo.FacebookBussineToken = "https://business.facebook.com/business_locations/?page_id#_=_";
                FacebookInfo.ContentTypeGetcre = "Text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                FacebookInfo.UserAgentGetcre = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36";
                FacebookInfo.FriendPath = "/friends?limit=5000&fields=id,name&access_token=";
                FacebookInfo.FollowPath = "/subscribers?access_token=";
                FacebookInfo.AlbumPath = "/albums?access_token=";
                FacebookInfo.RegexLastOn = "updated_time\": \"(.*?)\"";
            }
            catch { }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                isstop = true;
                Environment.Exit(0);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void uIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(DataGridViewRow dataGridViewRow in dtgrvdata.SelectedRows)
            {

            }    
        }
    }
}
