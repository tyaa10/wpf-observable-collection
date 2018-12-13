using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices;
using System.Windows;

namespace WebBrowserWpf
{
    [ComVisibleAttribute(true)]
    public class HtmlBridge
    {
        [ComVisibleAttribute(true)]
        public void TestCs(int a, int b)
        {
            int c = a + b;
            //MessageBox.Show("Result: " + a + " + " + b + " = " + c.ToString());
        }

        [ComVisibleAttribute(true)]
        public int TestCs2(int a, int b)
        {
            return a + b;
        }
    }
}