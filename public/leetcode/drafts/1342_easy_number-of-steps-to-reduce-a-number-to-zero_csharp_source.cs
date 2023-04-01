/**
* Conclusion: Low level solution, article can be found here:
* https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/solutions/3015984/bit-manipulation-solution-without-any-loops-with-o-1-complexity/?languageTags=csharp
*/

public class Solution {
    public int NumberOfSteps(int num) {
        if(num == 0) return 0;

        int occupiedBits = sizeof(int) * 8 - BitOperations.LeadingZeroCount((uint)num);
        int popCount = BitOperations.PopCount((uint)num);

        return popCount + occupiedBits - 1;
    }
}