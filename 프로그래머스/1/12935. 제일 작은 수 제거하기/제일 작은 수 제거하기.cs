using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> arr_List = new List<int>(arr);
        int min = arr.Min();
        arr_List.Remove(min);
        if (arr_List.Count == 0)
        {
            arr_List.Add(-1);
        }
        return arr_List.ToArray();
    }
}