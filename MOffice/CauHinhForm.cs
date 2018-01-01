using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MOffice.Helper;

namespace MOffice
{
    public partial class CauHinhForm : Form
    {
        MOfficeEntities db;
        SqlConnectionStringBuilder builder;

        public CauHinhForm()
        {
            InitializeComponent();
        }

        private void btnCheckConnect_Click(object sender, EventArgs e)
        {
            FSetConnectionString();
            builder.ConnectTimeout = 3;
            db.Database.Connection.ConnectionString = builder.ConnectionString;
            try
            {
                db.Database.Connection.Open();
                db.Database.Connection.Close();
                Msg.Info(Messages.KetNoiMayChuThanhCong);
            }
            catch (Exception)
            {
                Msg.Error(Messages.KetNoiMayChuThatBai);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            FSetConnectionString();
            string _connectString = InitSetting.ConnectStringMetadata + "'" + builder.ConnectionString + "'";

            builder.ConnectTimeout = 3;
            db.Database.Connection.ConnectionString = builder.ConnectionString;
            try
            {
                db.Database.Connection.Open();
                db.Database.Connection.Close();
                if (MessageBox.Show(Messages.KetNoiThanhCongLuuMayChu, InitSetting.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(InitSetting.ExeConfigFile);
                    XmlNode node = doc.DocumentElement.SelectSingleNode("/configuration/connectionStrings");
                    foreach (XmlNode item in node.ChildNodes)
                    {
                        if (item.Attributes["name"].InnerText == "MOfficeEntities")
                        {
                            item.Attributes["connectionString"].InnerText = _connectString;
                        }
                        else if (item.Attributes["name"].InnerText == "MOffice.Properties.Settings.MOfficeConnectionString")
                        {
                            item.Attributes["connectionString"].InnerText = builder.ConnectionString;
                        }
                    }
                    doc.Save(InitSetting.ExeConfigFile);
                    Application.Restart();
                }
                
            }
            catch (Exception)
            {
                Msg.Error(Messages.KetNoiThatBaiKhongLuuMayChu);
            }
        }

        private void CauHinhForm_Load(object sender, EventArgs e)
        {
            db = new MOfficeEntities();
            builder = new SqlConnectionStringBuilder(db.Database.Connection.ConnectionString);

            txtServerName.Text = builder.DataSource;

            if (!builder.IntegratedSecurity)
            {
                radWindowsAuth.Checked = false;
                radSqlServerAuth.Checked = true;
                txtAccount.Text = builder.UserID;
                txtPassword.Text = builder.Password;
            }
            else
            {
                radWindowsAuth.Checked = true;
                radSqlServerAuth.Checked = false;
            }

            FCheckChangeAuth();

            txtDatabase.Text = builder.InitialCatalog;
        }

        private void radSqlServerAuth_CheckedChanged(object sender, EventArgs e)
        {
            FCheckChangeAuth();
        }

        private void FCheckChangeAuth()
        {
            if (radSqlServerAuth.Checked)
            {
                txtAccount.Enabled = true;
                txtPassword.Enabled = true;
            }
            else
            {
                txtAccount.Enabled = false;
                txtPassword.Enabled = false;
            }
        }

        private void FSetConnectionString()
        {
            builder.Clear();
            builder.DataSource = txtServerName.Text;
            if (radSqlServerAuth.Checked)
            {
                builder.IntegratedSecurity = false;
                builder.UserID = txtAccount.Text;
                builder.Password = txtPassword.Text;
            }
            else
            {
                builder.IntegratedSecurity = true;
            }
            builder.InitialCatalog = txtDatabase.Text;
        }
    }
}
