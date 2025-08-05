using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Week3Labs
{
    public static class Palindrome
    {
        public static bool IsPalindrom(string UserString) 
        {
            int L = 0;
            int R = UserString.Length;
            --R;

                while( L < R)
                {
                    if (UserString[L] != UserString[R])
                    {
                        return false;
                    }
                    ++L;
                        --R;
                }
                return true;
        }

    }
}
