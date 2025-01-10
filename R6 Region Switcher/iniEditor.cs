using System.Windows.Forms;
using System.Text;
using System.Runtime.InteropServices;

namespace R6_Region_Switcher
{
    class iniEditor
    {
        [DllImport("kernel32.dll")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public static long WriteData(string path, string section, string key, string data)
        {
            return WritePrivateProfileString(section, key, data, path);
        }
        public static string ReadData(string path, string section, string key, string defaultValue = null)
        {
            StringBuilder temp = new StringBuilder(255);
            GetPrivateProfileString(section, key, defaultValue, temp, 255, path);
            return temp.ToString();
        }
    }
}
