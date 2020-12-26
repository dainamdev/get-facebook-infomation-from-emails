using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fbgif_pro
{
    public class AppExtension
    {
        public static object MessageBoxShow(string message, int type)
        {
            if(type == 1)
            {
                return MessageBox.Show(message, "thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (type == 2)
            {
                return MessageBox.Show(message, "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (type == 3)
            {
                return MessageBox.Show(message, "thông báo nhưng nghiêm trọng hơn", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return MessageBox.Show("NGU !!!!", "BAKAAAAAAA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static string OpenfileDialog(string title)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Textfile |*.txt";
            openFileDialog.Title = title;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return "chưa có mở";
        }
        public static string ShowFaq(int type)
        {
            if (type == 1)
            {
                return "thời gian nghỉ là ....";
            }
            if (type == 2)
            {
                return "số luồng là...";
            }
            return "";
        }
        public static string TimeStampConvert(double timestamp)
        {
            try
            {
                DateTime x = new DateTime();
                x = DateTime.Parse("January 1 1970 12:00:00 am");
                return x.AddSeconds(timestamp).ToString();
            }
            catch { return "error"; }
        }
        public static void DataGridScroll(DataGridView dtgrvdata)
        {
            try
            {
                dtgrvdata.Invoke((MethodInvoker)delegate ()
                {
                    dtgrvdata.FirstDisplayedScrollingRowIndex = dtgrvdata.RowCount - 1;
                });
            }
            catch { }
        }
        public static string DataAnalyze(int Countdata, int EmailListCount)
        {
            if (EmailListCount >= 50)
            {
                if ( Countdata <= 1)
                {
                    return "quá ít";
                }    
                
            }    
            return "mệt vcl";
        }
        public string RandomData(string filedataPath)
        {
            getad:
            try
            {
                var lines = File.ReadAllLines(filedataPath);
                Random rad = new Random();
                var ranline = rad.Next(0, lines.Length);
                var line = lines[ranline];
                return line;
            }
            catch {goto getad; }
        }
        public void ExportError(string ErrorMessage)
        {
            try
            {
                File.AppendAllText("errorLog.txt", ErrorMessage + "\r\n");
            }
            catch {}
        }
        public static void LoadApp(CheckBox chkuseragent)
        {
            try
            {
                if (!File.Exists("useragent_main.txt"))
                {
                    File.Create("useragent_main.txt");
                }
                string ug = File.ReadAllText("useragent_main.txt");
                if (ug.Length >= 3)
                {
                    if (chkuseragent.Checked)
                    {
                        FacebookInfo.UserAgentGetcre = ug;
                    }
                    else
                    {
                        FacebookInfo.UserAgentGetcre = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36";
                    }
                }
                else
                {
                    FacebookInfo.UserAgentGetcre = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36";
                }
            }
            catch { }
        }
        public void LoadGrid(int row, string email, DataGridView dtgrvdata)
        {
                dtgrvdata.Invoke((MethodInvoker)delegate ()
                {
                dtgrvdata.Rows[row].Cells["clemail"].Value = email;
                dtgrvdata.Rows[row].Cells["clstt"].Value = row.ToString();
                dtgrvdata.Rows[row].Cells["cluid"].Value = "0";
                dtgrvdata.Rows[row].Cells["clname"].Value = "0";
                dtgrvdata.Rows[row].Cells["clbirthday"].Value = "0";
                dtgrvdata.Rows[row].Cells["cltown"].Value = "0";
                dtgrvdata.Rows[row].Cells["clfriend"].Value = "0";
                dtgrvdata.Rows[row].Cells["clfollow"].Value = "0";
                dtgrvdata.Rows[row].Cells["clcre"].Value = "0";
                dtgrvdata.Rows[row].Cells["clonline"].Value = "0";
                });
        }
        public void LoadGridSuccess(Facebook facebook, int row, string email, DataGridView dtgrvdata)
        {
            if (facebook != null)
            {
                dtgrvdata.Invoke((MethodInvoker)delegate ()
                {
                    dtgrvdata.Rows[row].Cells["clemail"].Value = email;
                    dtgrvdata.Rows[row].Cells["clstt"].Value = row.ToString();
                    dtgrvdata.Rows[row].Cells["cluid"].Value = facebook.ID;
                    dtgrvdata.Rows[row].Cells["clname"].Value = facebook.FbName;
                    dtgrvdata.Rows[row].Cells["clbirthday"].Value = facebook.BirthDay;
                    dtgrvdata.Rows[row].Cells["cltown"].Value = facebook.HomeTown;
                    dtgrvdata.Rows[row].Cells["clfriend"].Value = facebook.Friend_Count;
                    dtgrvdata.Rows[row].Cells["clfollow"].Value = facebook.Follow_Count;
                    dtgrvdata.Rows[row].Cells["clcre"].Value = facebook.CreatedDay;
                    dtgrvdata.Rows[row].Cells["clonline"].Value = facebook.LatsOnline;
                });
            }
        }
        public static string GetSystemUid()
        {
            string text = @"SOFTWARE\Microsoft\Cryptography";
            string text2 = "MachineGuid";
            string result;
            using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
                {
                    bool flag = registryKey2 == null;
                    if (flag)
                        throw new KeyNotFoundException(string.Format("Key Not Found: {0}", text));
                    object value = registryKey2.GetValue(text2);
                    bool flag2 = value == null;
                    if (flag2)
                        throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
                    string text3 = value.ToString();
                    result = text3;
                }
            }
            return result;
        }
    }
}
