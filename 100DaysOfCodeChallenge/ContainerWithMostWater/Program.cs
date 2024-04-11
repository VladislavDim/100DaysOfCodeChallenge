namespace ContainerWithMostWater
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] height = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int maxArea = MaxArea(height);
            Console.WriteLine("Maximum area of water: " + maxArea);
        }
        public static int MaxArea(int[] height)
        {
            int maxArea = 0;
            int left = 0, right = height.Length - 1;

            while (left < right)
            {
                int minHeight = Math.Min(height[left], height[right]);
                int width = right - left;
                int area = minHeight * width;
                maxArea = Math.Max(maxArea, area);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxArea;
        }
    }
}
