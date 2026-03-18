namespace Matrici4
{
    internal class Program
    {
        static int[,] Trasposizione(int[,] matrice)
        {
            int[,] MT = new int[matrice.GetLength(1), matrice.GetLength(0)];

            for(int r = 0;  r < MT.GetLength(0); r++)
            {
                for(int c = 0; c < MT.GetLength(1); c++)
                {
                    MT[r,c] = matrice[c,r];
                    Console.Write(MT[r, c] + " ");
                }
                Console.WriteLine();
            }
            return MT;
        }
        static void Main(string[] args)
        {
            int[,] M = { { 1, 6 }, { 4, 3 }, { 8, 15 } };

            Trasposizione(M);
        }
    }
}
