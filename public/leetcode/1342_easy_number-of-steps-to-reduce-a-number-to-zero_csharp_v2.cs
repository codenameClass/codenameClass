public class Solution {
    public int NumberOfSteps(int num) {
        if(num == 0) return 0;

        return (num % 2 == 0)
            ? 1+NumberOfSteps(num / 2)
            : 1+NumberOfSteps(num - 1);
    }
}