using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(string X, string Y) {
        List<char> answer = new List<char>();
        List<char> x = X.ToList();
        List<char> y = Y.ToList();
        x.Sort();
        y.Sort();
        
        int indexX = 0;
        int indexY = 0;
        while (indexX < x.Count && indexY < y.Count)
        {
            if (x[indexX] == y[indexY])
            {
                answer.Add(x[indexX]);
                ++indexX;
                ++indexY;
            }
            else if (x[indexX] > y[indexY])
                ++indexY;
            else 
                ++indexX;
        }
        if (answer.Count() == 0) 
            return "-1";
        if (answer[answer.Count() - 1] == '0') 
            return "0";
        
        answer.Reverse();
        return new string(answer.ToArray());
    }
}