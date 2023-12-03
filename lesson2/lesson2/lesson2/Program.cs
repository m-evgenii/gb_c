class Program

{
    static void Main(string[] args)
    {
        int[,] array = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
        int[,] array2 = new int[3, 3];
        int[,] sorting(int[,] array, int[,] array2)
        {
            int z = 0;
            int[] array3 = new int[9];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array3[z] = array[i, j];
                    z++;
                }
            }
            Array.Sort(array3);
            z = 0;
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = array3[z];
                    z++;
                }
            }
            return array2;
        }
        sorting(array, array2);

        for (int i = 0; i < array2.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                Console.Write(array2[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}