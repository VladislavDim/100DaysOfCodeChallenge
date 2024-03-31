using System;
using System.Linq;

namespace WordSearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[][] matrix = new char[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
            }

            Console.WriteLine("Enter the word to search:");
            string word = Console.ReadLine();

            bool result = Exist(matrix, word);
            Console.WriteLine($"Word '{word}' exists in the matrix: {result}");
        }

        public static bool Exist(char[][] board, string word)
        {
            int rows = board.Length;
            int columns = board[0].Length;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (DFS(board, i, j, word, 0))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool DFS(char[][] board, int i, int j, string word, int index)
        {
            if (index == word.Length)
            {
                return true;
            }

            if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || board[i][j] != word[index])
            {
                return false;
            }

            char temp = board[i][j];
            board[i][j] = ' '; // Mark as visited

            bool found = DFS(board, i + 1, j, word, index + 1) ||
                         DFS(board, i - 1, j, word, index + 1) ||
                         DFS(board, i, j + 1, word, index + 1) ||
                         DFS(board, i, j - 1, word, index + 1);

            board[i][j] = temp; // Restore the original value
            return found;
        }
    }
}
