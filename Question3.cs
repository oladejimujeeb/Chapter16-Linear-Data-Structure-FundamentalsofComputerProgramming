namespace Chapter16_Linear_Data_Structure;

public class Question3
{
    public static void Solution()
    {
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
                    Console.WriteLine("Enter any integer or press enter to sort");
                }
                
            }
            else
            {
                addNumber.Sort();
                foreach (var item in addNumber)
                {
                    Console.Write(item+",");
                }
                break;
            }
            
        }
        
    }
}