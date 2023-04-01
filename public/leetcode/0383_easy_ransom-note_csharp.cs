public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {

        Dictionary<char, int> magazineCounts = magazine
            .GroupBy(letter => letter)
            .ToDictionary
            (
                letterGroup => letterGroup.Key,
                letterGroup => letterGroup.Count()
            );

        foreach (char letter in ransomNote)
        {
            if
            (
                !magazineCounts.ContainsKey(letter) 
                || magazineCounts[letter] < 1
            )
            {
                return false;
            }

            magazineCounts[letter]--;
        }

        return true;
    }
}