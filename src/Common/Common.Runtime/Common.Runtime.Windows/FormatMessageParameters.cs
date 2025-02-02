using System.Runtime.InteropServices;

namespace Common.Runtime.Windows
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FormatMessageParameters
    {
        [MarshalAs(UnmanagedType.LPWStr)]
        public string Arg0;
        public char Arg1;
        public int Arg2;
    }
}
