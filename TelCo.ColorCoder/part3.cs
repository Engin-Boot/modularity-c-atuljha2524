using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
  partial class Program
  {
        /// <summary>
        /// Static constructor required to initialize static variable
        /// </summary>
        static Program()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
  }
}
