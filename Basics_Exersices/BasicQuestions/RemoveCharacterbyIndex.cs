
public class Program{

    
        public static string remove_char(string c,int i)
        {
            return c.Remove(i,1);
        }

        public static void Main(string[] args)
    {
        
        Console.WriteLine("Give a specified character: ");
        string chaar = Console.ReadLine();

        Console.WriteLine("Give me index number to remove values from :");
        int index =Convert.ToInt32( Console.ReadLine());

        Console.WriteLine(remove_char(chaar,index));
    }
    


}

/*output 
input :Tejas
index: 2
after remove second index :Teas */