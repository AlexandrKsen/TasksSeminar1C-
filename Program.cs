// Напишите программу, которая на входе принимает число (N), а на выходе показывает 
//все четные числа от 1 до  N (не включая N).

Console.WriteLine("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
{
    
        for (int i = 0; i < N; i++)
    
        if (i % 2 == 0) 
         
        Console.Write($"{i} ");
       
}
