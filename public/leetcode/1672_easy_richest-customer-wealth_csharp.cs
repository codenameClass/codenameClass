public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int result = 0;

        foreach (int[] customerWealths in accounts)
        {
            int customerWealth = 0;
            foreach (int amountOfMoney in customerWealths)
            {
                customerWealth += amountOfMoney;
            }

            result = result < customerWealth ? customerWealth : result;
        }

        return result;
    }
}