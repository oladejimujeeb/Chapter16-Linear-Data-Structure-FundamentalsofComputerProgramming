namespace Chapter16_Linear_Data_Structure;

public class Question4
{
    public static void TestQuestion4()
    {
        int[] array = { 1, 2, 2, 1, 1, 2, 2, 2, 2,3,3, 3, 3, 3 };
        Question4.Solution(array);
    }
    public static void Solution(int[]arr)
    {
        //int[] arr = { 1, 2, 2, 1,1,1, 1, 1, 2, 2, 2, 2, 3, 3, 3 };
        int counter = 1;
        int occuredMost = 0;
        int bestCounter = 0;

        for (int n = 1; n < arr.Length; n++)
        {
            if (arr[n] == arr[n - 1])
            {
                counter++;
                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    occuredMost = arr[n];

                }
            }
            
            else
            {
                counter = 1;
            }
        }
        List<int> myList = new List<int>();
        for(int i =0; i<bestCounter; i++)
        {
                myList.Add(occuredMost);
        }
        
        foreach (var num in myList)
        {
            Console.Write(num+", ");
        }
    }
}