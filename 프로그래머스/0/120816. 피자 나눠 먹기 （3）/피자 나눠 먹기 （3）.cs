using System;

public class Solution {
    public int solution(int slice, int n) {
        int answer = 0;
        answer = n / slice;
        if (n % slice >= 1)
        {
            answer++;
        }
        return answer;
    }
}