public class Solution {
    public int[] RunningSum(int[] nums) {

        int[] results = new int[nums.Count()];
        if(nums.Count() < 1) return results;

        results[0] = nums[0];
        if(nums.Count() < 2) return results;

        for(int numsIndex = 1; numsIndex < nums.Count(); numsIndex++)
        {
            results[numsIndex] = results[numsIndex - 1] + nums[(numsIndex)];
        }

        return results;
    }
}