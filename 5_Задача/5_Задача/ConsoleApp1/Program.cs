using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 8;
        int m = 8;
        int[,] mas = new int[n, m];
        int tekn = 0, tekm = 0;
        int znach = 1;
        while (tekm < m)
        {
            do
            {
                mas[tekn, tekm] = znach;
                znach++;
                tekn++;
            } while (tekn < n);
            tekn--;
            tekm++;
            if (znach > n * m) break;
            do
            {
                mas[tekn, tekm] = znach;
                znach++;
                tekn--;
            } while (tekn >= 0);
            tekn++;
            tekm++;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                Console.Write("{0,4}", mas[i, j]);
            Console.WriteLine();
        }
        Console.ReadLine();
    }
} 