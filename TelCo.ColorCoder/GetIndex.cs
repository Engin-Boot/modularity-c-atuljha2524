using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    partial class Program
    {
        private static int GetIndex(Color[] colorMap, Color color)
        {
            index = -1;
            for (int i = 0; i < colorMap.length; i++) {
                if (colorMap[i] == color) {
                    return i;
                }
            }
            return index;
        }
    }
}

