public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        // Clear the portion of nums1 that will be used to store the merged result
        // This will resize nums if m is bigger than the current length
        Array.Clear(nums1, m, nums1.Length - m);

        // Copy the elements from nums2 into the end of nums1
        for(int destinationIndex = 0; destinationIndex < n; destinationIndex++)
        {
            nums1[destinationIndex + m] = nums2[destinationIndex];
        }

        Array.Sort(nums1);
    }
}