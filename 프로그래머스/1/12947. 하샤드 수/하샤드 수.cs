using System;

public class Solution {
    public bool solution(int x) {
        int hashard = x;
        int sum = 0;
        do
        {
            sum += x % 10;
            x /= 10;
        } while (x>0);
        bool answer = (hashard % sum == 0) ? true : false;
        return answer;
}
}