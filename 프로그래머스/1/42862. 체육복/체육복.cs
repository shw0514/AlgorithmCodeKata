using System;
using System.Linq;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        Array.Sort(lost);
        Array.Sort(reserve);
        
        foreach(int l in lost)
        {
            foreach(int r in reserve)   
            {
                if (l == r)
                {
                    lost = lost.Where(x => x != l).ToArray();
                    reserve = reserve.Where(x => x != r).ToArray();
                    break;
                }
            }
        }
        int count = 0;
        foreach(int l in lost)
        {
            for (int i = 0; i < reserve.Length; i++)
            {
                if (l - 1 == reserve[i] && reserve[i] != 0
                   || l + 1 == reserve[i] && reserve[i] != 0)
                {
                    reserve[i] = 0;
                    count++;
                    break;
                }
            }
        }
        return n - lost.Length + count;
    }
}