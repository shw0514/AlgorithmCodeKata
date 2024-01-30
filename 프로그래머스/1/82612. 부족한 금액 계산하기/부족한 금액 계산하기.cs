using System;

class Solution
{
    public long solution(int price, long money, int count)
    {
        long total = 0;
        for (int i = 0; i <= count; i++)
        {
            total += price * i;
        }
        return (total - money)<0 ? 0: total-money;
    }
}