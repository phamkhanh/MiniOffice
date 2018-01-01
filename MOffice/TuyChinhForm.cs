using MOffice.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MOffice
{
    public partial class TuyChinhForm : Form
    {
        public TuyChinhForm()
        {
            InitializeComponent();
        }

        private void btnThuMucVanBan_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                XmlDocument doc = new XmlDocument();
                if (File.Exists(InitSetting.AppSettingsFile))
                {
                    doc.Load(InitSetting.AppSettingsFile);
                    XmlNode node = doc.SelectSingleNode("/settings/QuanLyVanBan/Path");
                    folderDialog.SelectedPath = node.InnerText.Trim();
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        lblThuMucVanBan.Text = folderDialog.SelectedPath + "\\";
                        node.InnerText = lblThuMucVanBan.Text.Trim();
                    }
                    doc.Save(InitSetting.AppSettingsFile);
                }
                else
                {
                    string root = String.Format("<settings><QuanLyVanBan><Path>{0}</Path></QuanLyVanBan></settings>", lblThuMucVanBan.Text);
                    doc.LoadXml(root);
                    doc.Save(InitSetting.AppSettingsFile);
                }
            }
        }

        private void TuyChinhForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(InitSetting.AppSettingsFile))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(InitSetting.AppSettingsFile);
                    XmlNode node = doc.SelectSingleNode("/settings/QuanLyVanBan/Path");
                    lblThuMucVanBan.Text = node.InnerText.Trim();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}