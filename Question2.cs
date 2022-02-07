namespace Chapter16_Linear_Data_Structure;

public class Question2
{
    public static void Solution()
    {
        Stack<int> myStack = new Stack<int>();
        Console.Write("Enter the number of integer to enter:");
        int N = Convert.ToInt32(Console.ReadLine());
        for (int i =1; i <= N; i++)
        {
            Console.Write($"Enter number {i}: ");
            int num = Convert.ToInt32(Console.ReadLine());
            myStack.Push(num);
        }

        foreach (var item in myStack)
        {
            Console.Write(item+",");
        }
    }
}