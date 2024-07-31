using System;

public class Solution {
    public float solution(float price) {
        float answer = 0;
        if (price >= 100000 && price < 300000)
        {
            answer += price;
            answer -= price * 0.05f;
        }
        else if (price >= 300000 && price < 500000)
        {
            answer += price;
            answer -= price * 0.1f;
        }
        else if (price >= 500000)
        {
            answer += price;
            answer -= price * 0.2f;
        }
        else {answer = price;}
        return (int)answer;
    }
}