#region Header
// CST150W3A7 >CST150W3A7 >NativeMethods.cs\n Copyright (C) , 2021\nCreated 14 08, 2021
#endregion

using System.Runtime.InteropServices;

namespace CST150W3A7 {
    internal static class NativeMethods {
        private const string Kernel32 = "Kernel32.dll";

        [DllImport(Kernel32, EntryPoint = "AllocConsole", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern void AllocConsole();

        [DllImport(Kernel32, EntryPoint = "FreeConsole", SetLastError = true)]
        public static extern void FreeConsole();
    }
}