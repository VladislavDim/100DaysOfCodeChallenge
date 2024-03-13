namespace LargestZeroSubmatrix
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] {
            {0, 1, 1, 1},
            {1, 1, 1, 1},
            {1, 1, 0, 0},
            {1, 1, 0, 0}};

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int minLength = int.MaxValue;
            int sum = 0;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    int crnSum = 0;

                    if (matrix[r, c] == 0)
                    {
                        int count = 0;
                        crnSum++;
                        int minCrnLength = int.MaxValue;

                        while (matrix[r + count, c] == 0)
                        {
                            count++;
                            crnSum++;

                            minCrnLength = CheckSequence(matrix, r, c);

                            if (minCrnLength < minLength)
                            {
                                minLength = minCrnLength;
                            }

                        }
                    }
                }
            }

        }

        private static int CheckSequence(int[,] matrix, int r, int c)
        {
            int count = 1;

            while ((matrix[r, c + count] == 0))
            {
                count++;
            }

            return count;

        }
    }
}
