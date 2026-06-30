 int [] myArray = {12,45,43,2};

 int n = myArray.Length;

 Console.WriteLine(n);

 for(int i =0; i < n - 1; i++)
{
    for(int j=0; j < n - i - 1; j++)
    {
        if (myArray[j] > myArray[j + 1])
        {
            int temp = myArray[j];
            myArray[j] = myArray[j+1];
            myArray[j+1] = temp;
        }
        else
        {
            Console.WriteLine("Array elements is not swaped");
        }
    }
}


foreach(int array in myArray)
{
    Console.WriteLine(array);
}


