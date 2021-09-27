using System;

namespace Task1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы: ");
            int n = int.Parse(Console.ReadLine());
            Func(n);
        }
        static void Func(int n)
        {
            int count = 0;
            int[][] matrix = MatrixInput(n);
            foreach (int[] i in matrix)
            {
                if (CheckRow(i))
                {
                    count++;
                }
            }
            Console.Write("Количество строк с арифметической прогрессией: ");
            Console.WriteLine(count);
        }
        static int [][] MatrixInput(int n)
        {
            Console.WriteLine("Введите матрицу:");
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                string enterString = Console.ReadLine();
                string[] arrayString = enterString.Split(new Char[] { ' ' });
                matrix[i] = new int[n];
                for (int j = 0; j < arrayString.Length; j++)
                {
                    matrix[i][j] = int.Parse(arrayString[j]);
                }
            }
            return matrix;
        }
        static bool CheckRow(int[] row)
        {
            int q = row[1] - row[0];
            for (int i = 0; i < row.Length; i++)
            {
                if(row[i] != (row[0] + i * q))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
