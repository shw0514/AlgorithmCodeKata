public class Solution {
    public long[] solution(long n) {
        string temp = n.ToString();
        long[] answer = new long[temp.Length];
        for (int i = 0; i < temp.Length; i++)
        {
            answer[i] = n % 10;
            n /= 10;
        }
        return answer;
    }
}