using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] str = s.Split();
        for (int i =0; i < str.Length; i++)
        {
            for (int j = 0; j < str[i].Length; j++)
            {
                if (j == 0)
                {
                    answer += Char.ToUpper(str[i][j]);
                    continue;
                }
                if (j % 2 == 0)
                {
                    answer += Char.ToUpper(str[i][j]);
                }
                else
                {
                    answer += Char.ToLower(str[i][j]);
                }
            }
            if (i != str.Length -1)
            {
                answer += " ";
            }
        }
        return answer;
    }
}