public class Solution {
    public int[] SortedSquares(int[] nums) {
        var result = new int[nums.Length];

        int startIndex = 0;
        int endIndex = nums.Length - 1;

        int currentIndex = endIndex;
        while (startIndex <= endIndex)
        {
            result[currentIndex] = Math.Abs(nums[endIndex]) > Math.Abs(nums[startIndex])
                ? nums[endIndex] * nums[endIndex--]
                : nums[startIndex] * nums[startIndex++];

            currentIndex--;
        }
            
        return result;
    }
}