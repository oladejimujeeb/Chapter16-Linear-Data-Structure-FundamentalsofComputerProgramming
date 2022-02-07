namespace Chapter16_Linear_Data_Structure;

public class Question5
{
    public static void Solution()
    {
        int[] array = { 19, -10, 12, -6, -3, 34, -2, 5 };
        Queue<int> myQueue = new Queue<int>();
        foreach (var item in array)
        {
            if (item >= 0)
            {
                myQueue.Enqueue(item);
            }
        }

        foreach (var num in myQueue)
        {
            Console.Write(num+",");
        }
    }
}