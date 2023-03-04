using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class ArrayChange
    {
        static void NewArray (int [,] NameArray)
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
    }
