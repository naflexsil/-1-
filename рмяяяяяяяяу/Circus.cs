 /*******************************
 *                              *
 *    Старикова Алина ПИ-221    *
 *       мЛаба1 Задание1        *
 *                              * 
 *******************************/

using System;

namespace Circus {
    class Circus {
        static void Main(string[] args) {  // "string[] args" - классу можно передать массив со строками
            Console.Write("введите a - ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("введите n - ");
            int n = int.Parse(Console.ReadLine());

            // результат возведения "a" в степень "n"
            double result = 1;

            // цикл для умножения result на "a" n-ое количество
            for(int index = 0; index < n; ++index) {
                result *= a;
            }
            Console.Write("результат = " + result);
            Console.ReadKey();
        }
    }
}
