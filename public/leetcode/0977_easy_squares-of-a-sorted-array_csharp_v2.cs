public class Solution {
    public int[] SortedSquares(int[] nums) {
        int leftIndex = 0, 
            numsLength = nums.Length,
            rightIndex = numsLength - 1,
            currentSquare = 0;

        int[] result = new int[numsLength];

        for (int currentIndex = numsLength - 1; currentIndex >= 0; currentIndex--)
        {
            currentSquare = Math.Abs(nums[leftIndex]) < Math.Abs(nums[rightIndex]) 
                        ? nums[rightIndex--]
                        : nums[leftIndex++];
                        
            result[currentIndex] = currentSquare * currentSquare;
        }

        return result;
    }
}