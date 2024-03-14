using System;

public class LargestZeroSubmatrix
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        int[][] matrix = new int[size][];

        for (int m = 0; m < size; m++)
        {
            int[] row = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            matrix[m] = row;
        }

        int[,] dp = new int[matrix.Length, matrix[0].Length];

        // Filling the DP table
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    dp[i, j] = 1;

                    if (i > 0 && j > 0)
                    {
                        dp[i, j] += Math.Min(Math.Min(dp[i - 1, j], dp[i, j - 1]), dp[i - 1, j - 1]);
                    }
                }
            }
        }

        // Finding the coordinates of the largest submatrix
        int maxSubmatrixSize = 0;
        int maxSubmatrixRow = 0;
        int maxSubmatrixCol = 0;

        for (int i = 0; i < dp.GetLength(0); i++)
        {
            for (int j = 0; j < dp.GetLength(1); j++)
            {
                if (dp[i, j] > maxSubmatrixSize)
                {
                    maxSubmatrixSize = dp[i, j];
                    maxSubmatrixRow = i;
                    maxSubmatrixCol = j;
                }
            }
        }

        // Displaying the largest submatrix
        for (int i = maxSubmatrixRow - maxSubmatrixSize + 1; i <= maxSubmatrixRow; i++)
        {
            for (int j = maxSubmatrixCol - maxSubmatrixSize + 1; j <= maxSubmatrixCol; j++)
            {
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
