//Console.Write("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//int square = number * number;
//int square = Convert.ToInt32(Math.Pow(number,2));
//Console.WriteLine("Квадрат от числа " + number + " = " + square);

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N < 0) N = N * (-1);
// int negativeN = N * (-1);
// while (negativeN <= N)
// {
//     Console.WriteLine(negativeN);
//     negativeN++;
// }


// Console.WriteLine("Введите первое число: ");
// int FirstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int SecondNumber = Convert.ToInt32(Console.ReadLine());
// int Max = FirstNumber;
// int Min = SecondNumber;
// int help = FirstNumber;
// if(FirstNumber < SecondNumber)
// {
//     Max = SecondNumber;
//     Min = help;
// }
// Console.WriteLine("Большее число = " + Max);


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2==0) 
{
    Console.WriteLine("Число чётное");
}
else if(number % 2==1)
{
    Console.WriteLine("Число нечётное");
} 