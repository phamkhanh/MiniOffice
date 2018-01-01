using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MOffice.Helper
{
    public class InitSetting
    {
        public static string AppName = "Mini Office";
        public static string DesignedBy = "phamkhanh1811@gmail.com";

        public static string ConnectStringMetadata = "metadata=res://*/MOfficeEdm.csdl|res://*/MOfficeEdm.ssdl|res://*/MOfficeEdm.msl;provider=System.Data.SqlClient;provider connection string=";
        public static string ExeConfigFile = Application.StartupPath + "\\" + Application.ProductName + ".exe.config";
        public static string AppSettingsFile = "AppSettings.xml";

        public static string DirectoryVbDen = "\\QUANLYVANBAN\\DEN\\" + DateTime.Now.Year + "\\";
        public static string DirectoryVbDi = "\\QUANLYVANBAN\\DI\\" + DateTime.Now.Year + "\\";

        public static int SoVanBanDen = 1;

        public static string OpenFileDialogFilter = "All files (*.*)|*.*";
        public static int OpenFileDialogFilterIndex = 0;
        public static string OpenFileDialogTitle = "Chọn các file liên quan";
    }
}
