using System;

public class Solution {
    public int solution(int num1, int num2) {
        if (num1 >= 0 && num1 <= 100 && num2 >= 0 && num2 <= 100)
        {
            float num1_f = (float)num1;
            float num2_f = (float)num2;
            float answer_f = (num1_f / num2_f) * 1000;
            int answer = (int)answer_f;
            return answer;
        }
        return -1;
    }
}