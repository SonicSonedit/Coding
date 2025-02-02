using System.Runtime.InteropServices;

namespace Common.Runtime.Windows
{
    [StructLayout(LayoutKind.Sequential)]
    public struct TrackMouseEvents
    {
        public int cbSize;
        public uint dwFlags;
        public IntPtr hwndTrack;
        public uint dwHoverTime;
    }
}
