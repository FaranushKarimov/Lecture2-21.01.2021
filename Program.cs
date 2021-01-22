using System;
using System.Globalization;
// Console.WriteLine("Hello");
namespace Lecture2
{
    class Program
    {
        static void Main(string[] args)
        {
         //   goto Task4;
            //Console.WriteLine("Hello World!");
            /*  var x = 0;
              var y = 7;
              string word = x > 0 ? "Positive" : "Negative";
              string text = "0";
              string text1 = text switch 
              {
                  "0" => "zero",
                  "8" => "eight",
                  _  => ""
              };

              switch (x)
              {
                  case 1:
                  {
                      y = y - 1;
                  }
                  break;
                  case 2:
                  {
                      y = y - 2;
                  }
                  break;
              }
              System.Console.WriteLine(text1);*/
            // var balance = 0;
            /* var text = "998";
             var textError = "8372dsf";

             int number1 = int.Parse(text);
             int number2 = Convert.ToInt32(textError);
             int.TryParse(textError, out int result);
             System.Console.WriteLine(number1);
             System.Console.WriteLine(result);*/
            /*  while(true)
              {
                  System.Console.WriteLine($"Your balance:{balance}");
                  System.Console.Write("Type amount:");
                  var isParsed = int.TryParse(Console.ReadLine(),out var tmp);

                  if(tmp > 0) {
                      balance += tmp;
                  }
                  if(!isParsed) {
                      System.Console.ForegroundColor = ConsoleColor.Red;
                      System.Console.WriteLine("Вы ввели не число");
                      System.Console.ForegroundColor = ConsoleColor.White;
                  }
              }*/
            Console.WriteLine("Задание 3.2");
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            b = a = a != b ? a > b ? a : b : 0;

           /* if (a != b)
            {
                if( a > b) {
                    b = a;
                }
                else {
                    a = b;
                }
            }
            else
            {
                b = a = 0;
            }*/
            Console.WriteLine($"a = {a} b = {b}");

            Console.WriteLine("Задание 3.3");
            Console.Write("Введите первое число: ");
            double operand1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double operand2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите +-/* : ");
            string sign = Console.ReadLine();
         //   double.TryParse(sign,out double result);
         /* Сложность заключается в том как внутри case написать условие if, именно во вновшестве данной конструкции */
            double? calculate = sign switch
            {
                "*" => operand1 * operand2,
              //  "/" => operand1 / operand2,
                "-" => operand1 - operand2,
                "+" => operand1 + operand2,
                "/" => operand1 >= 0 && operand2 == 0 ? null : (double?)(operand1 / operand2),
                {} => 0 
            };
          /*  if (sign == "/") {
                if (operand1 >= 0 && operand2 == 0) {
                    Console.WriteLine ("Невозможно получить ответ");
                } else {
                    calculate = operand1 / operand2;
                }
            }*/
            Console.WriteLine(calculate != null ? $"Результат: {calculate}" : "Ошибка деления на ноль");
        // Можно было без этой огромной тернарной операции обойтись, прост хотел уменьшить строчки кода :)
        /*  Написать программу вычисления стоимости покупки с учетом скидки. Скидка в 3%
            предоставляется в том случае, если сумма покупки больше 500 сомони, в 5% - если
            сумма больше 1000 сомони */

            Console.WriteLine("Задание 3.4");
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string result = number >= 0 && number <= 14 ? "[0 - 14]" : number >= 15 && number <= 35 ? "[15-35]" : number >= 36 && number <= 50 ? "[36-50]" : number >= 50 && number <= 100 ? "[50-100]" : "Введите из представленного диапазона";
            Console.WriteLine("Диапазон: " + result);
            Console.WriteLine("Задача 3.2.2");
            Console.Write("Введите цену: ");
            int purchase = Convert.ToInt32(Console.ReadLine());
            // if (purchase > 500) {
                
            // } else if (purchase > 1000) {

            // }
            var condition = purchase > 500 ? purchase - (purchase * 0.03) :
                        purchase > 1000 ? purchase - (purchase * 0.05) :
                            purchase; 
            Console.WriteLine(condition);
            Console.WriteLine("Задача 3.2.3");
            // Можно сделать массив, но пока думаю лучше обойтись переменными
            /* Даны четыре числа. Если они не образуют возрастающую последовательность,
                вывести минимальный из них; если числа равны, найти их произведение, иначе
                сообщение «Числа расположены по возрастанию». */
           // Task3:
            Console.Write("Введите цифру: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цифру: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цифру: ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цифру: ");
            int number4 = Convert.ToInt32(Console.ReadLine());
           /* if (number1 > number2 && number2 > number3 && number3 > number4) {
                Console.WriteLine("Числа расположены по возрастанию");
            } else if (number1 == number2 & number2 == number3 & number3 == number4) {
                var result1 = number1 * number2 * number3 * number4;
                Console.WriteLine(result1);
            } else {
                if (!(number1 > number2 && number2 > number3 && number3 > number4)) {
                    int min = 0;
                    //if 
                }
            }*/
            string result2 = !(number1 < number2 && number2 < number3 && number3 < number4) ? 
                                (number1 == number2 && number2 == number3 && number3 == number4) ?
                                    $"{number1 * number2 * number3 * number4}" :   
                                        (number1 < number2 && number1 < number3 && number1 < number4) ? $"{number1}" : 
                                            (number2 < number3 && number2 < number4) ? $"{number2}" :
                                                (number3 < number4) ? $"{number3}" : $"{number4}" : "Числа расположены по возрастанию";
            Console.WriteLine(result2);
            Console.WriteLine("Задача 3.2.4");
            /* Запрашиваются три числа для переменных a, b, c. Значения переменных поменять
                таким образом, чтобы a >= b >= c.*/
          //  Task4:
            System.Console.Write("Введите число a: ");
            double a1 = double.Parse(Console.ReadLine());
            System.Console.Write("Введите число b: ");
            double b1 = double.Parse(Console.ReadLine());
            System.Console.Write("Введите число c: ");
            double c = double.Parse(Console.ReadLine());
            System.Console.WriteLine((a1 >=b1 && b1 >= c)?$"(a = {a1}) >= (b = {b1}) >= (c = {c})":
            (a1 >= c && c >=b1)?$"(a = {a1}) >= (b = {c}) >= (c = {b1})":
            (b1 >= a1 && a1 >=c)?$"(a = {b1}) >= (b = {a1}) >= (c = {c})":
            (b1 >= c && c >= a1)?$"(a = {b1}) >= (b = {c}) >= (c = {a1})":
            (c >= a1 && a1 >= b1)?$"(a = {c}) >= (b = {a1}) >= (c = {b1})":
            $"(a = {c}) >= (b = {b1}) >= (c = {a1})");
               

        }
    }
}
