int Input(string msg)
{
  int flag = false;
  int value = 0;
  while (!flag)
  {
    Console.Write(msg + " ");
    flag = int.TryParse(Console.ReadLine(), out value);
  }
  return value;
}

int[,] CreateArray(int a, int b) => new int[a, b];

void FillRandomNumbers(int[,] matrix, int min = 1, int max = 10)
{
  int row = matrix.GetLength(0);
  int columns = matrix.GetLength(1);

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      matrix[i, j] = new Random().Next(min, max);
    }
  }
}

void Print(int[,] matrix)
{
  int row = matrix.GetLength(0);
  int columns = matrix.GetLength(1);

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      Console.Write($"{matrix[i, j],5} ");
    }
    Console.WriteLine();
  }
}

void NewArray(int[,] NameArray)
{
  int i, j, temp;
  int n = NameArray.GetLength(0); // кол-во строк
  int m = NameArray.GetLength(1); // кол-во столбцов

  for (j = 0; j < m; j++) // перебираем столбцы
  {
    temp = NameArray[0, j];
    NameArray[0, j] = NameArray[n - 1, j];
    NameArray[n - 1, j] = temp;
  }
}

int A = Input("Введите количество строк массива");
int B = Input("Введите количество столбцов массива");

int[,] matr = CreateArray(A, B);
FillRandomNumbers(matr);
PrintArray(matr);
NewArray(matr);
Console.WriteLine();
PrintArray(matr);

