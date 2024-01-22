using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        char[] arr = n.ToString().ToCharArray();
        Array.Sort(arr);
        Array.Reverse(arr);
        answer = long.Parse(new string(arr));
        return answer;
    }
}