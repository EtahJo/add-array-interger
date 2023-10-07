using System;


namespace AddArrayIntergers
{
    class Program
    {
        public static void Main()
        {
            int[] intergersArray = new int[4];

            int result = 0;
            int presentIndex = 0;
            while (presentIndex <= intergersArray.Length-1)
            {
                Console.Write(": ");
                intergersArray[presentIndex] = int.Parse(Console.ReadLine());
                presentIndex += 1;
            }
             presentIndex = 0;

            while (presentIndex <= intergersArray.Length-1)
            {
                result += intergersArray[presentIndex];
                presentIndex += 1;
            }

            Console.WriteLine(result);
        }
    }
}