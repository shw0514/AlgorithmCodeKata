using System;

public class Solution {
    public int solution(int n) {
        if (n >= 3 && n <= 1000000)
        {
            for (int i = 1; i < n; i++)
            {
                if (n % i == 1)
                {
                    int x = i;
                    return x;
                }
            } 
        }
        return -1;
    }
}