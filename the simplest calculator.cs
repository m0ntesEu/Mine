using System;

namespace project {
    class Guid {

        static void Main() { 
            System.Console.WriteLine("Пожалуйста, напишите букву: ");
            System.Console.WriteLine("а - Сложение ");
            System.Console.WriteLine("б - Вычитание ");
            System.Console.WriteLine("в - Умножение ");
            System.Console.WriteLine("г - Деление ");

            string user_input = Console.ReadLine(); 
            
            switch(user_input) { 

               case "а":
                 System.Console.WriteLine("Введите первое число");
                 int sum_1 = Convert.ToInt32(Console.ReadLine()); 
                 System.Console.WriteLine("Введите второе число");
                 int sum_2 = Convert.ToInt32(Console.ReadLine()); 
                 int sum_result = sum_1 + sum_2; 
                 System.Console.WriteLine("Результат сложения: {0}", sum_result);
                 break;

               case "б":
                 System.Console.WriteLine("Введите первое число");
                 int sub_1 = Convert.ToInt32(Console.ReadLine()); 
                 System.Console.WriteLine("Введите второе число");
                 int sub_2 = Convert.ToInt32(Console.ReadLine()); 
                 int sub_result = sub_1 - sub_2; 
                 System.Console.WriteLine("Результат вычитания: {0}", sub_result);
                 break; 

               case "в":
                 System.Console.WriteLine("Введите первое число");
                 int mul_1 = Convert.ToInt32(Console.ReadLine()); 
                 System.Console.WriteLine("Введите второе число");
                 int mul_2 = Convert.ToInt32(Console.ReadLine()); 
                 int mul_result = mul_1 * mul_2; 
                 System.Console.WriteLine("Результат умножения: {0}", mul_result);
                 break; 

               case "г":
                 System.Console.WriteLine("Введите первое число");
                 int div_1 = Convert.ToInt32(Console.ReadLine()); 
                 System.Console.WriteLine("Введите второе число");
                 int div_2 = Convert.ToInt32(Console.ReadLine()); 
                 int div_result = div_1 / div_2; 
                 System.Console.WriteLine("Результат деления: {0}", div_result);
                 break; 
  

            }

            }
            
            }

           
        }
