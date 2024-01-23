public class Solution {
    public int solution(int num) {
        int answer = 0;
        long Lnum = num;
        for (int i = 0; i <= 500; i++)
        {
            if (Lnum == 1)
            {
                return i;
            }
            Lnum = Lnum % 2 == 0 ? Lnum / 2 : Lnum * 3 + 1;
        }
        return -1;
    }
}