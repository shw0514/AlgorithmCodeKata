using System;

public class Solution {
    public int solution(int age) {
        
        int koreanAge = age - 1;
        
        if (age >= 0 && age <= 120)
        {
            int answer = 2022 - koreanAge;
            return answer;
        }
        return -1;
    }
}