
/**

Note: More readable solution, but much slower than the other ones

**/
public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        return string
            .Join("", nums)
            .Split('0')
            .Max()
            .Length;
    }
}