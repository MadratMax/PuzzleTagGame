using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleTag.RandomGenerator
{
    class NumberGenerator
    {
        private static HashSet<int> storage = new HashSet<int>();
        private static List<int> range = new List<int>();

        public static int GetRandomFromRange()
        {
            var x = range[0];
            range.RemoveAt(0);
            return x;
        }

        public static List<int> GetRandomRange(int min, int max)
        {
            while (storage.Count != max)
            {
                storage.Add(new Random().Next(min, max + 1));

                if (storage.Count >= max)
                {
                    range = storage.ToList();
                    Reset();
                    return range;
                }
            }

            return null;
        }

        public static void Reset()
        {
            storage = null;
            storage = new HashSet<int>();
        }
    }
}
