using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOffice.Helper
{
    public class AppTool
    {
        public static string[] OpenFileDialogShow()
        {
            OpenFileDialog openFiles = new OpenFileDialog();
            openFiles.Filter = InitSetting.OpenFileDialogFilter;
            openFiles.FilterIndex = InitSetting.OpenFileDialogFilterIndex;
            openFiles.Title = InitSetting.OpenFileDialogTitle;
            openFiles.Multiselect = true;
            openFiles.ShowDialog();
            return openFiles.FileNames;
        }
    }
}
