using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        char[] temp = s.ToCharArray();
        Array.Sort(temp);
        Array.Reverse(temp);
        return new string(temp);
    }
}