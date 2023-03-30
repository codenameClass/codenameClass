public class Solution {

    public IList<string> FizzBuzz(int n) {

        Func<int, bool> isFizz = (num) => num % 3 == 0;
        Func<int, bool> isBuzz = (num) => num % 5 == 0;
        List<string> result = new List<string>();

        for(int entryNumber = 1; entryNumber <= n; entryNumber++)
        {
            string resultEntry = (
                    isFizz(entryNumber),
                    isBuzz(entryNumber)
                )
                switch
                {
                    (true, true) => "FizzBuzz",
                    (true, false) => "Fizz",
                    (false, true) => "Buzz",
                    _ => $"{entryNumber}"
                };

            result.Add(resultEntry);
        }

        return result;
    }
}