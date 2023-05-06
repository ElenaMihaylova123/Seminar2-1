//Задача 6
//Вывести все чётные числа от 1 до N. N задаётся с клавиатуры.


Console.WriteLine("Введи число : ");
int N = Convert.ToInt32(Console.ReadLine());

for(int i=0; i<=N; i++) {
   if(i%2 == 0) {
    Console.Write("{0} ", i);
   }
  }