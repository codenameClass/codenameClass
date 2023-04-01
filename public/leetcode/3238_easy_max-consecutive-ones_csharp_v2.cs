public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int highestNumberResult = nums[0];
        
        int currentNumber = 0;
        for (int numberIndex = 0; numberIndex < nums.Length; numberIndex++)
        {
            if (nums[numberIndex] == 1)
            {
                currentNumber++;
                highestNumberResult = Math.Max(highestNumberResult, currentNumber);
            }
            else
            {
                currentNumber = 0;
            }
        }
        
        return highestNumberResult;
    }
}