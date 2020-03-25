using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin
{
    public class Filters
    {
        //test
        /// <summary>
        /// Adds some noise to the bitmap
        /// </summary>
        /// <param name="bitmap">The bitmap to change</param>
        /// <param name="amount">The amount of noise (1-100)</param>
        public static void MiniNoise(Bitmap bitmap, int amount)
        {
            Random rng = new Random();

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color original = bitmap.GetPixel(x, y);
                    Color modified = Color.FromArgb(Clamp(original.R+rng.Next(-amount,amount)), Clamp(original.G + rng.Next(-amount, amount)), Clamp(original.B + rng.Next(-amount, amount)));
                    bitmap.SetPixel(x, y, modified);
                }
            }
        }

        /// <summary>
        /// Clamps a value between 0 and 255
        /// </summary>
        /// <param name="number">The value to clamp</param>
        /// <returns>The clamped value</returns>
        private static int Clamp(int number)
        {
            number = Math.Max(0, number);
            number = Math.Min(255, number);
            return number;
        }
    }
}

