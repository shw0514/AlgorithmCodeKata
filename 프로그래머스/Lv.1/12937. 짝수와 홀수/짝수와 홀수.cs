public class Solution {
    public string solution(int num) {
        string answer = "Even";
        string answer_n = "Odd";
        if (num % 2 == 0)
        {
            return answer;    
        }
        return answer_n;
    }
}