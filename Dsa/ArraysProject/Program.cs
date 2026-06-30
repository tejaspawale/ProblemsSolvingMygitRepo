// int[,] numbers =
// {
//     {1,2,3},
//     {4,5,6},
//     {7,8,9}
// };


// int[,] numbers2 =
// {
//     {7,8,9},
//     {10,11,12}
// };

// Console.WriteLine(numbers[0,0] + numbers2[0,0]);
// Console.WriteLine(numbers[0,1] + numbers2[0,1]);
// Console.WriteLine(numbers[0,2] + numbers2[0,2]);

// Console.WriteLine(numbers[1,0] + numbers2[1,0]);
// Console.WriteLine(numbers[1,1] + numbers2[1,1]);
// Console.WriteLine(numbers[1,2] + numbers2[1,2]);

// for(int i = 0; i<=1 ; i++)
// {
//     for(int j = 0; j<=2; j++)
//     {
//         Console.Write((numbers[i,j] + numbers2[i,j] +" "));
//     }
//     Console.WriteLine();

// }


// // int[,]result = new int  [3,3];
// // for(int i = 0; i < numbers.GetLength(0); i++)
// // {
// //     for(int j = 0; j < numbers.GetLength(1); j++)
// //     {
// //         result[j,i] = numbers[i,j];
// //     }
// // }

// for (int i = 0; i <numbers.GetLength(0); i++)
// {
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         Console.Write(numbers[j,i] + " ");
//     }

//     Console.WriteLine();
// }



// int [,] num1 =
// {
//     {1,2},
//     {3,4},
        
// };

// int [,]num2 =
// {
//     {1,2},
//     {3,4}
// };

// int [,]r = new int [2,2];

// for(int i=0; i < 2; i++)
// {
//     for (int j =0; j <2; j++)
//     {
//        r[i,j]=0;

//        for(int k =0 ; k < 2; k++)
//         {
//             r[i,j]=r[i,j]+num1[i,k]*num2[k,j];
//         }
//     }
// }

// for (int i =0; i < 2; i++)
// {
//     for (int j =0; j < 2; j++)
//     {
//         Console.WriteLine(r[i,j]);
//     }
// }

// Console.WriteLine(dublicate);

// ---------------- dublicate


// int[] k = {1,1,5};

// int duplicate = 0;

// for (int i = 0; i < k.Length; i++)
// {
//     for (int j = i + 1; j < k.Length; j++)
//     {
//         if (k[i] == k[j])
//         {
//             duplicate++;
//         }
//     }
// }

// Console.WriteLine(duplicate);










//unique elements
int[] arrays = {1,1,5};

int unique = 0;

for (int i = 0; i < arrays.Length; i++)
{
    bool isDuplicate = false;

    for (int j = 0; j < i; j++)
    {
        if (arrays[i] == arrays[j])
        {
            isDuplicate = true;
            break;
        }
    }

    if (!isDuplicate)
    {
        unique++;
    }
}

Console.WriteLine(unique);


