using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class CustomComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x > y)
                return 1;
            else if (x < y)
                return -1;
            else
                return 0;
        }
    }
}
