using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (isPrimeNumber(sum))
                    {
                        answer++;
                    }
                }
            }
        }
        
        return answer;
    }
        
        bool isPrimeNumber(int number)
        {
            for (int i = 2; i < number; ++i)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
}