using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Common.Runtime.Windows.Hotkeys
{
    public static partial class WinApi
    {
        [DllImport("kernel32.dll")]
        public static extern uint GetLastError();

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int FormatMessage
        (
            MessageFormat dwFlags,
            string lpSource,
            uint dwMessageId,
            uint dwLanguageId,
            StringBuilder lpBuffer,
            int nSize,
            ref FormatMessageParameters vaList
         );

        public static string GetWinErrorCodeText(uint errorCode)
        {
            var buffer = new StringBuilder(512);
            var dummy = new FormatMessageParameters();

            var result = FormatMessage
            (
                MessageFormat.FORMAT_MESSAGE_FROM_SYSTEM | MessageFormat.FORMAT_MESSAGE_IGNORE_INSERTS,
                "%1",
                errorCode,
                0,
                buffer,
                buffer.Capacity,
                ref dummy
            );

            if (result != 0)
                Debugger.Break();

            return buffer.ToString();
        }
    }
}