using System;

public class Solution {
    public int[] solution(int n, int m) {
        int min = n;
        int max = m;
        int[] answer = new int[2];
        int a = min;
        while(true)
        {
            a = max % min;
            max = min;
            
            if(a==0)
            {
                break;
            }
            min = a;
        }
        answer[0] = min;
        answer[1] = n*m/min;
        
        return answer;
    }
}