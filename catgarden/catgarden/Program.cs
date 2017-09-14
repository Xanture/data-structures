using System;

namespace catgarden
{
    class Program
    {
        static void Main(string[] args)
        {
            Array[] garden = new Array[5];

            for (int i = 0; i < garden.Length; i++)
            {
                if ((i + 1) % 2 != 0)
                {
                    string[] rowCatNip = new string[] {"catnip", "catnip", "catnip", "catnip", "catnip",};
                    garden[i] = rowCatNip;
                }
                else
                {
                    string[] rowMint = new string[] { "mint", "mint", "mint", "mint", "mint", };
                    garden[i] = rowMint;
                }
            }
            foreach (var item in garden)
            {
                foreach (var stuff in item)
                {
                    Console.WriteLine(stuff);
                }
            }
        }
    }
}
