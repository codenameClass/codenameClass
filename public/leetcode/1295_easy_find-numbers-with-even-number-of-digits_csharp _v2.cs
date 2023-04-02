public class Solution {
    public int FindNumbers(int[] nums) {
        int result = 0;


        for (int numIndex = 0; numIndex < nums.Length; numIndex++)
        {
            if ( (int)Math.Log10(nums[numIndex]) % 2 != 0)
            {
                result++;
            }
        }

        return result;
    }
}