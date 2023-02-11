using System;

namespace ConsoleApp {
    class Clown {           
        private static void Main(string[] args) {
            Console.Write("введите число: ");
            int x = int.Parse(Console.ReadLine());  // из строки вычисляем знач-е
            int number = x;  // и здесь присваиваем это знач-е переменной number

            do {
                number = number / 10;
                if(number < 100) {
                    do {
                        number = number - 10;
                    }
                    while(number > 10);
                }
            }
            while(number > 100);
            int n = int.Parse(x.ToString().Remove(1, 1) + number);  // перестановка 2-й цифры в конец числа; "Remove" - убир. эл-т в строке. 1я цифра - индекс, 2я - ск-ко эл-в убрать 
            Console.Write("результат: " + n);  // вывод результат
            Console.ReadKey();
        }
    }
}