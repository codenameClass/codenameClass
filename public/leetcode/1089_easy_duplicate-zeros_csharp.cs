public class Solution {
    public void DuplicateZeros(int[] arr) {

        int numberOfZeros = 0;
        int arrLength = arr.Length;
        int currentIndex = 0;

        for(int i = 0; i < arrLength; i++)
        {
            if(arr[currentIndex] == 0) 
            {
                if (i == arrLength - 1)
                {
                    arr[i] = 0;
                    arrLength--;
                }
                else
                {
                    numberOfZeros++;
                    i++;
                }
            }
            
            currentIndex++;
        }

        int readIndex = arrLength - 1 - numberOfZeros;

        for (int writeIndex = arrLength - 1; writeIndex >= 0; writeIndex--)
        {
            arr[writeIndex] = arr[readIndex];

            if(arr[readIndex] == 0)
            {
                arr[--writeIndex] = arr[readIndex];
            }

            readIndex--;
        }
    }
}