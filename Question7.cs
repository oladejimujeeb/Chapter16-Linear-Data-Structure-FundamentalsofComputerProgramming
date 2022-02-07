namespace Chapter16_Linear_Data_Structure;

public class Question7
{
    public static void Solution()
    {
        Dictionary<int, int> myDictionary = new Dictionary<int, int>();
        int[] array = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
        foreach (var num in array)
        {
            if (myDictionary.ContainsKey(num))
            {
                myDictionary[num] = myDictionary[num] + 1;
            }
            else
            {
                myDictionary.Add(num,1);
            }
            
        }
        foreach (var item in myDictionary)
        {
            Console.WriteLine($"{item.Key} -> {item.Value} times");
        }
    }
}