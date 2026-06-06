using System;
public class PrintAgeMessage{

public void agePrintMessge(){
    Console.WriteLine("Write your age:");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"You look younger than:{age}");
}
}


