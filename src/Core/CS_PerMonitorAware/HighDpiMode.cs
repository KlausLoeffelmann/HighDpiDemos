using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;
using System.Windows.Forms;

namespace PerMonitorAware
{
    public enum PROCESS_DPI_AWARENESS
    {
        PROCESS_DPI_UNINITIALIZED = -1,
        PROCESS_DPI_UNAWARE = 0,
        PROCESS_SYSTEM_DPI_AWARE = 1,
        PROCESS_PER_MONITOR_DPI_AWARE = 2
    }

    public static class ApplicationExtender
    {
        public const int DPI_AWARENESS_CONTEXT_UNAWARE = -1;
        public const int DPI_AWARENESS_CONTEXT_SYSTEM_AWARE = -2;
        public const int DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE = -3;
        public const int DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2 = -4;

        // for Windows vista to windows 8.
        [DllImport("user32.dll", SetLastError = true)]
        [ResourceExposure(ResourceScope.None)]
        public static extern bool IsProcessDPIAware();

        // for Windows vista to windows 8.
        [DllImport("user32.dll", SetLastError = true)]
        [ResourceExposure(ResourceScope.None)]
        public static extern bool SetProcessDPIAware();

        // for windows 8.1 and above 
        [DllImport("ShCore.dll", SetLastError = true)]
        [ResourceExposure(ResourceScope.None)]
        public static extern int SetProcessDpiAwareness(PROCESS_DPI_AWARENESS awareness);

        // for windows 8.1 and above 
        [DllImport("ShCore.dll", SetLastError = true)]
        [ResourceExposure(ResourceScope.None)]
        public static extern int GetProcessDpiAwareness(IntPtr processHandle, out PROCESS_DPI_AWARENESS awareness);

        // for Windows 10 version RS2 and above
        [DllImport("user32.dll", SetLastError = true)]
        [ResourceExposure(ResourceScope.None)]
        public static extern bool SetProcessDpiAwarenessContext(int dpiFlag);

        // Available in Windows 10 version RS1 and above.
        [DllImport("user32.dll")]
        [ResourceExposure(ResourceScope.None)]
        public static extern int GetThreadDpiAwarenessContext();

        // Available in Windows 10 version RS1 and above.
        [DllImport("user32.dll")]
        [ResourceExposure(ResourceScope.None)]
        public static extern bool AreDpiAwarenessContextsEqual(int dpiContextA, int dpiContextB);

        public static bool SetHighDpiMode(HighDpiMode highDpiMode)
        {
            int dpiFlag;

            switch (highDpiMode)
            {
                case HighDpiMode.SystemAware:
                    dpiFlag = DPI_AWARENESS_CONTEXT_SYSTEM_AWARE;
                    break;
                case HighDpiMode.PerMonitor:
                    dpiFlag = DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE;
                    break;
                case HighDpiMode.PerMonitorV2:
                    dpiFlag = DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2;
                    break;
                default:
                    dpiFlag = DPI_AWARENESS_CONTEXT_UNAWARE;
                    break;
            }

            if (!SetProcessDpiAwarenessContext(dpiFlag))
            {
                return false;
            }

            return true;
        }
    }

    public enum HighDpiMode
    {
        NotSet,
        DpiUnaware,
        SystemAware,
        PerMonitor,
        PerMonitorV2
    }
}
