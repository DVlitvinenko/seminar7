int Input(string msg)
{
    Console.Write(msg + " ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateArray(int a, int b)
{
    int[,] matrix = new int[a, b];
    return matrix;
}

void RandomArray(int[,] NameArray)
{
    for (int i = 0; i < NameArray.GetLength(0); i++)
    {
        for (int j = 0; j < NameArray.GetLength(1); j++)
        {
            NameArray[i, j] = new Random().Next(1, 1000);
        }
    }
}

void PrintArray(int[,] NameArray)
{
    for (int i = 0; i < NameArray.GetLength(0); i++)
    {
        for (int j = 0; j < NameArray.GetLength(1); j++)
        {
            Console.Write(NameArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void NewArray (int [,] NameArray)
        {
            int i, j, temp;
            int n = NameArray.GetLength(0); // кол-во строк
            int m = NameArray.GetLength(1); // кол-во столбцов
            
            for (j = 0; j < m; j++) // перебираем столбцы
            {
                temp=NameArray[0, j];
                NameArray[0, j]=NameArray[n - 1, j];
                NameArray[n - 1, j] = temp;
            }
            
        }

int A = Input("Введите количество строк массива");
int B = Input("Введите количество столбцов массива");

int[,] matr = CreateArray(A, B);
RandomArray(matr);
PrintArray(matr);
NewArray (matr);
Console.WriteLine();
PrintArray(matr);

