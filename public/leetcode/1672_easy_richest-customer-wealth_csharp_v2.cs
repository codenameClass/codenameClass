public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int result = 0;

        foreach (int[] account in accounts)
        {
            result = Math.Max(result, account.Sum());
        }

        return result;
    }
}