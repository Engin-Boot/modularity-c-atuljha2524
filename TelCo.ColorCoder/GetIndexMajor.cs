using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    partial class Program
    {
        private static int GetIndexMajor(Color color)
        {
            index = -1;
            for (int i = 0; i < colorMapMajor.Length; i++) {
                if (colorMapMajor[i] == color) {
                    return i;
                }
            }
            return index;
        }
    }
}

