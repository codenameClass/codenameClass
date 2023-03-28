public class Solution {
    public int[] RunningSum(int[] nums) {

        if(nums.Count() < 2) return nums;

        for(int numsIndex = 1; numsIndex < nums.Count(); numsIndex++)
        {
            nums[numsIndex] = nums[numsIndex] + nums[(numsIndex - 1)];
        }

        return nums;
    }
}