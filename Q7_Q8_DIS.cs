using System;

namespace ConsoleApp8
{
    class Program
    {

        public static int GoldRod(int rodLength)
        {
            try
            {
                int n = rodLength;
                // make all possible cuts and get the maximum
                int max = 0;
                for (int i = 1; i < n; i++)
                {
                    // Either this cut will produce the max product OR need to make further cuts
                    max = Math.Max(max, Math.Max(i * (n - i), i * GoldRod(n - i)));
                }

                return max; //return the max of all
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool DictSearch(string[] userDict, string keyword)
        {
            try
            {
                bool b = false;
                foreach (string s in userDict)
                {
                    // Base condition to check if string and keyword have the same length
                    if (s.Length == keyword.Length)
                    {
                        int dist = 0;
                        for (int i = 0; i < s.Length; i++)
                        {
                            // compare each character of the string and the keyword and for every unmatch, increment
                            // the count and if its more than 2, break and return to for condition
                            if (s[i] != keyword[i])
                                dist++;
                            if (dist >= 2)
                                break;
                        }
                        //if there is one or less match, set flag to true and return the same
                        if (dist <= 1)
                        {
                            b = true;
                            break;
                        }
                    }
                }
                //Return true if one or less unmatch
                if (b == true)
                    return b;
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
