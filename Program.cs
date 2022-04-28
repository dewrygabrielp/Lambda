using System;
using System.Linq;
using System.Collections.Generic;

namespace Lambda_expressions
{
    class Program
    {
        //Delegate comparation Age
        public delegate bool ComparationAge(byte Age1, byte Age2);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            Console.WriteLine("Lambdas Expressions \n");

            //Utilizo la el delegado Action que no devuelve nada, lo llamo print que reciba algo y como funcionalidad imprima ese algo.
            Action<float> print = (any) => Console.WriteLine(any);
            Console.WriteLine("Sum Lambda \n");
            Func<int, int, int> sum = (a, b) => a + b;
            int result = sum(5, 4);
            print(result);
            Console.WriteLine("Rest Lambda \n");
            Func<double, double, double> res = (a, b) => a - b;
            double final = res(25, 20);
            print((float)final);
            Console.WriteLine("Divition Lambda \n");
            Func<float, float, float> div = (a, b) => a / b;
            double resd = div(27, 3);
            print((float)resd);
            Console.WriteLine("Max or Min Lambda \n");
            Func<int, int, int> may = (a, b) =>
            {
                if (a > b) return a;
                else return b;
            };
            int f = may(89, 4);
            print(f);

            //primero declaro una variable de tipo List, la func GetPairs recibe number y se cálcula la división entre 2 y se sacan los números cuyo resultado sea 0,
            // declaro otra variable para almacenar el resultado donde utilizo la variable list con el método where de Linq y le paso la funcionalidad almacenada en GetPairs
            //
            Console.WriteLine("Pairs numbers # 1");
            var ListNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Func<int, bool> GetPairs = (number) => number % 2 == 0;

            var ListNumbersResult = ListNumbers.Where(GetPairs);
            
            foreach(var item in ListNumbersResult)
            {
                print(item);
            }

            //La función recibe un int y liego una función y como salida un int, si el condicional es positivo
            // se retorna la función pasandole el 141 como parámetro, luego a r se le pasa como parámetro el numbers = 141 y fn =  n => n * 2
            Console.WriteLine("Function HigherOrder");
            Func<int, Func<int, int>, int> HigherOrder = (numbers, fn) =>
             {
                 if (numbers > 50)
                     return fn(numbers);
                 else
                     return numbers;
             };

            var r = HigherOrder(141, n => n * 2);

            Console.WriteLine(r);

            //Numbers Pairs
            Console.WriteLine("Pairs Numbers");
            var Number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var PairsNumber = Number.FindAll(i => i % 2 == 0);
            PairsNumber.ForEach(n => Console.WriteLine(n));

            Console.WriteLine("Comparation\n");

            ComparationAge compare = (a, b) => a == b;
            Console.Write(compare(15, 16));
            


            Console.ReadKey();
        }
    }
}
