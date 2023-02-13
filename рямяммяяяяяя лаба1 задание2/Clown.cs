 /*******************************
 *                              *
 *    Старикова Алина ПИ-221    *
 *       Лаба1 Задание2         *
 *                              * 
 *******************************/

using System;

namespace ConsoleApp {
    class Clown {           
        private static void Main(string[] args) {
            Console.Write("введите число: ");
            int x = int.Parse(Console.ReadLine());  // из строки вычисляем знач-е
            int secondNumber = x;  // и здесь присваиваем это знач-е переменной number

            do {
                secondNumber = secondNumber / 10;
                if(secondNumber < 100) {
                    do {
                        secondNumber = secondNumber - 10;
                    }
                    while(secondNumber > 10);
                }
            }
            while(secondNumber > 100);
            int n = int.Parse(x.ToString().Remove(1, 1) + secondNumber);  // перестановка 2-й цифры в конец числа; "Remove" - убир. эл-т в строке. 1я цифра - индекс, 2я - ск-ко эл-в убрать 
            Console.Write("результат: " + n);  // вывод результат
            Console.ReadKey();
        }
    }
}
