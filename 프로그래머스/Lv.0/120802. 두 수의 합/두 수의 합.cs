using System;

public class Solution {
    public int solution(int num1, int num2) {
        if(num1 >= -50000 && num1 <= 50000 && num2 >= -50000 && num2 <= 50000)
        {
            int answer = num1 + num2;
            return answer;
        }
        return 0;
    }
}