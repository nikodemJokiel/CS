﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_9_2_slowniki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = ReadInt("Podaj liczbę osób:", 0, int.MaxValue);

            int[] ages = new int[n];
            string[] names = new string[n];

            for (int i = 0; i < n; i++)
            {
                names[i] = ReadString($"Podaj imię osoby {i + 1}:");
                ages[i] = ReadInt($"Podaj wiek osoby {i + 1}:", 0, 150);
            }

            List<string> namesStartsWithA = names.Where(name => name.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();

            Console.WriteLine("\nTablica imion i wieków:");
            PrintArray(names, ages);

            Console.WriteLine("\nLista imion rozpoczynających się na literę A i a:");
            PrintList(namesStartsWithA);

            Dictionary<string, int> adults = new Dictionary<string, int>();
            for (int i = 0; i < names.Length; i++)
            {
                if (ages[i] >= 18)
                {
                    adults.Add(names[i], ages[i]);
                }
            }

            Console.WriteLine("\nSłownik osób pełnoletnich:");
            PrintDictionary(adults);
            Console.ReadKey();
        }

        static void PrintDictionary(Dictionary<string, int> adults)
        {
            foreach (var item in adults)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }

        static void PrintList(List<string> names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void PrintArray(string[] names, int[] ages)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]} - {ages[i]}");
            }
        }

        static int ReadInt(string prompt, int low, int high)
        {
            int result;
            bool valid;
            do
            {
                Console.Write(prompt);
                valid = int.TryParse(Console.ReadLine(), out result) && result >= low && result <= high;
                if (!valid)
                {
                    Console.WriteLine($"Podaj liczbę z zakresu {low} - {high}");
                }
            }
            while (!valid);
            return result;
        }

        static string ReadString(string prompt)
        {
            string result;
            do
            {
                Console.Write(prompt);
                result = Console.ReadLine();
                if (string.IsNullOrEmpty(result))
                {
                    Console.WriteLine("Podaj niepusty ciąg znaków");
                }
            }
            while (string.IsNullOrEmpty(result));
            return result;
        }
    }
}
/*
1) Napisz program, który wczytuje z klawiatury liczbę n, a następnie n imion i wieków
osób.
2) Użyj tablicy, aby przechować wczytane imiona i wieki.
3) Użyj listy, aby przechować tylko te imiona, które zaczynają się na literę A.
4) Użyj słownika, aby przechować pary (imie, wiek) dla wszystkich osób, których wiek jest
większy niż 18 lat.
5) Wypisz na ekranie zawartość tablicy, listy i słownika.
*/