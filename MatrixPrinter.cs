public static class MatrixPrinter
{
  public static string PrintGood(int[,] matrix)
  {
    string result = string.Empty;

    int row = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < row; i++)
    {
      for (int j = 0; j < columns; j++)
      {
        result += $"{matrix[i, j],5} ";
      }
      result += "\n";
    }

    return result;
  }
}