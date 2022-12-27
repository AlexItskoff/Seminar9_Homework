/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/




Console.WriteLine("Enter number M");  
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number N");  
int N = int.Parse(Console.ReadLine());


if (M < 0  || N < 0) 
{
    Console.Write("Mistake! Both numbers should be positive!");
    return;
}

 Console.WriteLine($" Summa = {SumNumbers(M, N)}");

  int SumNumbers(int M, int N)

{
     if (M == 0) return (N * (N + 1)) / 2;            
    else if (N == 0) return (M * (M + 1)) / 2;       
    else if (M == N) return M;                       
    else if (M < N) return N + SumNumbers(M, N - 1); 
    else return N + SumNumbers(M, N + 1);            
}
