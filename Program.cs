using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Question 1");
            int[] l1 = new int[] { 5, 6, 6, 9, 9, 12 };
            int target = 9;
            int[] r = TargetRange(l1, target);
            Console.WriteLine(l1.Length);
            //code to print values in the output array r
            foreach (int a in r)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Question 2");
            string s = "University of South Florida";
            string rs = StringReverse(s);
            Console.WriteLine(rs);



            Console.WriteLine("Question 3");
            int[] l2 = new int[] { 2, 2, 3, 5, 6 };
            int sum = MinimumSum(l2);
            Console.WriteLine(sum);


            Console.WriteLine("Question 4");
            string s2 = "Dell";
            string sortedString = FreqSort(s2);
            Console.WriteLine(sortedString);


            Console.WriteLine("Question 5-Part 1");
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };


            int[] intersect1 = Intersect1(nums1, nums2);
            Console.WriteLine("Part 1- Intersection of two arrays is: ");
            DisplayArray(intersect1);

            Console.WriteLine("\n");
            Console.WriteLine("Question 5-Part 2");
            int[] intersect2 = Intersect2(nums1, nums2);
            Console.WriteLine("Part 2- Intersection of two arrays is: ");
            DisplayArray(intersect2);
            Console.WriteLine("\n");


            Console.WriteLine("Question 6");
            char[] arr = new char[] { 'a', 'g', 'h', 'a' };
            int k = 3;
            Console.WriteLine(ContainsDuplicate(arr, k));


            Console.WriteLine("Question 7");
            int rodLength = 4;
            int priceProduct = GoldRod(rodLength);
            Console.WriteLine(priceProduct);


            Console.WriteLine("Question 8");
            string[] userDict = new string[] { "rocky", "usf", "hello", "apple" };
            string keyword = "hhllo";
            Console.WriteLine(DictSearch(userDict, keyword));

            Console.WriteLine("Question 9");
            SolvePuzzle();

        }

        public static void DisplayArray(int[] a)
        {
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
        }


        public static int[] TargetRange(int[] l1, int t)
        {
            try
            {
                int[] index = new int[] { -1, -1 };
                // Transversing through the input array 

                if (l1.Length > 0)
                {


                    for (int i = 0; i < l1.Length; i++)
                    {
                        //Checks if the value in the array matches the target value, if so the control moves to the next if statement
                        //In case the value does not match, the value of i is incremented and the process continutes
                        if (l1[i] != t)
                            continue;
                        //The control will come here once there is a match, it checks if the index is equal to -1 which would be true
                        //in case of the first match
                        //This criteria wont be satisfied during the second target match and 

                        if (index[0] == -1)
                            index[0] = i;
                        //the loop will initialise the index for the next element
                        index[1] = i;
                    }
                    return index;
                }
                else
                {
                    return null;
                }


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


        public static string StringReverse(string s)
        {

            Stack<char> rev = new Stack<char>();

            char[] str = s.ToCharArray();
            int length = str.Length;
            char[] ans = new char[length + 1];
            var result = new StringBuilder();

            int i, j;

            try
            {
                if (s.Length > 0)
                {

                    //Transverse through the string 
                    for (i = 0; i < s.Length; ++i)
                    {

                        //split the sentence into words everytime space is found
                        if (s[i] != ' ')
                        {
                            rev.Push(s[i]);
                        }
                        else
                        {
                            //iterates through the stack until the count reaches 0
                            while (rev.Count > 0)
                            {

                                //Append the last element of stack into the result variable 
                                result.Append(rev.Pop());

                            }
                            //when the count reaches 0 for stack, the space is appended
                            //At the end of this statement, the space gets appended and the reversion of one word is completed 
                            result.Append(" ");
                        }
                    }

                    //The statement gets control for the last word of the sentence until stack count reaches 0
                    while (rev.Count > 0)
                    {
                        result.Append(rev.Pop());

                    }
                }
                else
                {
                    return null;
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


            //return the string format for result
            return result.ToString();
        }

        public static int MinimumSum(int[] l2)
        {
            try
            {
                //Initialise the sum to the first element of an array
                int sum = l2[0];
                int len = l2.Length;
                //initialised array to 1 since we will be comparing adjacent elements i and i-1
                int i = 1;
                //Iterate until the length is greater than 1
                //keeping this condition in order to avoid index out of bound error while the value of i is continously incremented
                if (len > 0)
                {
                    while (len > 1)
                    {
                        // if the adjacent values are the same, increment the value at the i-th position
                        if (l2[i] == l2[i - 1])
                        {
                            l2[i]++;
                        }
                        //keep adding the i-th element to the sum in order to calculate the total sum of the array
                        sum = sum + l2[i];
                        //increment i for transversing through the array until len is greater than 1
                        i++;
                        //decrement the count of length until the value reaches 1
                        len--;
                    }
                    return sum;
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception)
            {
                throw;
            }

        }
  
    }
}

        }

    }
}

