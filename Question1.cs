namespace Chapter16_Linear_Data_Structure;

public class Question1
{
    public static void Answer()
    {
        int sum = 0;
        List<int> addNumber = new List<int>();
        
        while (true)
        {
            Console.Write("Enter the list of number:");
            string list = Console.ReadLine();
            if (list !="")
            {
                try
                {
                    int newList = Convert.ToInt32(list);
                    addNumber.Add(newList);
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("Enter any integer or press enter to get sum");
                }
                
            }
            else
            {
                foreach (var item in addNumber)
                {
                    sum += item;
                }
                break;
            }
            
        }
        Console.WriteLine(sum);
    }
}