public class Solution {
    public double solution(int[] arr) {
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            
            sum += arr[i];
        }
        double result = sum / arr.Length;
        return result;
    }
}