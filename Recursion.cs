namespace Chapter16_Linear_Data_Structure;

public class Recursion
{
    public static void Even(int a, int b)
    {
        if(a%2==0)
        {
            Console.Write(a+" ");
        }
        if(a==b) return;
        Even(a+1,b);
    }
}