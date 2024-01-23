using System;

public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        if (-10000000 <= a && -10000000 <= b && a <=10000000 && b <= 10000000)
        {
            if (a <= b)
            {
                for (int i = a; i <= b; i++)
                {
                    answer += i;
                }
            }
            if (a > b)
            {
                for (int j = b; j <= a; j++)
                {
                    answer += j;
                }
            }
        }
        
        
        return answer;
    }
}