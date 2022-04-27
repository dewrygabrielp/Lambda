using System;
using System.Linq;
using System.Collections.Generic;

namespace Lambda_expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            Console.WriteLine("Lambdas Expressions \n");

            //Utilizo la el delegado Action que no devuelve nada, lo llamo print que reciba algo y como funcionalidad imprima ese algo.
            Action<float> print = (any) => Console.WriteLine(any);

            Func<int, int, int> sum = (a, b) => a + b;
            int result = sum(5, 4);
            print(result);

            Func<double, double, double> res = (a, b) => a - b;
            double final = res(25, 20);
            print((float)final);

            Func<float, float, float> div = (a, b) => a / b;
            double resd = div(27, 3);
            print((float)resd);

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

            var ListNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Func<int, bool> GetPairs = (number) => number % 2 == 0;

            var ListNumbersResult = ListNumbers.Where(GetPairs);
            foreach(var item in ListNumbersResult)
            {
                print(item);
            }

            //La función recibe un int y liego una función y como salida un int, si el condicional es positivo
            // se retorna la función pasandole el 141 como parámetro, luego a r se le pasa como parámetro el numbers = 141 y fn =  n => n * 2
            Func<int, Func<int, int>, int> HigherOrder = (numbers, fn) =>
             {
                 if (numbers > 50)
                     return fn(numbers);
                 else
                     return numbers;
             };

            var r = HigherOrder(141, n => n * 2);

            Console.WriteLine(r);

            Console.ReadKey();
        }
    }
}
