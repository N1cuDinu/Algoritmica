using System;

namespace MoveZeroes // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public void MoveZeroes(int[] nums)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[j] = nums[i];
                    j++;
                }
            }
            for (int i = j; i < nums.Length; i++)
            {
                nums[i] = 0;
            }


        }
    }
}