using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOffice.Helper
{
    public class Msg
    {
        public static void Show(string message, MessageBoxButtons button = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            MessageBox.Show(message, InitSetting.AppName, button, icon);
        }

        public static void Error(string message)
        {
            Show(message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Stop(string message)
        {
            Show(message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        public static void Info(string message)
        {
            Show(message, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Warning(string message)
        {
            Show(message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
