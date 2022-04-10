// Задача 62: Заполните спирально массив 4 на 4(массив заполняется по часовой стрелке от периферии к центру).

int n = 4; // обьюявление размера массива

void Spiral (int[,] mass) //функция заполнения массива по спирали
{
    int k=1;
    for (int l =0; l<n/2;l++)
    {
            for (int j=l; j<n-l; j++)
        {
            mass[l,j]= k;
            k++;
        }
        for(int i = l+1;i<n-l;i++)
        {
            mass[i,n-l-1]= k;
            k++;
        }
        for(int j = n-l-2;j>=0+l;j--)
        {
            mass[n-l-1,j]= k;
            k++;
        }
        for(int i = n-l-2;i>0+l;i--)
        {
            mass[i,l]= k;
            k++;
        }
    }

    
}

void PrintArray(int[,] array) //функция печати массива в терминал
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,4}", array[i, j]);
        }
        Console.WriteLine("  ]");
    }
}

int[,] array = new int [n,n];
Spiral(array);
PrintArray(array);

// Это самое простое решение по заполнению массива спиралью))))
// int[,] array1 = new int [4,4] {{1,2,3,4},{12,13,14,5},{11,16,15,6},{10,9,8,7}};
// PrintArray(array1);
