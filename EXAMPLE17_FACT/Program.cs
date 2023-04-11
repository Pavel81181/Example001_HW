double Factorial (int n)
{
    if (n == 1 || n == 0)  return 1;
    else return n * Factorial(n-1);
 }

   for (int i = 0; i < 10; i++)
{ 
    Console.WriteLine($"{i}! = {Factorial(i)}");
}   
 
//Console.WriteLine(Factorial(10));

/* int Fibonacci(int n)

{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 0; i< 5; i++)
{
    Console.WriteLine(Fibonacci(i));
} 

 Console.WriteLine(Fibonacci(10)); */