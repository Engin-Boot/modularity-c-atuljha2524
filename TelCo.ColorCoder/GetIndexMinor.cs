using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    partial class Program
    {
        private static int GetIndexMinor(Color color)
        {
            index = -1;
            for (int i = 0; i < colorMapMinor.Length; i++) {
                if (colorMapMinor[i] == color) {
                    return i;
                }
            }
            return index;
        }
    }
}

