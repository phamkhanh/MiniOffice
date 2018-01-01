using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOffice.Helper
{
    public class Funcs
    {
        private static string _Key = "minioffice@gmail.com";

        public static void AddFormToTabControl(Form frm, TabControl tabMain)
        {
            bool _isExisted = false;

            if (tabMain.TabPages.Count == 0)
            {
                _isExisted = false;
            }
            else
            {
                foreach (TabPage tabItem in tabMain.TabPages)
                {
                    if (tabItem.Text == frm.Text)
                    {
                        _isExisted = true;
                        break;
                    }
                }
            }

            if (!_isExisted)
            {
                AddFormToTab(frm, tabMain);
            }
        }

        private static void AddFormToTab(Form frm, TabControl tabMain)
        {
            TabPage tab = new TabPage(frm.Text);
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Visible = true;
            //frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tabMain.TabPages.Insert(1, tab);
            //frm.Location = new Point((tab.Width - frm.Width) / 2, (tab.Height - frm.Height) / 2);
            tabMain.SelectedTab = tab;
        }

        public static void AddFormToMdiParent(Form frm, Form mdiParent)
        {
            bool _isExisted = false;

            if (mdiParent.MdiChildren.Count() == 0)
            {
                _isExisted = false;
            }
            else
            {
                foreach (Form tabItem in mdiParent.MdiChildren)
                {
                    //tabItem.WindowState = FormWindowState.Minimized;
                    tabItem.Close();
                }

                foreach (Form tabItem in mdiParent.MdiChildren)
                {
                    if (tabItem.Text == frm.Text)
                    {
                        tabItem.Activate();
                        tabItem.WindowState = FormWindowState.Maximized;
                        _isExisted = true;
                        break;
                    }
                }
            }

            if (!_isExisted)
            {
                frm.MdiParent = mdiParent;
                frm.WindowState = FormWindowState.Maximized;
                frm.ControlBox = false;
                frm.Show();
            }
        }

        public static string RejectMarks(string text)
        {
            string[] pattern= new string[1];

            //pattern[0] = "a|(á|ả|à|ạ|ã|ă|ắ|ẳ|ằ|ặ|ẵ|â|ấ|ẩ|ầ|ậ|ẫ)";

            //pattern[1]= "o|(ó|ỏ|ò|ọ|õ|ô|ố|ổ|ồ|ộ|ỗ|ơ|ớ|ở|ờ|ợ|ỡ)";

            //pattern[2] = "e|(é|è|ẻ|ẹ|ẽ|ê|ế|ề|ể|ệ|ễ)";

            //pattern[3] = "u|(ú|ù|ủ|ụ|ũ|ư|ứ|ừ|ử|ự|ữ)";

            //pattern[4] = "i|(í|ì|ỉ|ị|ĩ)";

            //pattern[5] = "y|(ý|ỳ|ỷ|ỵ|ỹ)";

            //pattern[6] = "d|đ";

            pattern[0] = " |\\W";

            for (int i = 0; i < pattern.Length; i++)
            {
                // kí tự sẽ thay thế
                char replaceChar = pattern[i][0];
                MatchCollection matchs = Regex.Matches(text,pattern[i]);
                foreach (Match m in matchs)
                {
                    text = text.Replace(m.Value[0],replaceChar);
                    text = text.Replace("  "," ");
                }
            }
            
            return text;
        }

        public static string RejectUnicode(string text)
        {
            string[] pattern = new string[7];

            pattern[0] = "a|(á|ả|à|ạ|ã|ă|ắ|ẳ|ằ|ặ|ẵ|â|ấ|ẩ|ầ|ậ|ẫ)";

            pattern[1]= "o|(ó|ỏ|ò|ọ|õ|ô|ố|ổ|ồ|ộ|ỗ|ơ|ớ|ở|ờ|ợ|ỡ)";

            pattern[2] = "e|(é|è|ẻ|ẹ|ẽ|ê|ế|ề|ể|ệ|ễ)";

            pattern[3] = "u|(ú|ù|ủ|ụ|ũ|ư|ứ|ừ|ử|ự|ữ)";

            pattern[4] = "i|(í|ì|ỉ|ị|ĩ)";

            pattern[5] = "y|(ý|ỳ|ỷ|ỵ|ỹ)";

            pattern[6] = "d|đ";

            for (int i = 0; i < pattern.Length; i++)
            {

                // kí tự sẽ thay thế

                char replaceChar = pattern[i][0];

                MatchCollection matchs = Regex.Matches(text, pattern[i]);

                foreach (Match m in matchs)
                {

                    text = text.Replace(m.Value[0], replaceChar);

                }

            }

            return text;
        }

        public static string RejectMarksOnlyNumber(string text)
        {
            string[] pattern = new string[1];

            pattern[0] = " |[^\\d]";

            for (int i = 0; i < pattern.Length; i++)
            {
                // kí tự sẽ thay thế
                char replaceChar = pattern[i][0];
                MatchCollection matchs = Regex.Matches(text, pattern[i]);
                foreach (Match m in matchs)
                {
                    text = text.Replace(m.Value[0], replaceChar);
                    text = text.Replace(" ", "");
                }
            }

            return text;
        }

        public static string RejectMarksOnlyAlpha(string text)
        {
            string[] pattern = new string[1];

            pattern[0] = " |(1|2|3|4|5|6|7|8|9|0)";

            for (int i = 0; i < pattern.Length; i++)
            {
                // kí tự sẽ thay thế
                char replaceChar = pattern[i][0];
                MatchCollection matchs = Regex.Matches(text, pattern[i]);
                foreach (Match m in matchs)
                {
                    text = text.Replace(m.Value[0], replaceChar);
                    text = text.Replace(" ", "");
                }
            }

            return text;
        }

        public static void DisplayTrackedEntities(DbChangeTracker changeTracker)
        {
            Console.WriteLine("");

            var entries = changeTracker.Entries();
            foreach (var entry in entries)
            {
                Console.WriteLine("Entity Name: {0}", entry.Entity.GetType().FullName);
                Console.WriteLine("Status: {0}", entry.State);
            }
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------");
        }

        public static string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");
            return input.First().ToString().ToUpper() + String.Join("", input.Skip(1));
        }

        public static string Decrypt(string toDecrypt)
        {
            bool useHashing = true;
            byte[] keyArray;
            byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(_Key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(_Key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        public static string Encrypt(string toEncrypt)
        {
            bool useHashing = true;
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(_Key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(_Key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
    }
}
