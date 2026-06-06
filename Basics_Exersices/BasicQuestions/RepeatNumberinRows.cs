public class RepeatNumberinROws
{
    public void numberRepeatInRows()
    {
        Console.WriteLine("Write a Number:");
int number = Convert.ToInt32(Console.ReadLine());

for(int i= 0; i < 4; i++)
{
    Console.Write(number);
    if (i < 3)
    {
        Console.Write(" ");
    }
}
Console.WriteLine();

for(int i = 0; i < 4; i++)
{
    Console.Write(number);
}
Console.WriteLine();


    }
}


//output
//24 24 24 24
//24242424