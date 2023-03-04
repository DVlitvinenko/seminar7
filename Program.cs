int Input(string msg)
{
  bool flag = false;
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

void PrintBad(int[,] matrix)
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

void ReplacingLinesIn(int[,] matrix)
{
  int temp;
  int lastIndexRow = matrix.GetLength(0) - 1;
  int columns = matrix.GetLength(1);

  for (int i = 0; i < columns; i++)
  {
    temp = matrix[0, i];
    matrix[0, i] = matrix[lastIndexRow, i];
    matrix[lastIndexRow, i] = temp;
  }
}

int rows = Input("Введите количество строк массива");
int columns = Input("Введите количество столбцов массива");

int[,] table = CreateArray(rows, columns);
FillRandomNumbers(table);
PrintBad(table);
ReplacingLinesIn(table);
Console.WriteLine();
PrintBad(table);