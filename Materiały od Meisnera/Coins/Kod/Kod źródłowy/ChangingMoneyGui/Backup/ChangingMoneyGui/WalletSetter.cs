using System;
using System.Collections.Generic;
using System.Text;

namespace ChangingMoneyGui
{
    public static class WalletSetter
    {
        public static int[] RandomWallet(int count, int[] max)
        {
            int[] values = new int[count];

            Random r = new Random();
            for (int i = 0; i < count; i++)
                values[i] = r.Next(0, max[i % max.Length]);

            return values;
        }

        public static int[] SetAmount(int amount)
        {
            List<int> count = new List<int>(9);

            int[] values = new int[] { 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            foreach (int value in values)
            {
                int c = (int)(amount / value);
                amount -= c * value;
                count.Add(c);
            }

            count.Reverse();
            return count.ToArray();
        }
    }
}
