﻿namespace project_8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ints = new int[4, 3];
            Console.WriteLine(ints.Rank); //2
            Console.WriteLine(ints.GetLength(dimension: 0)); //4
            Console.WriteLine(ints.GetLength(dimension: 1)); //3
            //Console.WriteLine(ints.GetLength(dimension: 2)); //IndexOutOfRangeException
            Console.WriteLine("\n");


            int[,,] cubs = new int[2, 3, 4];
            for (int i = 0; i < cubs.GetLength(dimension:0); i++)
            {
                Console.WriteLine($"cubs[{i}]: ");
                for(int j = 0; j < cubs.GetLength(dimension:1); j++)
                {
                    Console.WriteLine($"\tcubs[{i}, {j}]: ");
                    for (int k = 0; k < cubs.GetLength(dimension:2); k++)
                    {
                        Console.Write($"\t\tcubs[{i},{j},{k}] = {cubs[i,j,k]}\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            //int[,] matrix = new int[2, 3];
            int[,] matrix = new int[,] { { 1, 2, 3}, { 4, 5, 6}, { 7, 8, 9} };
            for(int i = 0; i < matrix.GetLength(dimension: 0); i++)
            {
                for (int j = 0; j < matrix.GetLength(dimension: 1); j++)
                {
                    Console.Write($"matrix[{i},{j}] = {matrix[i,j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
            double[,,] cube1 = new double[,,] { { { 1.0, 2.0, 3.0 }, { 4.0, 5.0, 6.0 } }, { { 7.0, 8.0, 9.0 }, { 10.0, 11.0, 12.0 } } };
            
            for (int i = 0; i < cube1.GetLength(dimension: 0); i++)
            {
                Console.WriteLine($"cube1[{i}]: ");
                for (int j = 0; j < cube1.GetLength(dimension: 1); j++)
                {
                    Console.WriteLine($"\tcube1[{i}, {j}]: ");
                    for (int k = 0; k < cube1.GetLength(dimension: 2); k++)
                    {
                        Console.Write($"\t\tcube1[{i},{j},{k}] = {cube1[i, j, k]}\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}