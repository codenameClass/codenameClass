/**
* Conclusion: Bitwise slows down the performance this is due missing optimization on && and %.
*/

public class Solution {
    public int NumberOfSteps(int num) {
        if(num == 0) return 0;

        return (num & 1) == 0
            ? 1+NumberOfSteps(num >> 1)
            : 1+NumberOfSteps(num - 1);
    }
}