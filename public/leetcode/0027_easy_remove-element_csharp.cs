public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int resultCount = 0;
        List<int> elementsToRemove = new();

        foreach (int number in nums)
        {
            if(number != val)
            {
                nums[resultCount++] = number;
            }
        }

        return resultCount;
    }
}