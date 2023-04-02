public class Solution {
    public int FindNumbers(int[] nums) {
        int result = 0;
        int lengthOfNum = 0;
        for(int numsIndex = 0; numsIndex < nums.Length; numsIndex++)
        {
            lengthOfNum = $"{nums[numsIndex]}".Length;
            
            if (lengthOfNum % 2 == 0)
            {
                result++;
            }
        }
        
        return result;
    }
}