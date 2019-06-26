using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    public class Program
    {
        static double Input(string sentence, double minBorder = double.MinValue, double maxBorder = double.MaxValue)
        {
            double result = 0;
            bool ok = true;
            do
            {
                Console.Write(sentence);
                ok = double.TryParse(Console.ReadLine(), out result);
                if (result < minBorder || result > maxBorder)
                {
                    ok = false;
                }
            }
            while (!ok);
            return result;
        }
        static int IntInput(string sentence, int minBorder = int.MinValue, int maxBorder = int.MaxValue)
        {
            int result = 0;
            bool ok = true;
            do
            {
                Console.Write(sentence);
                ok = int.TryParse(Console.ReadLine(), out result);
                if (result < minBorder || result > maxBorder)
                {
                    ok = false;
                }
            }
            while (!ok);
            return result;
        }

        public static double Func(double a1, double a2, double a3, List<double> array, int m, int n, double l, List<double> additional,ref bool limit)
        {
            if(array.Count == 0){
                array.Add(a1);
                if (array.Last() > l) additional.Add(array.Last());
                array.Add(a2);
                if (array.Last() > l) additional.Add(array.Last());
                array.Add(a3);
                if (array.Last() > l) additional.Add(array.Last());
            }
            
            if(additional.Count == m)//if the function finds m numbers greater than l
            {
                
                limit = true;
                return 0;
            }
            else
            {
                switch (n)
                {
                    case 1:
                        return a1; //out a1
                    case 2:
                        return a2; //out a2
                    case 3:
                        return a3; //out a3
                    default: // else calculating the function
                        {
                            array.Add((7.0 / 3.0 * Func(a1, a2, a3, array, m, n - 1, l, additional, ref limit) + Func(a1, a2, a3, array, m, n - 2, l, additional, ref limit)) / 2.0
                                * Func(a1, a2, a3, array, m, n - 3, l, additional, ref limit));
                            if (array.Last() > l) additional.Add(array.Last());
                            return array.Last();
                        }
                }
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №6. (9)\n" +
                "Ввести а1,  а2,  а3, М, N, L. Построить последовательность чисел ак = (7/3* ак–1 + ак- 2 ) /2 * ак–3 . \n" +
                "Построить N элементов последовательности, либо найти первые M ее элементов, большие числа L (в зависимости \n" +
                "от того, что выполнится раньше). Напечатать последовательность и причину остановки.\n");
            double a1 = Input("Введите число a1: ");
            double a2 = Input("Введите число a2: ");
            double a3 = Input("Введите число a3: ");
            int M = IntInput("Введите число M: ", 1);
            int N = IntInput("Введите число N: ", 1);
            double L = Input("Введите число L: ");
            var array = new List<double>();
            var additional = new List<double>();
            bool limited = false;
            Func(a1, a2, a3, array, M, N, L, additional, ref limited);
            if(!limited)
            {
                Console.WriteLine($"Достигнуто N={N} количество элементов ");
                for(int i = 0; i < N; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
            else
            {
                Console.WriteLine($"Найдено {M} чисел, больших числа {L}");
                for (int i = 0; i < additional.Count; i++)
                {
                    Console.Write(additional[i] + " ");
                }
            }
            Console.ReadKey();

        }
    }
}
