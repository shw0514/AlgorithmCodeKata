using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int rightNumber = 0;
        int deletedNumber = 0;
        for (int i = 0; i < lottos.Length; i++)
        {
            if (lottos[i] == 0) deletedNumber++;
            if (lottos.Contains(win_nums[i])) rightNumber++;
        }
        int minRank = rightNumber;
        int maxRank = deletedNumber + rightNumber;
        if (minRank == 0) minRank++;
        if (maxRank == 0) maxRank++;
        int[] answer = new int[] {7-maxRank, 7-minRank};
        return answer;
    }
}