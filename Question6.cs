using System.Collections;

namespace Chapter16_Linear_Data_Structure;

public class Question6
{
    public static void Solution()
    {
        Hashtable hashtable = new Hashtable();
        int[] array = { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
        for (int i = 0; i < array.Length; i++)
        {
            if (hashtable.ContainsKey(array[i]))
            {
                hashtable[array[i]] = (int)hashtable[array[i]] + 1;
            }
            else
            {
                hashtable.Add(array[i],1);
            }
        }

        foreach (DictionaryEntry de in hashtable)
        {
            if ((int)de.Value % 2 == 0)
            {
                for (int i = 0; i < (int)de.Value; i++)
                {
                    Console.Write(de.Key+",");
                }
            }
        }
    }
}