public class Solution {
    public int NumberOfSteps(int num) {
        int result = 0;

        int currentNumber = num;
        while(currentNumber > 0) {
            currentNumber = (currentNumber % 2 == 0)
                ? currentNumber / 2
                : currentNumber - 1;
            
            result++;
        }

        return result;
    }
}