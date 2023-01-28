using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MainApplication
{
    public partial class FormMain : Form
    {
        public delegate bool Win32Callback(IntPtr hwnd, IntPtr lParam);
        const uint WM_SETFONT = 0x0030;
        public Process proc;
        private string nameProc = "";

        public class TestApi
        {
            [DllImport("User32.dll", CharSet = CharSet.Auto)]
            public static extern IntPtr SendMessage(IntPtr hWnd, uint uMsg, IntPtr wParam, bool lParam);
            [DllImport("User32.dll", CharSet = CharSet.Auto)]
            public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
            public delegate bool EnumWindowsProc(IntPtr hwnd, IntPtr lParam);
            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool EnumChildWindows(IntPtr hwndParent, EnumWindowsProc lpEnumFunc, IntPtr lParam);
        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenChild_Click(object sender, EventArgs e)
        {
            if (File.Exists("ChildApplication.exe"))
            {
                proc = Process.Start("ChildApplication.exe");
                nameProc = proc.ProcessName;
            }
            else
            {
                MessageBox.Show("Тестовая программа ChildApplication.exe не найдена. Продолжение не возможно", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void buttonSendStyle_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName(nameProc).Length == 0)
            {
                MessageBox.Show("Дочерний процесс не запущен.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                List<IntPtr> intPtrs = GetChildWindows(proc.MainWindowHandle);
                FontDialog font1 = new FontDialog();
                if (font1.ShowDialog() == DialogResult.OK)
                {
                    IntPtr hFont1 = font1.Font.ToHfont();
                    for (int i = 0; i < intPtrs.Count; i++)
                    {
                        TestApi.SendMessage(intPtrs[i], WM_SETFONT, hFont1, true);
                    }
                }
            }
        }

        private static bool EnumWindowsProc(IntPtr handle, IntPtr pointer)
        {
            GCHandle gch = GCHandle.FromIntPtr(pointer);
            List<IntPtr> list = gch.Target as List<IntPtr>;
            if (list == null)
                throw new InvalidCastException("GCHandle Target could not be cast as List<IntPtr>");
            list.Add(handle);
            return true;
        }

        public static List<IntPtr> GetChildWindows(IntPtr parent)
        {
            List<IntPtr> result = new List<IntPtr>();
            GCHandle listHandle = GCHandle.Alloc(result);
            try
            {
                Win32Callback childProc = EnumWindowsProc;
                GCHandle.ToIntPtr(listHandle);
                TestApi.EnumChildWindows(parent, EnumWindowsProc, GCHandle.ToIntPtr(listHandle));
            }
            finally
            {
                if (listHandle.IsAllocated)
                    listHandle.Free();
            }
            return result;
        }
    }
}
