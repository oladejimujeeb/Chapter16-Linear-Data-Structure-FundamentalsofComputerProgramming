namespace Chapter16_Linear_Data_Structure;

public class Question8
{
    public static void Solution()
    {
        bool check = true;
        int counter = 0;
        int[] array = { 2, 2, 2,  3, 2, 3, 4, 2, 3 };
        //Array.Sort(array);
        foreach (var num in array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==num)
                {
                    counter++;
                }
            }

            if (counter ==(array.Length/2)+1)
            {
                Console.WriteLine("majorant = {0}",num);
                check = false;
                return;
            }
            counter = 0;
        }
        if(check) Console.WriteLine("The majorant does not exist!");
    }
}