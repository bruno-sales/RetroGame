using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroGame.Extensions
{
    public static class ListExtension
    {
        public static void Shuffle(this List<int> list)
        {
            var random = new Random();
            var n = list.Count;

            while (n > 1)
            {
                n--;
                var k = random.Next(n + 1);
                (list[k], list[n]) = (list[n], list[k]);
            }
        }
    }
}
