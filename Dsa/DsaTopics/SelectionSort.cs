int [] myArray1 = {12,45,43,2,1};

int n = myArray1.Length;

for(int i = 0; i<n; i++)
{
    int minIndex = i;
    for(int j= i+1; j < n; j++)
    {
        if (myArray1[j] < myArray1[minIndex])
        {
            minIndex = j;
        }
    }
    int temp = myArray1[i];
    myArray1[i] = myArray1[minIndex];
    myArray1[minIndex] = temp;

}

foreach(int array in myArray1)
{
    Console.WriteLine(array);
}
