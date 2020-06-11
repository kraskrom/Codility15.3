/*
An array A consisting of N integers is given. A triplet (P, Q, R) is triangular if it is possible to build a triangle with sides of lengths A[P], A[Q] and A[R]. In other words, triplet (P, Q, R) is triangular if 0 ≤ P < Q < R < N and:

A[P] + A[Q] > A[R],
A[Q] + A[R] > A[P],
A[R] + A[P] > A[Q].
For example, consider array A such that:

  A[0] = 10    A[1] = 2    A[2] = 5
  A[3] = 1     A[4] = 8    A[5] = 12
There are four triangular triplets that can be constructed from elements of this array, namely (0, 2, 4), (0, 2, 5), (0, 4, 5), and (2, 4, 5).

Write a function:

class Solution { public int solution(int[] A); }

that, given an array A consisting of N integers, returns the number of triangular triplets in this array.

For example, given array A such that:

  A[0] = 10    A[1] = 2    A[2] = 5
  A[3] = 1     A[4] = 8    A[5] = 12
the function should return 4, as explained above.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [0..1,000];
each element of array A is an integer within the range [1..1,000,000,000].
*/

using System;

namespace Codility15._3
{
    class Solution
    {
        public int solution(int[] A)
        {
            int s = 0;
            Array.Sort(A);
            for (int i = 0; i < A.Length - 2; i++)
            {
                int k = i + 2;
                for (int j = i + 1; j < A.Length - 1; j++)
                {
                    while (k < A.Length && A[i] + A[j] > A[k])
                        k++;
                    s += k - j - 1;
                }
            }
            return s;
        }
    }

    class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            int[] A = { 10, 2, 5, 1, 8, 12 };
            int s = sol.solution(A);
            Console.WriteLine("Solution: " + s);
            //Console.WriteLine("Solution: " + string.Join(", ", s));
        }
    }
}
