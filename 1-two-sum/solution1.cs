using System;

public class Solution
{
    public static void Main(String[] args)
    {
        Int32[] nums = new Int32[] { 2, 7, 11, 15 };
        Int32 target = 22;
        
        try
        {
            Int32[] results = TwoSum(nums, target);

            foreach (var item in results)
            {
                Console.Write(item + " "); // 1 3
            }
        }
        catch (System.Exception ex)
        {
            Console.WriteLine(ex);
        }

    }

    public static Int32[] TwoSum(Int32[] nums, Int32 target)
    {
        for (Int32 i = 0; i < nums.Length - 1; i++)
        {
            for (Int32 j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new Int32[] { i, j };
                }
            }
        }

        throw new Exception("No two sum solution");
    }
}

// Compile: csc solution1.cs
// Run: solution1.exe